using System;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Runtime.InteropServices;

using PSP2TMAPILib;

namespace PSP2SDbgpGUI {

    public enum eLinkStatus {
        DISCONNECTED,           //Not connected to any target
        CONNECTED_NO_PROTOCOL,  //Connected to target, but protocol is not available
        CONNECTED_AND_LINKED    //Connected to target & linked to SDbgp protocol
    };

    public partial class MainForm : Form {

        private PSP2TMAPI m_TMApi;
        //private ITarget m_target;
        private eLinkStatus m_targetStatus;
        private PacketManager m_packetMgr;

        public MainForm() {
            InitializeComponent();

            m_TMApi = new PSP2TMAPI();
            m_TMApi.CheckCompatibility((uint)eCompatibleVersion.BuildVersion);
        }

        private void MainForm_Load(object sender, EventArgs e) {
            ITarget selected = refreshTargetListMenu();
            if (selected != null) {
                //Kickoff attach to a secondary thread because power on is blocking and slow
                Task.Run(() => { attachToSelectedTarget(); });
            }

            arbitraryTab_regeneratePreview();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) {
            detachFromCurrentTarget();
        }

        ///
        /// Log functions
        ///

        private void log_println(string s) {
            Action a = delegate { logTextBox.AppendText(s + Environment.NewLine); };
            if (logTextBox.InvokeRequired) {
                logTextBox.Invoke(a);
            } else {
                a.Invoke();
            }
        }

        ///
        /// Target link functions
        ///

        private void setNewLinkStatus(eLinkStatus newStatus) {
            Action a = delegate {
                m_targetStatus = newStatus;
                string windowTitle = "SDbgp Tool for PlayStation®Vita";
                switch (newStatus) {
                    case eLinkStatus.DISCONNECTED:
                        targetPicker_statusLabel.Text = "Status: Disconnected";
                        targetPicker_linkToSelectedBtn.Visible = false;
                        tabControl.Enabled = false;
                        break;
                    case eLinkStatus.CONNECTED_NO_PROTOCOL:
                        targetPicker_statusLabel.Text = "Status: Connected (not linked)";
                        targetPicker_linkToSelectedBtn.Visible = true;
                        tabControl.Enabled = false;
                        break;
                    case eLinkStatus.CONNECTED_AND_LINKED:
                        ITarget target = getCurrentlySelectedTarget();
                        windowTitle = target.Name + " - " + windowTitle;
                        targetPicker_statusLabel.Text = "Status: Linked to SDbgp";
                        targetPicker_linkToSelectedBtn.Visible = false;
                        tabControl.Enabled = true;
                        break;
                }
                Text = windowTitle;
            };

            Invoke(a);
        }

        private void attachToSelectedTarget() {
            detachFromCurrentTarget();
            setNewLinkStatus(eLinkStatus.DISCONNECTED);

            //Prevent refresh or new attach while an operation is in progress
            targetPicker_refreshListBtn.Enabled = false;
            foreach (ToolStripItem tsi in targetPicker_menu.DropDownItems) {
                if (tsi.Tag != null)
                    tsi.Enabled = false;
            }

            ITarget target = getCurrentlySelectedTarget();

            if (!isTargetAvailable(target))
                return;

            try {
                if (target.PowerStatus != ePowerStatus.POWER_STATUS_ON) {
                    target.PowerOn();
                }

                if (target.ConnectionState != eConnectionState.CONNECTION_CONNECTED) {
                    target.Connect();
                }

                refreshTargetListMenu();
                Invoke((Action)delegate { processControl_refreshProcessList(); });

                setNewLinkStatus(eLinkStatus.CONNECTED_NO_PROTOCOL);
            } catch (COMException e) {
                log_println(string.Format("Failed bringup of {0}: 0x{1:X} - {2}", target.Name, e.HResult, e.Message));
                goto cleanup;
            }

            try {
                uint uVersion, uVersionLimit, uNodeID;
                target.ProtocolAvailabilityInfo(Constants.SDBGP0_PROTOCOL, out uVersion, out uVersionLimit, out uNodeID);

                target.RegisterCustomProtocol(Constants.SDBGP0_PROTOCOL);
                target.RegisterCustomProtocol(Constants.SDBGP1_PROTOCOL); // SDBGP1
                target.RegisterCustomProtocol(Constants.SDBGP2_PROTOCOL); // SDBGP2
                target.RegisterCustomProtocol(Constants.SDBGP3_PROTOCOL); // SDBGP3

                m_packetMgr = new PacketManager(logTextBox);
                target.AdviseCustomProtocol(m_packetMgr);

                setNewLinkStatus(eLinkStatus.CONNECTED_AND_LINKED);
            } catch (COMException e) {
                log_println(string.Format("Failed protocol registration with {0}: 0x{1:X} - {2}", target.Name, e.HResult, e.Message));
                goto cleanup;
            }

        cleanup:
            targetPicker_refreshListBtn.Enabled = true;
            foreach (ToolStripItem tsi in targetPicker_menu.DropDownItems) {
                if (tsi.Tag != null)
                    tsi.Enabled = true;
            }
            return;
        }

