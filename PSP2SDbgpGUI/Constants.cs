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
    }

    public enum eErrorCode {
        OK = 0,
        INVALID_ARGUMENT = 7,
        INVALID_COMMAND = 8,
        ARGUMENT_TOO_SMALL = 9,
        INVALID_PROCESS_ID = 0x20011,
        INVALID_VIRUTAL_MEMORY_RANGE = 0x20030,
        INVALID_PHYMEM_ACCESS_SIZE = 0x20031,
    };

}
