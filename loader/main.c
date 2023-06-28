#include <psp2kern/kernel/debug.h>
#include <psp2kern/kernel/sysmem.h>
#include <psp2kern/kernel/intrmgr.h>
#include <psp2kern/kernel/threadmgr.h>
#include <psp2kern/kernel/modulemgr.h>
#include <psp2kern/kernel/iofilemgr.h>

#include <taihen.h>

extern int module_get_export_func(unsigned pid, char* mod, unsigned libnid, unsigned funcnid, void** ppfunc);

SceUID sysmem_log_patch_id = -1;

static const unsigned char mov_r0_1_bx_lr[] = {
    0x4F, 0xF0, 0x01, 0x00, //mov r0, #1
    0x70, 0x47              //bx lr
};

//Generate an DTraceAsyncXCall on targetCPU via a SGI.
//Callback is supposed to accept argp and args but they're not used here, so it doesn't matter.
static int (*emit_DTrace_cb)(unsigned targetCPU, void(*callback)(void), void* argp, unsigned args) = NULL;

void _start() __attribute__((weak, alias("module_start")));
int module_start(SceSize args, void *argp) {
    SceUID sysmem = ksceKernelSearchModuleByName("SceSysmem");

    sysmem_log_patch_id = taiInjectDataForKernel(KERNEL_PID, sysmem, 0, 0x25650, mov_r0_1_bx_lr, sizeof(mov_r0_1_bx_lr));
    ksceKernelPrintf("[SDbgp loader] inject id = 0x%08X\n", sysmem_log_patch_id);

    int res = module_get_export_func(KERNEL_PID, "SceKernelThreadMgr", 0x7F8593BA, 0x0788C9BC, (void**)&emit_DTrace_cb);
    ksceKernelPrintf("[SDbgp loader] get_export_func() = 0x%08X (emit_DTrace_cb @ %p)\n", res, emit_DTrace_cb);

    int status = -1;
    SceUID sdbgp = ksceKernelLoadStartModule("host0:deci4p_sdbgp_400.skprx", 0, NULL, 0, NULL, &status);
    ksceKernelPrintf("[SDbgp loader] mod id = 0x%08X status = %d\n", sdbgp, status);

    if (sdbgp >= 0 && res >= 0) {
        void (*module_bootstart)(void) = NULL;
        res = module_get_export_func(KERNEL_PID, "SceDeci4pSDbgp", 0 /* NONAME */, 0x5C424D40 /* module_bootstart */, (void**)&module_bootstart);
        ksceKernelPrintf("[SDbgp loader] get_export_func() = 0x%08X (module_bootstart @ %p)\n", res, module_bootstart);

        if (res >= 0) {
            for (int i = 0; i < 4; i++) {
                res = emit_DTrace_cb(i, module_bootstart, NULL, 0);
                ksceKernelPrintf("[SDbgp loader] module_bootstart() on CPU%d -> dispatch=0x%08X\n", i, res);
            }
        }
    }

    return 0;
}

int module_stop() {
    return 0;
}