        private void detachFromCurrentTarget() {
            ITarget target = getCurrentlySelectedTarget();
            if (target != null && m_targetStatus == eLinkStatus.CONNECTED_AND_LINKED) {
                target.UnregisterCustomProtocol(Constants.SDBGP0_PROTOCOL, false);
                target.UnregisterCustomProtocol(Constants.SDBGP1_PROTOCOL, false);
                target.UnregisterCustomProtocol(Constants.SDBGP2_PROTOCOL, false);
                target.UnregisterCustomProtocol(Constants.SDBGP3_PROTOCOL, false);

                target.UnadviseCustomProtocol(m_packetMgr);
            }

            setNewLinkStatus(eLinkStatus.DISCONNECTED);
        }

        ///
        /// Target picker code
        ///

        private static string getTargetButtonLabel(ITarget t) {
            string label = (t.Default) ? "★ " : "";
            label += t.Name;

            try {
                if (t.PowerStatus == ePowerStatus.POWER_STATUS_NO_SUPPLY) {
                    label += " (No AC)";
                } else if (t.PowerStatus == ePowerStatus.POWER_STATUS_OFF) {
                    label += " (Off)";
                } else if (t.PowerStatus == ePowerStatus.POWER_STATUS_ON) {
                    label += " (On)";
                }
            } catch (COMException) {
                label += " (Not Available)";
            }
            return label;
        }

        private ToolStripMenuItem getCurrentlySelectedTargetButton() {
            foreach (ToolStripItem i in targetPicker_menu.DropDownItems) {
                if (i.Tag != null && ((ToolStripMenuItem)i).Checked) {
                    return (ToolStripMenuItem)i;
                }
            }
            return null;
        }

        private ITarget getCurrentlySelectedTarget() {
            ToolStripMenuItem tsmi = getCurrentlySelectedTargetButton();
            return (tsmi == null) ? null : (ITarget)tsmi.Tag;
        }

        private void targetBtn_Click(object sender, EventArgs e) {
            ToolStripMenuItem clicked = (ToolStripMenuItem)sender;
            if (clicked.Checked == true) { //Do nothing if user clicks on already selected target
                return;
            }

            ToolStripMenuItem cur = getCurrentlySelectedTargetButton();

            cur.Checked = false;
            cur.Enabled = true;

            clicked.Enabled = false;

            refreshTargetListMenu();
            attachToSelectedTarget();
        }

