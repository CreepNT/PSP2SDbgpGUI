using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSP2SDbgpGUI {
    public class ASLR {
        public struct Mapping {
            string name;
            uint vbase;
            uint vsize;
            uint extraHigh;

            public Mapping(string _name, uint _vbase, uint _vsize, uint _extraHigh) {
                name = _name;
                vbase = _vbase;
                vsize = _vsize;
                extraHigh = _extraHigh;
            }

            public override string ToString()  {
                if (extraHigh != 0) {
                    return string.Format("{0}: 0x{1:X}-0x{2:X} (mapped size=0x{3:X}, extraHigh=0x{4:X})",
                        name, vbase, vbase + vsize - extraHigh - 1, vsize - extraHigh, extraHigh);
                } else {
                    return string.Format("{0}: 0x{1:X}-0x{2:X} (size=0x{3:X})", name, vbase, vbase + vsize - 1, vsize);
                }
            }
        }

        public Mapping[] mappings = new Mapping[13];

        public ASLR(uint seed) {
            uint PAGE_SIZE = Constants.PAGE_SIZE;
            bool[] ASLR_BITMAP = new bool[256];
            bool[] MEGA_ASLR_BITMAP = new bool[16];

            Func<uint, uint, int> ASLR_bitmap_alloc = delegate (uint offset, uint size) {
                offset /= PAGE_SIZE;
                size /= PAGE_SIZE;
                if (ASLR_BITMAP[offset % 256]) {
                    return -1;
                }

                uint lastIdx = offset + size;
                for (uint i = offset; i < lastIdx; i++) {
                    if (ASLR_BITMAP[i % 256]) {
                        return -1;
                    }
                }
                for (uint i = offset; i < lastIdx; i++) {
                    ASLR_BITMAP[i % 256] = true;
                }
                return 0;
            };

            Action __reseed = delegate () {
                seed = (seed >> 5) | (seed << 27); //s = ror(s, 5);
            };

            Func<uint, uint> MapASLR = delegate (uint size) {
                __reseed();

                uint maxIdx = 256 / (size / PAGE_SIZE);
                uint unk2 = seed % maxIdx;
                maxIdx += unk2;
                while (unk2 < maxIdx) {
                    uint unk3 = size * unk2;
                    uint offset = unk3 & 0xFFFFF;
                    int res = ASLR_bitmap_alloc(offset, size);
                    unk2++;
                    unk3 += size;
                    if (res >= 0) {        
                        return offset;
                    }
                }
                throw new InvalidOperationException("MapASLR failed");
            };

            int mapIdx = 0;
            Action<string, uint, uint> add_mapping = delegate (string name, uint vsize, uint extraHigh) {
                mappings[mapIdx++] = new Mapping(name, MapASLR(vsize), vsize, extraHigh);
            };

            ASLR_bitmap_alloc(0, 0x4000);   //Reserve the first four pages ("SceKernelReset")
            MEGA_ASLR_BITMAP[0] = true;     //First MEGA page is handled by the ASLR bitmap

            uint L2PT_va = MapASLR(0x1000); //SCE moment...
            mappings[mapIdx++] = new Mapping("SceKernelL2PageTable000", L2PT_va, 0x2000, 0x1000);
            add_mapping("SceSysroot", 0x4000, 0);
            add_mapping("SceKernelTTBR0", 0x4000, 0);
            add_mapping("SceKernelTTBR1", 0x4000, 0);
            add_mapping("SceKernelFixedHeap32B", 0x10000, 0);
            add_mapping("SceKernelFixedHeap48B", 0x10000, 0);
            add_mapping("SceKernelFixedHeap64B", 0x10000, 0);
            add_mapping("SceKernelFixedHeapUIDEntry", 0x10000, 0);
            add_mapping("SceKernelExceptionEntry", 0x2000, 0x1000);
            add_mapping("SceKernelFixedHeapForL2Object", 0x2000, 0x1000);
            add_mapping("SceKernelL2Vector", 0x8000, 0x4000);
            {
                uint idx = (seed >> 5) & 0xF;
                uint maxIdx = idx + 0x10;
                while (MEGA_ASLR_BITMAP[idx % 16]) {
                    idx++;
                    if (idx >= maxIdx) {
                        throw new InvalidOperationException("MapMegaASLR failed");
                    }
                }
                MEGA_ASLR_BITMAP[idx % 16] = true;

                uint map_va = idx * Constants.SCE_KERNEL_1MiB;
                mappings[mapIdx++] = new Mapping("SceKernelPhyPageTable", map_va, 0x80000, 0);
                mappings[mapIdx++] = new Mapping("SceKernelPhyPageTableHigh", map_va + 0x80000, 0x80000, 0);
            }
        }
    }
}
