using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSP2SDbgpGUI {
    static public class Constants {
        public const uint SDBGP0_PROTOCOL = 0x10020000;
        public const uint SDBGP1_PROTOCOL = 0x10020001;
        public const uint SDBGP2_PROTOCOL = 0x10020002;
        public const uint SDBGP3_PROTOCOL = 0x10020003;

        public const uint PAGE_SIZE = 4096;
        public const uint SCE_KERNEL_1MiB = (1 << 20);
    }

    public enum eErrorCode {
        OK = 0,
        IllegalParameterValue = 7,
        UNEXPECTED_GROUP_OR_TYPE = 8,
        IllegalPayloadSize = 9,
        REPLY_TOO_BIG = 10,
        GENERIC_FAILURE = 0x20000, //Returned if an error happens when calling an external module
        IllegalProcessId = 0x20011,
        IllegalThreadId = 0x20012,
        IllegalSetRegisterIndex = 0x20020,
        IllegalSetRegisterMode = 0x20021,
        IllegalAddress = 0x20030,
        INVALID_PHYMEM_ACCESS_SIZE = 0x20031,
        IllegalHwwatchptId = 0x20040,
        NoFreeHwwatchpt = 0x20041,
        //GUESSED:
        //IllegalHwbrkptId = 0x20044
        NoFreeHwbrkpt = 0x20045,
        IllegalSwbrkptId = 0x20046,
        Overflow = 0x20070,

        //Standard kernel errors
        SCE_KERNEL_ERROR_NO_IOADDR = -0x7FFDBEFC, //0x80024104
    }

    //Names that are not in capital are unsure
    public enum eCommandGroup : byte {
        SYSTEM_GROUP = 0x10,
        PROCESS_GROUP = 0x20,
        THREAD_GROUP = 0x30,
        MODULE_GROUP = 0x40,
        group_0x50 = 0x50, //Accepted, but has never been useful (?)
        FILE_GROUP = 0x60,
        network_group = 0x70,
        group_0x90 = 0x90, //Gated by dipsw 0xD7 (must be 0)
        MISC_GROUP = 0xF0,
    }
}