        /// <summary>
        /// Refreshes the list of available targets.
        /// If a target was selected and is still available, it remains selected.
        /// Otherwise, the default target is selected instead.
        /// 
        /// Returns the selected ITarget, or null if none is available.
        /// </summary>
        private ITarget refreshTargetListMenu() {
            ITargetCollection targets = m_TMApi.Targets;
            if (targets.Count == 0) {
                //Remove all target buttons
                foreach (ToolStripItem i in targetPicker_menu.DropDownItems) {
                    if (i.Tag != null) {
                        targetPicker_menu.DropDownItems.Remove(i);
                    }
                }

                targetPicker_noTargetAvailableLabel.Visible = true;
                return null;
            }
            targetPicker_noTargetAvailableLabel.Visible = false;

            List<ITarget> newTargets = new List<ITarget>((int)targets.Count);
            foreach (ITarget t in targets) {
                Console.WriteLine(t.ToString());
                newTargets.Add(t);
            }

            bool selectedTargetStillAvailable = false;
            ITarget bestNewSelection = targets.FirstConnected;
            if (bestNewSelection == null)
                bestNewSelection = targets.FirstAvailable;
            if (bestNewSelection == null)
                bestNewSelection = targets.DefaultTarget;

            ToolStripMenuItem bnsTSMI = null;

            //Update all existing buttons (remove if necessary)
            foreach (ToolStripItem item in targetPicker_menu.DropDownItems) {
                if (item.Tag != null) {
                    ToolStripMenuItem tsmi = (ToolStripMenuItem)item;
                    ITarget t = (ITarget)tsmi.Tag;

                    newTargets.RemoveAll( (it) => { return it.HardwareId == t.HardwareId; });

                    //Check for duplicates and remove them
                    if (targets.GetByHardwareId(t.HardwareId) == null) { //Target is gone
                        targetPicker_menu.DropDownItems.Remove(item);
                    } else {
                        tsmi.Text = getTargetButtonLabel(t);

                        if (t.HardwareId == bestNewSelection.HardwareId)
                            bnsTSMI = tsmi;

                        if (tsmi.Checked)
                            selectedTargetStillAvailable = true;
                    }
                }
            }

            //Add a button for all new targets
            foreach (ITarget t in newTargets) {
                ToolStripMenuItem targetBtn = new ToolStripMenuItem(getTargetButtonLabel(t));
                targetBtn.Click += targetBtn_Click;
                targetBtn.AutoSize = true;
                targetBtn.Tag = t;

                if (t.HardwareId == bestNewSelection.HardwareId)
                    bnsTSMI = targetBtn;

                targetPicker_menu.DropDownItems.Add(targetBtn);
            }

            if (selectedTargetStillAvailable) {
                return getCurrentlySelectedTarget();
            } else {
                bnsTSMI.Enabled = false;
                bnsTSMI.Checked = true;
                return bestNewSelection;
            }
        }

        private void targetPicker_refreshListBtn_Click(object sender, EventArgs e) {
            refreshTargetListMenu();
        }

        private void targetPicker_linkToSelectedBtn_Click(object sender, EventArgs e) {
            attachToSelectedTarget();
        }

        ///
        /// Log management functions
        ///

        private void clearLogToolStripMenuItem_Click(object sender, EventArgs e) {
            logTextBox.Text = "";
        }

        private void saveToFileToolStripMenuItem_Click(object sender, EventArgs e) {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.AddExtension = true;
            sfd.CheckFileExists = true;
            sfd.DefaultExt = "txt";
            sfd.OverwritePrompt = true;
            sfd.RestoreDirectory = true;
            sfd.Title = "Save log as...";
            sfd.ValidateNames = true;

            DialogResult res = sfd.ShowDialog();
            if (res == DialogResult.OK) {
                System.IO.Stream logFile = sfd.OpenFile();
                byte[] logContents = System.Text.Encoding.UTF8.GetBytes(logTextBox.Text.ToCharArray());
                logFile.Write(logContents, 0, logContents.Length);
                logFile.Close();
            }

            sfd.Dispose();
        }

        ///
        /// Helper/misc functions
        ///

        private bool isTargetAvailable(ITarget t) {
            try {
                ePowerStatus s = t.PowerStatus;
                return true;
            } catch (COMException) {
                return false;
            }
        }

        private void sendPacket(Packet p) {
            m_packetMgr.sendPacket(p, getCurrentlySelectedTarget());
        }

        ///
        /// Commands
        ///

            /* kshow */
        private void kshowSendCmd(object sender, EventArgs e) {
            string selected = (string)kshowCmdListBox.SelectedItem;
            string hex = selected.Split(':')[0];
            uint kshow = Convert.ToUInt32(hex, 16);

            Packet pckt = new Packet(0x24);
            pckt.setCommand(0xF0); pckt.setSubCommand(8);
            pckt.setU32(0x14, kshow);

            sendPacket(pckt);
        }

        private void kshowCmdListBox_SelectedIndexChanged(object sender, EventArgs e) {
            kshowSendCmdBtn.Enabled = true;
        }

        #region Custom command
        private byte[] arbitraryTab_serializeAdditionalBytes() {
            try {
                string commandBytes = arbitraryTab_additionalBytesTextBox.Text;
                byte[] res = new byte[commandBytes.Length / 2];

                for (int i = 0; i < res.Length; i++) {
                    string hexval = commandBytes.Substring(2 * i, 2);
                    res[i] = Convert.ToByte(hexval, 16);
                }
                return res;
            } catch {
                return null;
            }
        }

