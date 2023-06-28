using System;
using System.Windows.Forms;
using PSP2TMAPILib;

namespace PSP2SDbgpGUI {
    public class PacketManager : IEventCustomProtocol {
        private TextBox logTextBox;

        public PacketManager(TextBox log) {
            logTextBox = log;
        }

        public void sendPacket(Packet packet, ITarget target) {
            sendPacket(packet, target, Constants.SDBGP0_PROTOCOL);
        }

        public void sendPacket(Packet packet, ITarget target, uint uProtocol) {
            log_println(packet.ToString(false));
            target.SendCustomProtocolData(uProtocol, packet.raw);
        }

        /// Private helper functions

        private void log_println(string s) {
            s += Environment.NewLine;
            Action a = delegate { logTextBox.AppendText(s); };
            if (!logTextBox.InvokeRequired) {
                a.Invoke();
            } else {
                logTextBox.Invoke(a);
            }
        }

        private bool isSupportedProtocol(uint uProtocol) {
            return uProtocol == Constants.SDBGP0_PROTOCOL ||
                uProtocol == Constants.SDBGP1_PROTOCOL ||
                uProtocol == Constants.SDBGP2_PROTOCOL ||
                uProtocol == Constants.SDBGP3_PROTOCOL;
        }

        /// IEventCustomProtocol functions

        public void OnErrorInvalidHeader(uint uProtocol, object Packet) {
            throw new NotImplementedException();
        }

        public void OnErrorNoConnection(uint uProtocol, object Packet) {
            throw new NotImplementedException();
        }

        public void OnErrorNoProtocol(uint uProtocol, object Packet) {
            throw new NotImplementedException();
        }

        public void OnErrorNoSpace(uint uProtocol, object Packet) {
            throw new NotImplementedException();
        }

        public void OnPacketReceived(uint uProtocol, object Packet, uint uFragmentSeq, uint uAttributes) {
            if (!isSupportedProtocol(uProtocol))
                return;

            Packet received = new Packet((byte[])Packet);
            string s = received.ToString(true);
            if (uFragmentSeq != 0 || uAttributes != 0) {
                s += string.Format(" (Attr=0x{0:X}, FragSeq={1})", uAttributes, uFragmentSeq);
            }

            log_println(s);
        }

        public void OnStatusForceUnregistered(uint uProtocol, string bstrRequester) {
            throw new NotImplementedException();
        }

        public void OnStatusProtocol(uint uProtocol, uint uProtocolVersion, uint uProtocolLimit, uint uTargetNode, uint uStatus) {
            throw new NotImplementedException();
        }

        public void OnStatusSpace() {
            throw new NotImplementedException();
        }
    }

    //N.B. all sizes and offsets are given *including the header*
    //even though the header is not stored in the packet
    /// <summary>
    /// Class representing a single SDbgp packet.
    /// 
    /// Note that all offsets and sizes in this class take a 0x10-sized header
    /// into account but it is not accessible, as it is managed by psp2tm.
    /// </summary>
    public class Packet {
        /// <summary>
        /// Size of the header prepended to the packet by the transport layer
        /// </summary>
        public const uint HDR_SIZE = 0x10;

        /// <summary>
        /// Minimal packet size (including header size)
        /// </summary>
        public const uint MINIMAL_PACKET_SIZE = 0x14;

        /// <summary>
        /// Offset of common packet fields
        /// </summary>
        public const uint ISREPLY_OFFSET = 0x10;
        public const uint COMMAND_OFFSET = 0x11;
        public const uint SUBCMD_OFFSET = 0x12;
        public const uint UNK13_OFFSET = 0x13;

        /// <summary>
        /// Offset of common REPLY packet fields
        /// 
        /// These offsets don't apply to a sent packet.
        /// </summary>
        public const uint UNK14_OFFSET = 0x14;
        public const uint UNK15_OFFSET = 0x15;
        public const uint UNK16_OFFSET = 0x16; //u16
        public const uint ERRCODE_OFFSET = 0x18; //u32

        public byte[] raw;

        public Packet(uint size) {
            if (size < MINIMAL_PACKET_SIZE) {
                throw new System.ArgumentException(string.Format("Packet size 0x{0:X} is too small", size));
            }
            raw = new byte[size - HDR_SIZE];
        }

        public Packet(byte[] pckt) {
            raw = pckt;
        }

        public bool isReply() { return (getU8(ISREPLY_OFFSET) == 1); }

        public byte getCommand() { return getU8(COMMAND_OFFSET); }
        public void setCommand(byte cmd) { setU8(COMMAND_OFFSET, cmd); }

        public byte getSubCommand() { return getU8(SUBCMD_OFFSET); }
        public void setSubCommand(byte subcmd) { setU8(SUBCMD_OFFSET, subcmd); }

        public eErrorCode getErrorCode() {
            return (eErrorCode)getU32(ERRCODE_OFFSET);
        }

        /// Arbitrary set/get primivites

        public byte getU8(uint offset) { return raw[offset - HDR_SIZE]; }
        public void setU8(uint offset, byte u8) { raw[offset - HDR_SIZE] = u8; }

        public ushort getU16(uint offset) {
            offset -= HDR_SIZE;
            return (ushort)(raw[offset] | (raw[offset + 1] << 8));
        }
        public void setU16(uint offset, ushort u16) {
            offset -= HDR_SIZE;
            raw[offset] = (byte)(u16 & 0xFF);
            raw[offset + 1] = (byte)((u16 >> 8) & 0xFF);
        }

        public uint getU32(uint offset) {
            offset -= HDR_SIZE;
            uint res = raw[offset];
            res |= (uint)(raw[offset + 1] << 8);
            res |= (uint)(raw[offset + 2] << 16);
            res |= (uint)(raw[offset + 3] << 24);
            return res;
        }
        public void setU32(uint offset, uint u32) {
            offset -= HDR_SIZE;
            raw[offset] = (byte)(u32 & 0xFF);
            raw[offset + 1] = (byte)((u32 >> 8) & 0xFF);
            raw[offset + 2] = (byte)((u32 >> 16) & 0xFF);
            raw[offset + 3] = (byte)((u32 >> 24) & 0xFF);
        }

        
        public override string ToString() {
            return ToString(true);
        }

        public string ToString(bool includeErrorCode) {
            string self = string.Format("0x{0:X2} ", raw.Length);
            if (isReply())
                self += "-> ";
            else
                self += "<- ";

            self += string.Format("C={0:X2} S={1:X2} ", getCommand(), getSubCommand());

            self += "[ ";
            foreach (byte b in raw) {
                self += string.Format("{0:X2} ", b);
            }
            self += "]";

            if (includeErrorCode && getErrorCode() != 0) {
                self += string.Format(" Err=0x{0:X}/{1}", (uint)getErrorCode(), getErrorCode());
            }

            return self;
        }
    }
}

