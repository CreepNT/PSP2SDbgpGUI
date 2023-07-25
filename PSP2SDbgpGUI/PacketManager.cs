using System;
using System.Threading;
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
            sendPacket(packet, target, uProtocol, false);
        }

        public void sendPacket(Packet packet, ITarget target, uint uProtocol, bool quiet) {
            if (!quiet) {
                log_println(packet.ToString(false));
            }
            target.SendCustomProtocolData(uProtocol, packet.raw);
        }

        //Could we do better?
        private static Packet DUMMY = new Packet(Packet.MINIMAL_PACKET_SIZE);
        private Packet answerPacket = DUMMY;
        private AutoResetEvent waitEvent = new AutoResetEvent(false);
        public Packet sendPacketAndReadAnswer(Packet packet, ITarget target) {
            return sendPacketAndReadAnswer(packet, target, true);
        }

        public Packet sendPacketAndReadAnswer(Packet packet, ITarget target, bool quiet) {
            System.Diagnostics.Debug.Assert(answerPacket != null);
            answerPacket = null;
            sendPacket(packet, target, Constants.SDBGP0_PROTOCOL, quiet);
            waitEvent.WaitOne();
            return answerPacket;
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
            log_println(String.Format("OnErrorInvalidHeader(0x{0:X8}, ...)", uProtocol));
        }

        public void OnErrorNoConnection(uint uProtocol, object Packet) {
            log_println(String.Format("OnErrorNoConnection(0x{0:X8}, ...)", uProtocol));
        }

        public void OnErrorNoProtocol(uint uProtocol, object Packet) {
            log_println(String.Format("OnErrorNoProtocol(0x{0:X8}, ...)", uProtocol));
        }

        public void OnErrorNoSpace(uint uProtocol, object Packet) {
            log_println(String.Format("OnErrorNoSpace(0x{0:X8}, ...)", uProtocol));
        }

        public void OnPacketReceived(uint uProtocol, object Packet, uint uFragmentSeq, uint uAttributes) {
            if (!isSupportedProtocol(uProtocol))
                return;

            Packet received = new Packet((byte[])Packet);
            string s = received.ToString(true);
            if (uFragmentSeq != 0 || uAttributes != 0) {
                s += string.Format(" (Attr=0x{0:X}, FragSeq={1})", uAttributes, uFragmentSeq);
            }

            if (answerPacket == null) {
                //Don't log answer packets when app is asking to read the packet
                answerPacket = received;
                waitEvent.Set();
            } else {
                log_println(s);
            }
        }

        public void OnStatusForceUnregistered(uint uProtocol, string bstrRequester) {
            log_println(string.Format("OnStatusForceUnregistered(0x{0:X8}, {1})", uProtocol, bstrRequester));
        }

        public void OnStatusProtocol(uint uProtocol, uint uProtocolVersion, uint uProtocolLimit, uint uTargetNode, uint uStatus) {
            log_println(string.Format("OnStatusProtocol(0x{0:X8}, 0x{1:X8}, 0x{2:X8}, 0x{3:X8}, 0x{4:X8})", uProtocol, uProtocolVersion, uProtocolLimit, uTargetNode, uStatus));
        }

        public void OnStatusSpace() {
            log_println("OnStatusSpace()");
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
        public const uint GROUP_OFFSET = 0x11;
        public const uint TYPE_OFFSET = 0x12;
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

        public eCommandGroup getCmdGroup() { return (eCommandGroup)getU8(GROUP_OFFSET); }
        public void setCmdGroup(byte group) { setU8(GROUP_OFFSET, group); }
        public void setCmdGroup(eCommandGroup g) => setCmdGroup((byte)g);

        public byte getCmdType() { return getU8(TYPE_OFFSET); }
        public void setCmdType(byte type) { setU8(TYPE_OFFSET, type); }

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

        public string getString(uint offset, uint maxLength) {
            offset -= HDR_SIZE;

            byte[] rawString = new byte[maxLength];
            Buffer.BlockCopy(raw, (int)offset, rawString, 0, (int)maxLength);

            uint NULidx = maxLength;
            for (uint i = 0; i < maxLength; i++) {
                if (rawString[i] == 0) {
                    NULidx = i;
                    break;
                }
            }

            if (NULidx == 0)
                return "";

            if (NULidx != maxLength) {
                byte[] tmp = new byte[NULidx];
                Buffer.BlockCopy(rawString, 0, tmp, 0, tmp.Length);
                rawString = tmp;
            }
            return System.Text.Encoding.UTF8.GetString(rawString);
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

            self += string.Format("{0:X2}:{1:X2} ", (uint)getCmdGroup(), getCmdType());

            self += "[ ";
            foreach (byte b in raw) {
                self += string.Format("{0:X2} ", b);
            }
            self += "]";

            
            if (includeErrorCode) {
                eErrorCode err = getErrorCode();
                if (err == eErrorCode.OK)
                    return self;

                if (Enum.IsDefined(typeof(eErrorCode), err)) {
                    self += string.Format(" Err={0} (0x{1:X})", err, (uint)err);
                } else {
                    self += string.Format(" Err=0x{0:X}", (uint)err);
                }
            }

            return self;
        }
    }
}