        private void arbitraryTab_regeneratePreview() {
            byte[] addBytes = arbitraryTab_serializeAdditionalBytes();
            if (addBytes == null) {
                arbitraryTab_cmdPreviewTextBox.Text = "Invalid command (check additional bytes)";
            } else {
                uint packetSize = (uint)addBytes.Length + (Packet.MINIMAL_PACKET_SIZE - Packet.HDR_SIZE);
                arbitraryTab_cmdPreviewTextBox.Text = string.Format("* Command size: 0x{0:X}/{0} bytes" + Environment.NewLine + Environment.NewLine, packetSize);

                Packet pkt = new Packet(Packet.MINIMAL_PACKET_SIZE);
                pkt.setCommand((byte)arbitraryTab_cmdIdUpDown.Value);
                pkt.setSubCommand((byte)arbitraryTab_subCmdIdUpDown.Value);
                pkt.setU8(Packet.UNK13_OFFSET, (byte)arbitraryTab_unk13UpDown.Value);

                foreach (byte b in pkt.raw) {
                    arbitraryTab_cmdPreviewTextBox.AppendText(string.Format("{0:X2} ", b));
                }
                foreach (byte b in addBytes) {
                    arbitraryTab_cmdPreviewTextBox.AppendText(string.Format("{0:X2} ", b));
                }
            }
            
        }

        private void arbitraryTab_UpDown_ValueChanged(object sender, EventArgs e) {
            arbitraryTab_regeneratePreview();
        }

        private bool arbitraryTabIsLegalCharacter = false;
        private void arbitraryTab_additionalBytesTextBox_KeyDown(object sender, KeyEventArgs e) {
            if (Keys.A <= e.KeyCode && e.KeyCode <= Keys.F)
                arbitraryTabIsLegalCharacter = true;
            else if (Keys.D0 <= e.KeyCode && e.KeyCode <= Keys.D9)
                arbitraryTabIsLegalCharacter = true;
            else if (Keys.NumPad0 <= e.KeyCode && e.KeyCode <= Keys.NumPad9)
                arbitraryTabIsLegalCharacter = true;
            else if (e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete)
                arbitraryTabIsLegalCharacter = true;
            else if (e.Control)
                arbitraryTabIsLegalCharacter = true;
            else
                arbitraryTabIsLegalCharacter = false;
        }

        private void arbitraryTab_additionalBytesTextBox_KeyPress(object sender, KeyPressEventArgs e) {
            if (arbitraryTabIsLegalCharacter == false)
                e.Handled = true;
        }

        private void arbitraryTab_additionalBytesTextBox_KeyUp(object sender, KeyEventArgs e) {
            arbitraryTab_regeneratePreview();
        }

        private void arbitraryTab_additionalBytesTextBox_TextChanged(object sender, EventArgs e) {
            TextBox self = (TextBox)sender;
            self.Text = self.Text.Replace(" ", "");
        }

        private void arbitraryTab_sendCmdBtn_Click(object sender, EventArgs e) {
            byte[] addbytes = arbitraryTab_serializeAdditionalBytes();
            if (addbytes == null) {
                return;
            }

            Packet pckt = new Packet(Packet.MINIMAL_PACKET_SIZE + (uint)addbytes.Length);
            pckt.setCommand((byte)arbitraryTab_cmdIdUpDown.Value);
            pckt.setSubCommand((byte)arbitraryTab_subCmdIdUpDown.Value);
            pckt.setU8(Packet.UNK13_OFFSET, (byte)arbitraryTab_unk13UpDown.Value);

            uint offset = Packet.UNK13_OFFSET + 1;
            foreach (byte b in addbytes) {
                pckt.setU8(offset, b);
                offset++;
            }

            sendPacket(pckt);
        }

        private void arbitraryTab_clearCmdBtn_Click(object sender, EventArgs e) {
            arbitraryTab_cmdIdUpDown.Value = 0;
            arbitraryTab_subCmdIdUpDown.Value = 0;
            arbitraryTab_unk13UpDown.Value = 0;
            arbitraryTab_additionalBytesTextBox.Text = "";
            arbitraryTab_regeneratePreview();
        }
        #endregion

        #region Physical memory

        private uint phymemRW_accessSize_log2 = 0;
        private void phymemRW_size_radioBtn_Clicked(object sender, EventArgs e) {
            if (sender.Equals(phymemRW_size_8bits_radioBtn)) {
                phymemRW_written_value_UpDown.Maximum = 255;
                phymemRW_accessSize_log2 = 0;
            } else if (sender.Equals(phymemRW_size_16bits_radioBtn)) {
                phymemRW_written_value_UpDown.Maximum = 0xFFFF;
                phymemRW_accessSize_log2 = 1;
            } else if (sender.Equals(phymemRW_size_32bits_radioBtn)) {
                phymemRW_written_value_UpDown.Maximum = 0xFFFFFFFF;
                phymemRW_accessSize_log2 = 2;
            }
        }

        private void phymemReadBtn_Click(object sender, EventArgs e) {
            uint targetPA = Convert.ToUInt32(phymemRW_target_PA_TextBox.Text, 16);

            Packet pckt = new Packet(0x20);
            pckt.setCommand(0x10);
            pckt.setSubCommand(0x9A);
            pckt.setU32(0x14, targetPA);
            pckt.setU32(0x18, (uint)(1 << (int)phymemRW_accessSize_log2));
            pckt.setU32(0x1C, phymemRW_accessSize_log2);

            sendPacket(pckt);
        }

        private void phymemRW_write_Btn_Click(object sender, EventArgs e) {
            uint targetPA = Convert.ToUInt32(phymemRW_target_PA_TextBox.Text, 16);

            Packet pckt = new Packet(0x20 + 4);
            pckt.setCommand(0x10);
            pckt.setSubCommand(0x9A);
            pckt.setU32(0x14, targetPA);
            pckt.setU32(0x18, (uint)(1 << (int)phymemRW_accessSize_log2));
            pckt.setU32(0x1C, phymemRW_accessSize_log2);
            pckt.setU32(0x20, (uint)phymemRW_written_value_UpDown.Value);

            sendPacket(pckt);
        }

        #endregion

        #region Process

        private uint processControl_getSelectedProcessId() {
            uint pid = 0;
            string procname = (string)process_plistComboBox.SelectedItem;
            if (procname != null) {
                pid = Convert.ToUInt32(procname.Substring(0, procname.IndexOf(" ")), 16);
            }
            return pid;
        }

        private IProcessInfo processControl_getSelectedProcess() {
            ITarget curTarget = getCurrentlySelectedTarget();
            return curTarget.ProcessInfoSnapshot.GetById(processControl_getSelectedProcessId());
        }

        private void processControl_refreshProcessList() {
            ITarget target = getCurrentlySelectedTarget();
            IProcessInfoCollection processes = target.ProcessInfoSnapshot;

            int i = 0;
            int selectedIdx = -1;
            uint selectedPID = processControl_getSelectedProcessId();

            process_plistComboBox.Items.Clear();
            foreach (IProcessInfo info in processes) {
                if (info.Id == selectedPID)
                    selectedIdx = i;

                process_plistComboBox.Items.Add(string.Format("0x{0:X} - {1}", info.Id, info.Name));
                i++;
            }

            if (selectedIdx != -1) {
                process_plistComboBox.SelectedIndex = selectedIdx;
                processControl_panel.Enabled = true;
            } else {
                processControl_panel.Enabled = false;
            }
        }

        private void processControl_refreshPlistBtn_Click(object sender, EventArgs e) {
            processControl_refreshProcessList();
        }

        private void processControl_plistComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            processControl_panel.Enabled = true;
        }

        private void processControl_killBtn_Click(object sender, EventArgs e) {
            Packet pkt = new Packet(0x18);
            pkt.setCommand(0x20);
            pkt.setSubCommand(0x84);
            pkt.setU32(0x14, processControl_getSelectedProcessId());
            sendPacket(pkt);

            processControl_refreshProcessList();
        }

        private void processControl_suspendBtn_Click(object sender, EventArgs e) {
            Packet pkt = new Packet(0x18);
            pkt.setCommand(0x20);
            pkt.setSubCommand(0x80);
            pkt.setU32(0x14, processControl_getSelectedProcessId());
            sendPacket(pkt);
        }

        private void processControl_resumeBtn_Click(object sender, EventArgs e) {
            Packet pkt = new Packet(0x18);
            pkt.setCommand(0x20);
            pkt.setSubCommand(0x82);
            pkt.setU32(0x14, processControl_getSelectedProcessId());
            sendPacket(pkt);
        }

        private void processReadMemBtn_Click(object sender, EventArgs e) {
            Packet pkt = new Packet(0x20);
            pkt.setCommand(0x10);
            pkt.setSubCommand(0x10);
            pkt.setU32(0x14, processControl_getSelectedProcessId());
            pkt.setU32(0x18, Convert.ToUInt32(processReadMemVATextBox.Text, 16));
            pkt.setU32(0x1C, (uint)processReadMemSizeUpDown.Value);

            sendPacket(pkt);
        }

        #endregion
    }
}
