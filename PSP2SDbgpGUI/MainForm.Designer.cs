namespace PSP2SDbgpGUI {
    partial class MainForm {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
            System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.GroupBox logGroupBox;
            System.Windows.Forms.MenuStrip mainMenuStrip;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.SplitContainer splitContainer1;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.TabPage kshowTabPage;
            System.Windows.Forms.TabPage processTabPage;
            System.Windows.Forms.GroupBox threadGroupBox;
            System.Windows.Forms.Button process_refreshThreadListBtn;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Button process_refreshPlistBtn;
            System.Windows.Forms.TabPage targetInfoTabPage;
            System.Windows.Forms.GroupBox groupBox1;
            System.Windows.Forms.GroupBox groupBox2;
            System.Windows.Forms.Label label10;
            System.Windows.Forms.Label label9;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.logTextBox = new System.Windows.Forms.TextBox();
            this.targetPicker_menu = new System.Windows.Forms.ToolStripMenuItem();
            this.targetPicker_statusLabel = new System.Windows.Forms.ToolStripMenuItem();
            this.targetPicker_linkToSelectedBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.targetPicker_refreshListBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.targetPicker_noTargetAvailableLabel = new System.Windows.Forms.ToolStripMenuItem();
            this.logToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customCommandTypeUpDown = new System.Windows.Forms.NumericUpDown();
            this.customCommandGroupComboBox = new System.Windows.Forms.ComboBox();
            this.customCommandSendBtn = new System.Windows.Forms.Button();
            this.customCommandAdditionalBytesTextBox = new System.Windows.Forms.TextBox();
            this.customCommandUnk13UpDown = new System.Windows.Forms.NumericUpDown();
            this.customCommandPreviewTextBox = new System.Windows.Forms.TextBox();
            this.kshowCmdListBox = new System.Windows.Forms.ListBox();
            this.kshowSendCmdBtn = new System.Windows.Forms.Button();
            this.processControl_panel = new System.Windows.Forms.Panel();
            this.processControl_threadListComboBox = new System.Windows.Forms.ComboBox();
            this.processReadMemVATextBox = new System.Windows.Forms.TextBox();
            this.processReadMemBtn = new System.Windows.Forms.Button();
            this.processReadMemSizeUpDown = new System.Windows.Forms.NumericUpDown();
            this.processKillBtn = new System.Windows.Forms.Button();
            this.processResumeBtn = new System.Windows.Forms.Button();
            this.processSuspendBtn = new System.Windows.Forms.Button();
            this.process_plistComboBox = new System.Windows.Forms.ComboBox();
            this.targetInformationTreeView = new System.Windows.Forms.TreeView();
            this.phymemRW_readSizeUpDown = new System.Windows.Forms.NumericUpDown();
            this.phymemRW_size_groupBox = new System.Windows.Forms.GroupBox();
            this.phymemRW_size_8bits_radioBtn = new System.Windows.Forms.RadioButton();
            this.phymemRW_size_32bits_radioBtn = new System.Windows.Forms.RadioButton();
            this.phymemRW_size_16bits_radioBtn = new System.Windows.Forms.RadioButton();
            this.phymemRW_write_Btn = new System.Windows.Forms.Button();
            this.phymemReadBtn = new System.Windows.Forms.Button();
            this.phymemRW_target_PA_TextBox = new System.Windows.Forms.TextBox();
            this.kernelMemAccessSize = new System.Windows.Forms.NumericUpDown();
            this.kernelMemReadBtn = new System.Windows.Forms.Button();
            this.kernelMemAccessVA = new System.Windows.Forms.TextBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.miscTab = new System.Windows.Forms.TabPage();
            this.customCmdTabPage = new System.Windows.Forms.TabPage();
            this.formToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.phymemRW_writeDataTextBox = new System.Windows.Forms.TextBox();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            logGroupBox = new System.Windows.Forms.GroupBox();
            mainMenuStrip = new System.Windows.Forms.MenuStrip();
            label5 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            splitContainer1 = new System.Windows.Forms.SplitContainer();
            label4 = new System.Windows.Forms.Label();
            kshowTabPage = new System.Windows.Forms.TabPage();
            processTabPage = new System.Windows.Forms.TabPage();
            threadGroupBox = new System.Windows.Forms.GroupBox();
            process_refreshThreadListBtn = new System.Windows.Forms.Button();
            label8 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            process_refreshPlistBtn = new System.Windows.Forms.Button();
            targetInfoTabPage = new System.Windows.Forms.TabPage();
            groupBox1 = new System.Windows.Forms.GroupBox();
            groupBox2 = new System.Windows.Forms.GroupBox();
            label10 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            logGroupBox.SuspendLayout();
            mainMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(splitContainer1)).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customCommandTypeUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customCommandUnk13UpDown)).BeginInit();
            kshowTabPage.SuspendLayout();
            processTabPage.SuspendLayout();
            this.processControl_panel.SuspendLayout();
            threadGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.processReadMemSizeUpDown)).BeginInit();
            targetInfoTabPage.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phymemRW_readSizeUpDown)).BeginInit();
            this.phymemRW_size_groupBox.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kernelMemAccessSize)).BeginInit();
            this.tabControl.SuspendLayout();
            this.miscTab.SuspendLayout();
            this.customCmdTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(187, 6);
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new System.Drawing.Size(187, 6);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(49, 47);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(31, 13);
            label2.TabIndex = 5;
            label2.Text = "Type";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(44, 14);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(36, 13);
            label1.TabIndex = 4;
            label1.Text = "Group";
            // 
            // logGroupBox
            // 
            logGroupBox.Controls.Add(this.logTextBox);
            logGroupBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            logGroupBox.Location = new System.Drawing.Point(0, 376);
            logGroupBox.Name = "logGroupBox";
            logGroupBox.Size = new System.Drawing.Size(684, 210);
            logGroupBox.TabIndex = 6;
            logGroupBox.TabStop = false;
            logGroupBox.Text = "Log";
            // 
            // logTextBox
            // 
            this.logTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logTextBox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logTextBox.Location = new System.Drawing.Point(3, 16);
            this.logTextBox.MaxLength = 100000;
            this.logTextBox.Multiline = true;
            this.logTextBox.Name = "logTextBox";
            this.logTextBox.ReadOnly = true;
            this.logTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.logTextBox.Size = new System.Drawing.Size(678, 191);
            this.logTextBox.TabIndex = 6;
            this.logTextBox.TabStop = false;
            // 
            // mainMenuStrip
            // 
            mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.targetPicker_menu,
            this.logToolStripMenuItem});
            mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            mainMenuStrip.Name = "mainMenuStrip";
            mainMenuStrip.Size = new System.Drawing.Size(684, 24);
            mainMenuStrip.TabIndex = 7;
            mainMenuStrip.Text = "topMenuStrip";
            // 
            // targetPicker_menu
            // 
            this.targetPicker_menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.targetPicker_statusLabel,
            this.targetPicker_linkToSelectedBtn,
            toolStripSeparator1,
            this.targetPicker_refreshListBtn,
            toolStripSeparator2,
            this.targetPicker_noTargetAvailableLabel});
            this.targetPicker_menu.Name = "targetPicker_menu";
            this.targetPicker_menu.Size = new System.Drawing.Size(51, 20);
            this.targetPicker_menu.Text = "Target";
            // 
            // targetPicker_statusLabel
            // 
            this.targetPicker_statusLabel.Enabled = false;
            this.targetPicker_statusLabel.Name = "targetPicker_statusLabel";
            this.targetPicker_statusLabel.Size = new System.Drawing.Size(190, 22);
            this.targetPicker_statusLabel.Text = "Status:";
            // 
            // targetPicker_linkToSelectedBtn
            // 
            this.targetPicker_linkToSelectedBtn.Name = "targetPicker_linkToSelectedBtn";
            this.targetPicker_linkToSelectedBtn.Size = new System.Drawing.Size(190, 22);
            this.targetPicker_linkToSelectedBtn.Text = "Link to selected target";
            this.targetPicker_linkToSelectedBtn.Click += new System.EventHandler(this.targetPicker_linkToSelectedBtn_Click);
            // 
            // targetPicker_refreshListBtn
            // 
            this.targetPicker_refreshListBtn.Name = "targetPicker_refreshListBtn";
            this.targetPicker_refreshListBtn.Size = new System.Drawing.Size(190, 22);
            this.targetPicker_refreshListBtn.Text = "Refresh target list";
            this.targetPicker_refreshListBtn.ToolTipText = "Refresh the list of available targets";
            this.targetPicker_refreshListBtn.Click += new System.EventHandler(this.targetPicker_refreshListBtn_Click);
            // 
            // targetPicker_noTargetAvailableLabel
            // 
            this.targetPicker_noTargetAvailableLabel.Enabled = false;
            this.targetPicker_noTargetAvailableLabel.Name = "targetPicker_noTargetAvailableLabel";
            this.targetPicker_noTargetAvailableLabel.Size = new System.Drawing.Size(190, 22);
            this.targetPicker_noTargetAvailableLabel.Text = "No target available.";
            // 
            // logToolStripMenuItem
            // 
            this.logToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearLogToolStripMenuItem,
            this.saveToFileToolStripMenuItem});
            this.logToolStripMenuItem.Name = "logToolStripMenuItem";
            this.logToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.logToolStripMenuItem.Text = "Log";
            // 
            // clearLogToolStripMenuItem
            // 
            this.clearLogToolStripMenuItem.Name = "clearLogToolStripMenuItem";
            this.clearLogToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.clearLogToolStripMenuItem.Text = "Clear log";
            this.clearLogToolStripMenuItem.Click += new System.EventHandler(this.clearLogToolStripMenuItem_Click);
            // 
            // saveToFileToolStripMenuItem
            // 
            this.saveToFileToolStripMenuItem.Name = "saveToFileToolStripMenuItem";
            this.saveToFileToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.saveToFileToolStripMenuItem.Text = "Save to file...";
            this.saveToFileToolStripMenuItem.Click += new System.EventHandler(this.saveToFileToolStripMenuItem_Click);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(43, 80);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(37, 13);
            label5.TabIndex = 8;
            label5.Text = "unk13";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(3, 172);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(77, 26);
            label3.TabIndex = 10;
            label3.Text = "Additional data\r\n(hex bytes)";
            label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer1.Location = new System.Drawing.Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(this.customCommandTypeUpDown);
            splitContainer1.Panel1.Controls.Add(this.customCommandGroupComboBox);
            splitContainer1.Panel1.Controls.Add(this.customCommandSendBtn);
            splitContainer1.Panel1.Controls.Add(label3);
            splitContainer1.Panel1.Controls.Add(this.customCommandAdditionalBytesTextBox);
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Controls.Add(this.customCommandUnk13UpDown);
            splitContainer1.Panel1.Controls.Add(label5);
            splitContainer1.Panel1.Controls.Add(label2);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(label4);
            splitContainer1.Panel2.Controls.Add(this.customCommandPreviewTextBox);
            splitContainer1.Size = new System.Drawing.Size(652, 313);
            splitContainer1.SplitterDistance = 326;
            splitContainer1.TabIndex = 11;
            // 
            // customCommandTypeUpDown
            // 
            this.customCommandTypeUpDown.Hexadecimal = true;
            this.customCommandTypeUpDown.Location = new System.Drawing.Point(86, 45);
            this.customCommandTypeUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.customCommandTypeUpDown.Name = "customCommandTypeUpDown";
            this.customCommandTypeUpDown.Size = new System.Drawing.Size(165, 20);
            this.customCommandTypeUpDown.TabIndex = 13;
            this.customCommandTypeUpDown.ValueChanged += new System.EventHandler(this.customCommand_onChange_handler);
            // 
            // customCommandGroupComboBox
            // 
            this.customCommandGroupComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.customCommandGroupComboBox.Items.AddRange(new object[] {
            "0x10 - System",
            "0x20 - Process",
            "0x30 - Thread",
            "0x40 - Module",
            "0x50 - Unused",
            "0x60 - File",
            "0x70 - Network?",
            "0x90 - System Debug?",
            "0xF0 - Misc"});
            this.customCommandGroupComboBox.Location = new System.Drawing.Point(86, 11);
            this.customCommandGroupComboBox.Name = "customCommandGroupComboBox";
            this.customCommandGroupComboBox.Size = new System.Drawing.Size(165, 21);
            this.customCommandGroupComboBox.TabIndex = 12;
            // 
            // customCommandSendBtn
            // 
            this.customCommandSendBtn.Location = new System.Drawing.Point(6, 267);
            this.customCommandSendBtn.Name = "customCommandSendBtn";
            this.customCommandSendBtn.Size = new System.Drawing.Size(316, 43);
            this.customCommandSendBtn.TabIndex = 4;
            this.customCommandSendBtn.Text = "Send command";
            this.customCommandSendBtn.UseVisualStyleBackColor = true;
            this.customCommandSendBtn.Click += new System.EventHandler(this.arbitraryTab_sendCmdBtn_Click);
            // 
            // customCommandAdditionalBytesTextBox
            // 
            this.customCommandAdditionalBytesTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.customCommandAdditionalBytesTextBox.Location = new System.Drawing.Point(86, 111);
            this.customCommandAdditionalBytesTextBox.MaxLength = 512;
            this.customCommandAdditionalBytesTextBox.Multiline = true;
            this.customCommandAdditionalBytesTextBox.Name = "customCommandAdditionalBytesTextBox";
            this.customCommandAdditionalBytesTextBox.Size = new System.Drawing.Size(165, 150);
            this.customCommandAdditionalBytesTextBox.TabIndex = 9;
            this.customCommandAdditionalBytesTextBox.TextChanged += new System.EventHandler(this.arbitraryTab_additionalBytesTextBox_TextChanged);
            this.customCommandAdditionalBytesTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.arbitraryTab_additionalBytesTextBox_KeyDown);
            this.customCommandAdditionalBytesTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.arbitraryTab_additionalBytesTextBox_KeyPress);
            this.customCommandAdditionalBytesTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.arbitraryTab_additionalBytesTextBox_KeyUp);
            // 
            // customCommandUnk13UpDown
            // 
            this.customCommandUnk13UpDown.Hexadecimal = true;
            this.customCommandUnk13UpDown.Location = new System.Drawing.Point(86, 78);
            this.customCommandUnk13UpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.customCommandUnk13UpDown.Name = "customCommandUnk13UpDown";
            this.customCommandUnk13UpDown.Size = new System.Drawing.Size(165, 20);
            this.customCommandUnk13UpDown.TabIndex = 2;
            this.customCommandUnk13UpDown.ValueChanged += new System.EventHandler(this.customCommand_onChange_handler);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(109, 19);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(94, 13);
            label4.TabIndex = 11;
            label4.Text = "Command preview";
            // 
            // customCommandPreviewTextBox
            // 
            this.customCommandPreviewTextBox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customCommandPreviewTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.customCommandPreviewTextBox.Location = new System.Drawing.Point(15, 47);
            this.customCommandPreviewTextBox.MaxLength = 256;
            this.customCommandPreviewTextBox.Multiline = true;
            this.customCommandPreviewTextBox.Name = "customCommandPreviewTextBox";
            this.customCommandPreviewTextBox.ReadOnly = true;
            this.customCommandPreviewTextBox.Size = new System.Drawing.Size(294, 253);
            this.customCommandPreviewTextBox.TabIndex = 0;
            // 
            // kshowTabPage
            // 
            kshowTabPage.Controls.Add(this.kshowCmdListBox);
            kshowTabPage.Controls.Add(this.kshowSendCmdBtn);
            kshowTabPage.Location = new System.Drawing.Point(4, 22);
            kshowTabPage.Name = "kshowTabPage";
            kshowTabPage.Padding = new System.Windows.Forms.Padding(3);
            kshowTabPage.Size = new System.Drawing.Size(652, 313);
            kshowTabPage.TabIndex = 0;
            kshowTabPage.Text = "kshow";
            kshowTabPage.UseVisualStyleBackColor = true;
            // 
            // kshowCmdListBox
            // 
            this.kshowCmdListBox.FormattingEnabled = true;
            this.kshowCmdListBox.Items.AddRange(new object[] {
            "0x0000: show help messages",
            "0x1010: show status for GUID Entry Heap",
            "0x1022: show status for kernel fixed heap 32B",
            "0x1023: show status for kernel fixed heap 64B",
            "0x1024: show status for kernel fixed heap 128B",
            "0x1025: show status for kernel fixed heap 256B",
            "0x1026: show status for kernel fixed heap 512B",
            "0x1030: show status for Process",
            "0x1040: show status for Object Heap",
            "0x1050: show status for MemBlock",
            "0x1060: show status for SMB",
            "0x1070: show status for PhyMemPart",
            "0x2110: start leak check for GUID Entry Heap",
            "0x2122: start leak check for kernel fixed heap 32B",
            "0x2123: start leak check for kernel fixed heap 64B",
            "0x2124: start leak check for kernel fixed heap 128B",
            "0x2125: start leak check for kernel fixed heap 256B",
            "0x2126: start leak check for kernel fixed heap 512B",
            "0x2151: start leak check for MemBlock Master Count",
            "0x2170: start leak check for PhyMemPart",
            "0x2180: start leak check for PhyMemLow",
            "0x21B4: start leak check for Process FixedHeap128B",
            "0x2210: stop leak check for GUID Entry Heap",
            "0x2222: stop leak check for kernel fixed heap 32B",
            "0x2223: stop leak check for kernel fixed heap 64B",
            "0x2224: stop leak check for kernel fixed heap 128B",
            "0x2225: stop leak check for kernel fixed heap 256B",
            "0x2226: stop leak check for kernel fixed heap 512B",
            "0x2251: stop leak check for MemBlock Master Count",
            "0x2270: stop leak check for PhyMemPart",
            "0x2280: stop leak check for PhyMemLow",
            "0x2310: check leak for GUID Entry Heap",
            "0x2322: check leak for kernel fixed heap 32B",
            "0x2323: check leak for kernel fixed heap 64B",
            "0x2324: check leak for kernel fixed heap 128B",
            "0x2325: check leak for kernel fixed heap 256B",
            "0x2326: check leak for kernel fixed heap 512B",
            "0x2351: check leak for MemBlock Master Count",
            "0x2370: check leak for PhyMemPart",
            "0x2380: check leak for PhyMemLow",
            "0x23B4: check leak for Process FixedHeap128B",
            "0x2891: check leak filter for SceKernelThreadMgrCBHeap",
            "0x3170: log start for PhyMemPart",
            "0x31A0: log start for NameHeap",
            "0x3270: log stop for PhyMemPart",
            "0x32A0: log stop for NameHeap",
            "0x3370: show log for PhyMemPart",
            "0x33A0: show log for NameHeap",
            "0x34A0: save log for NameHeap",
            "0x8000: show A-B time",
            "0x9100: show CPU mask time",
            "0x9200: disable CPU mask hook",
            "0x9300: reset CPU mask log"});
            this.kshowCmdListBox.Location = new System.Drawing.Point(3, 3);
            this.kshowCmdListBox.Name = "kshowCmdListBox";
            this.kshowCmdListBox.Size = new System.Drawing.Size(643, 277);
            this.kshowCmdListBox.TabIndex = 1;
            this.kshowCmdListBox.SelectedIndexChanged += new System.EventHandler(this.kshowCmdListBox_SelectedIndexChanged);
            // 
            // kshowSendCmdBtn
            // 
            this.kshowSendCmdBtn.Enabled = false;
            this.kshowSendCmdBtn.Location = new System.Drawing.Point(3, 282);
            this.kshowSendCmdBtn.Name = "kshowSendCmdBtn";
            this.kshowSendCmdBtn.Size = new System.Drawing.Size(643, 25);
            this.kshowSendCmdBtn.TabIndex = 0;
            this.kshowSendCmdBtn.Text = "Send command";
            this.formToolTip.SetToolTip(this.kshowSendCmdBtn, "Check the Neighborhood Console Output application for kshow results.");
            this.kshowSendCmdBtn.UseVisualStyleBackColor = true;
            this.kshowSendCmdBtn.Click += new System.EventHandler(this.kshowSendCmd);
            // 
            // processTabPage
            // 
            processTabPage.Controls.Add(this.processControl_panel);
            processTabPage.Controls.Add(label6);
            processTabPage.Controls.Add(process_refreshPlistBtn);
            processTabPage.Controls.Add(this.process_plistComboBox);
            processTabPage.Location = new System.Drawing.Point(4, 22);
            processTabPage.Name = "processTabPage";
            processTabPage.Size = new System.Drawing.Size(652, 313);
            processTabPage.TabIndex = 3;
            processTabPage.Text = "Processes";
            processTabPage.UseVisualStyleBackColor = true;
            // 
            // processControl_panel
            // 
            this.processControl_panel.Controls.Add(threadGroupBox);
            this.processControl_panel.Controls.Add(this.processReadMemVATextBox);
            this.processControl_panel.Controls.Add(label8);
            this.processControl_panel.Controls.Add(label7);
            this.processControl_panel.Controls.Add(this.processReadMemBtn);
            this.processControl_panel.Controls.Add(this.processReadMemSizeUpDown);
            this.processControl_panel.Controls.Add(this.processKillBtn);
            this.processControl_panel.Controls.Add(this.processResumeBtn);
            this.processControl_panel.Controls.Add(this.processSuspendBtn);
            this.processControl_panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.processControl_panel.Enabled = false;
            this.processControl_panel.Location = new System.Drawing.Point(0, 40);
            this.processControl_panel.Name = "processControl_panel";
            this.processControl_panel.Size = new System.Drawing.Size(652, 273);
            this.processControl_panel.TabIndex = 6;
            this.processControl_panel.EnabledChanged += new System.EventHandler(this.processControl_panel_EnabledChanged);
            // 
            // threadGroupBox
            // 
            threadGroupBox.Controls.Add(process_refreshThreadListBtn);
            threadGroupBox.Controls.Add(this.processControl_threadListComboBox);
            threadGroupBox.Location = new System.Drawing.Point(18, 12);
            threadGroupBox.Name = "threadGroupBox";
            threadGroupBox.Size = new System.Drawing.Size(322, 243);
            threadGroupBox.TabIndex = 11;
            threadGroupBox.TabStop = false;
            threadGroupBox.Text = "Threads";
            // 
            // process_refreshThreadListBtn
            // 
            process_refreshThreadListBtn.Location = new System.Drawing.Point(263, 17);
            process_refreshThreadListBtn.Name = "process_refreshThreadListBtn";
            process_refreshThreadListBtn.Size = new System.Drawing.Size(53, 23);
            process_refreshThreadListBtn.TabIndex = 7;
            process_refreshThreadListBtn.Text = "Refresh";
            process_refreshThreadListBtn.UseVisualStyleBackColor = true;
            process_refreshThreadListBtn.Click += new System.EventHandler(this.process_refreshThreadListBtn_Click);
            // 
            // processControl_threadListComboBox
            // 
            this.processControl_threadListComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.processControl_threadListComboBox.FormattingEnabled = true;
            this.processControl_threadListComboBox.Location = new System.Drawing.Point(6, 17);
            this.processControl_threadListComboBox.Name = "processControl_threadListComboBox";
            this.processControl_threadListComboBox.Size = new System.Drawing.Size(251, 21);
            this.processControl_threadListComboBox.TabIndex = 7;
            // 
            // processReadMemVATextBox
            // 
            this.processReadMemVATextBox.Location = new System.Drawing.Point(520, 98);
            this.processReadMemVATextBox.Name = "processReadMemVATextBox";
            this.processReadMemVATextBox.Size = new System.Drawing.Size(120, 20);
            this.processReadMemVATextBox.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(484, 126);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(30, 13);
            label8.TabIndex = 9;
            label8.Text = "Size:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(490, 101);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(24, 13);
            label7.TabIndex = 7;
            label7.Text = "VA:";
            // 
            // processReadMemBtn
            // 
            this.processReadMemBtn.Location = new System.Drawing.Point(520, 150);
            this.processReadMemBtn.Name = "processReadMemBtn";
            this.processReadMemBtn.Size = new System.Drawing.Size(120, 23);
            this.processReadMemBtn.TabIndex = 8;
            this.processReadMemBtn.Text = "Read memory";
            this.processReadMemBtn.UseVisualStyleBackColor = true;
            this.processReadMemBtn.Click += new System.EventHandler(this.processReadMemBtn_Click);
            // 
            // processReadMemSizeUpDown
            // 
            this.processReadMemSizeUpDown.Hexadecimal = true;
            this.processReadMemSizeUpDown.Location = new System.Drawing.Point(520, 124);
            this.processReadMemSizeUpDown.Maximum = new decimal(new int[] {
            65536,
            0,
            0,
            0});
            this.processReadMemSizeUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.processReadMemSizeUpDown.Name = "processReadMemSizeUpDown";
            this.processReadMemSizeUpDown.Size = new System.Drawing.Size(120, 20);
            this.processReadMemSizeUpDown.TabIndex = 7;
            this.processReadMemSizeUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // processKillBtn
            // 
            this.processKillBtn.Location = new System.Drawing.Point(346, 29);
            this.processKillBtn.Name = "processKillBtn";
            this.processKillBtn.Size = new System.Drawing.Size(116, 23);
            this.processKillBtn.TabIndex = 3;
            this.processKillBtn.Text = "Kill process";
            this.processKillBtn.UseVisualStyleBackColor = true;
            this.processKillBtn.Click += new System.EventHandler(this.processControl_killBtn_Click);
            // 
            // processResumeBtn
            // 
            this.processResumeBtn.Location = new System.Drawing.Point(346, 87);
            this.processResumeBtn.Name = "processResumeBtn";
            this.processResumeBtn.Size = new System.Drawing.Size(116, 23);
            this.processResumeBtn.TabIndex = 5;
            this.processResumeBtn.Text = "Resume process";
            this.processResumeBtn.UseVisualStyleBackColor = true;
            this.processResumeBtn.Click += new System.EventHandler(this.processControl_resumeBtn_Click);
            // 
            // processSuspendBtn
            // 
            this.processSuspendBtn.Location = new System.Drawing.Point(346, 58);
            this.processSuspendBtn.Name = "processSuspendBtn";
            this.processSuspendBtn.Size = new System.Drawing.Size(116, 23);
            this.processSuspendBtn.TabIndex = 4;
            this.processSuspendBtn.Text = "Suspend process";
            this.processSuspendBtn.UseVisualStyleBackColor = true;
            this.processSuspendBtn.Click += new System.EventHandler(this.processControl_suspendBtn_Click);
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(15, 13);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(48, 13);
            label6.TabIndex = 2;
            label6.Text = "Process:";
            // 
            // process_refreshPlistBtn
            // 
            process_refreshPlistBtn.Location = new System.Drawing.Point(565, 8);
            process_refreshPlistBtn.Name = "process_refreshPlistBtn";
            process_refreshPlistBtn.Size = new System.Drawing.Size(75, 23);
            process_refreshPlistBtn.TabIndex = 1;
            process_refreshPlistBtn.Text = "Refresh list";
            process_refreshPlistBtn.UseVisualStyleBackColor = true;
            process_refreshPlistBtn.Click += new System.EventHandler(this.processControl_refreshPlistBtn_Click);
            // 
            // process_plistComboBox
            // 
            this.process_plistComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.process_plistComboBox.FormattingEnabled = true;
            this.process_plistComboBox.Location = new System.Drawing.Point(69, 10);
            this.process_plistComboBox.Name = "process_plistComboBox";
            this.process_plistComboBox.Size = new System.Drawing.Size(490, 21);
            this.process_plistComboBox.TabIndex = 0;
            this.process_plistComboBox.SelectedIndexChanged += new System.EventHandler(this.processControl_plistComboBox_SelectedIndexChanged);
            // 
            // targetInfoTabPage
            // 
            targetInfoTabPage.Controls.Add(this.targetInformationTreeView);
            targetInfoTabPage.Location = new System.Drawing.Point(4, 22);
            targetInfoTabPage.Name = "targetInfoTabPage";
            targetInfoTabPage.Size = new System.Drawing.Size(652, 313);
            targetInfoTabPage.TabIndex = 4;
            targetInfoTabPage.Text = "Target information";
            targetInfoTabPage.UseVisualStyleBackColor = true;
            // 
            // targetInformationTreeView
            // 
            this.targetInformationTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.targetInformationTreeView.Location = new System.Drawing.Point(0, 0);
            this.targetInformationTreeView.Name = "targetInformationTreeView";
            this.targetInformationTreeView.ShowNodeToolTips = true;
            this.targetInformationTreeView.Size = new System.Drawing.Size(652, 313);
            this.targetInformationTreeView.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(this.phymemRW_writeDataTextBox);
            groupBox1.Controls.Add(this.phymemRW_readSizeUpDown);
            groupBox1.Controls.Add(this.phymemRW_size_groupBox);
            groupBox1.Controls.Add(this.phymemRW_write_Btn);
            groupBox1.Controls.Add(this.phymemReadBtn);
            groupBox1.Controls.Add(this.phymemRW_target_PA_TextBox);
            groupBox1.Location = new System.Drawing.Point(6, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(316, 145);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Physical memory access";
            // 
            // phymemRW_readSizeUpDown
            // 
            this.phymemRW_readSizeUpDown.Hexadecimal = true;
            this.phymemRW_readSizeUpDown.Location = new System.Drawing.Point(210, 87);
            this.phymemRW_readSizeUpDown.Maximum = new decimal(new int[] {
            69596,
            0,
            0,
            0});
            this.phymemRW_readSizeUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.phymemRW_readSizeUpDown.Name = "phymemRW_readSizeUpDown";
            this.phymemRW_readSizeUpDown.Size = new System.Drawing.Size(100, 20);
            this.phymemRW_readSizeUpDown.TabIndex = 6;
            this.formToolTip.SetToolTip(this.phymemRW_readSizeUpDown, "Size to read (hex, in bytes, rounded down to access size)");
            this.phymemRW_readSizeUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // phymemRW_size_groupBox
            // 
            this.phymemRW_size_groupBox.Controls.Add(this.phymemRW_size_8bits_radioBtn);
            this.phymemRW_size_groupBox.Controls.Add(this.phymemRW_size_32bits_radioBtn);
            this.phymemRW_size_groupBox.Controls.Add(this.phymemRW_size_16bits_radioBtn);
            this.phymemRW_size_groupBox.Location = new System.Drawing.Point(115, 45);
            this.phymemRW_size_groupBox.Name = "phymemRW_size_groupBox";
            this.phymemRW_size_groupBox.Size = new System.Drawing.Size(89, 91);
            this.phymemRW_size_groupBox.TabIndex = 3;
            this.phymemRW_size_groupBox.TabStop = false;
            this.phymemRW_size_groupBox.Text = "Access size";
            // 
            // phymemRW_size_8bits_radioBtn
            // 
            this.phymemRW_size_8bits_radioBtn.AutoSize = true;
            this.phymemRW_size_8bits_radioBtn.Checked = true;
            this.phymemRW_size_8bits_radioBtn.Location = new System.Drawing.Point(6, 19);
            this.phymemRW_size_8bits_radioBtn.Name = "phymemRW_size_8bits_radioBtn";
            this.phymemRW_size_8bits_radioBtn.Size = new System.Drawing.Size(50, 17);
            this.phymemRW_size_8bits_radioBtn.TabIndex = 3;
            this.phymemRW_size_8bits_radioBtn.TabStop = true;
            this.phymemRW_size_8bits_radioBtn.Text = "8 bits";
            this.phymemRW_size_8bits_radioBtn.UseVisualStyleBackColor = true;
            this.phymemRW_size_8bits_radioBtn.Click += new System.EventHandler(this.phymemRW_size_radioBtn_Clicked);
            // 
            // phymemRW_size_32bits_radioBtn
            // 
            this.phymemRW_size_32bits_radioBtn.AutoSize = true;
            this.phymemRW_size_32bits_radioBtn.Location = new System.Drawing.Point(6, 65);
            this.phymemRW_size_32bits_radioBtn.Name = "phymemRW_size_32bits_radioBtn";
            this.phymemRW_size_32bits_radioBtn.Size = new System.Drawing.Size(56, 17);
            this.phymemRW_size_32bits_radioBtn.TabIndex = 5;
            this.phymemRW_size_32bits_radioBtn.Text = "32 bits";
            this.phymemRW_size_32bits_radioBtn.UseVisualStyleBackColor = true;
            this.phymemRW_size_32bits_radioBtn.Click += new System.EventHandler(this.phymemRW_size_radioBtn_Clicked);
            // 
            // phymemRW_size_16bits_radioBtn
            // 
            this.phymemRW_size_16bits_radioBtn.AutoSize = true;
            this.phymemRW_size_16bits_radioBtn.Location = new System.Drawing.Point(6, 42);
            this.phymemRW_size_16bits_radioBtn.Name = "phymemRW_size_16bits_radioBtn";
            this.phymemRW_size_16bits_radioBtn.Size = new System.Drawing.Size(56, 17);
            this.phymemRW_size_16bits_radioBtn.TabIndex = 4;
            this.phymemRW_size_16bits_radioBtn.Text = "16 bits";
            this.phymemRW_size_16bits_radioBtn.UseVisualStyleBackColor = true;
            this.phymemRW_size_16bits_radioBtn.Click += new System.EventHandler(this.phymemRW_size_radioBtn_Clicked);
            // 
            // phymemRW_write_Btn
            // 
            this.phymemRW_write_Btn.Location = new System.Drawing.Point(6, 113);
            this.phymemRW_write_Btn.Name = "phymemRW_write_Btn";
            this.phymemRW_write_Btn.Size = new System.Drawing.Size(100, 23);
            this.phymemRW_write_Btn.TabIndex = 2;
            this.phymemRW_write_Btn.Text = "Write";
            this.phymemRW_write_Btn.UseVisualStyleBackColor = true;
            this.phymemRW_write_Btn.Click += new System.EventHandler(this.phymemWriteBtn_Click);
            // 
            // phymemReadBtn
            // 
            this.phymemReadBtn.Location = new System.Drawing.Point(210, 113);
            this.phymemReadBtn.Name = "phymemReadBtn";
            this.phymemReadBtn.Size = new System.Drawing.Size(100, 23);
            this.phymemReadBtn.TabIndex = 9;
            this.phymemReadBtn.Text = "Read";
            this.phymemReadBtn.UseVisualStyleBackColor = true;
            this.phymemReadBtn.Click += new System.EventHandler(this.phymemReadBtn_Click);
            // 
            // phymemRW_target_PA_TextBox
            // 
            this.phymemRW_target_PA_TextBox.Location = new System.Drawing.Point(98, 19);
            this.phymemRW_target_PA_TextBox.Name = "phymemRW_target_PA_TextBox";
            this.phymemRW_target_PA_TextBox.Size = new System.Drawing.Size(120, 20);
            this.phymemRW_target_PA_TextBox.TabIndex = 0;
            this.formToolTip.SetToolTip(this.phymemRW_target_PA_TextBox, "Target physical address");
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(this.kernelMemAccessSize);
            groupBox2.Controls.Add(this.kernelMemReadBtn);
            groupBox2.Controls.Add(this.kernelMemAccessVA);
            groupBox2.Location = new System.Drawing.Point(328, 7);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(162, 144);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Kernel memory access";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(58, 67);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(30, 13);
            label10.TabIndex = 12;
            label10.Text = "Size:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(36, 28);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(79, 13);
            label9.TabIndex = 11;
            label9.Text = "Virtual address:";
            // 
            // kernelMemAccessSize
            // 
            this.kernelMemAccessSize.Hexadecimal = true;
            this.kernelMemAccessSize.Location = new System.Drawing.Point(15, 83);
            this.kernelMemAccessSize.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.kernelMemAccessSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.kernelMemAccessSize.Name = "kernelMemAccessSize";
            this.kernelMemAccessSize.Size = new System.Drawing.Size(120, 20);
            this.kernelMemAccessSize.TabIndex = 8;
            this.formToolTip.SetToolTip(this.kernelMemAccessSize, "Size to read (in bytes)");
            this.kernelMemAccessSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // kernelMemReadBtn
            // 
            this.kernelMemReadBtn.Location = new System.Drawing.Point(15, 109);
            this.kernelMemReadBtn.Name = "kernelMemReadBtn";
            this.kernelMemReadBtn.Size = new System.Drawing.Size(120, 23);
            this.kernelMemReadBtn.TabIndex = 9;
            this.kernelMemReadBtn.Text = "Read";
            this.kernelMemReadBtn.UseVisualStyleBackColor = true;
            this.kernelMemReadBtn.Click += new System.EventHandler(this.kernelMemReadBtn_Click);
            // 
            // kernelMemAccessVA
            // 
            this.kernelMemAccessVA.Location = new System.Drawing.Point(15, 44);
            this.kernelMemAccessVA.Name = "kernelMemAccessVA";
            this.kernelMemAccessVA.Size = new System.Drawing.Size(120, 20);
            this.kernelMemAccessVA.TabIndex = 7;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(targetInfoTabPage);
            this.tabControl.Controls.Add(processTabPage);
            this.tabControl.Controls.Add(kshowTabPage);
            this.tabControl.Controls.Add(this.miscTab);
            this.tabControl.Controls.Add(this.customCmdTabPage);
            this.tabControl.Location = new System.Drawing.Point(12, 27);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(660, 339);
            this.tabControl.TabIndex = 4;
            // 
            // miscTab
            // 
            this.miscTab.Controls.Add(groupBox2);
            this.miscTab.Controls.Add(groupBox1);
            this.miscTab.Location = new System.Drawing.Point(4, 22);
            this.miscTab.Name = "miscTab";
            this.miscTab.Padding = new System.Windows.Forms.Padding(3);
            this.miscTab.Size = new System.Drawing.Size(652, 313);
            this.miscTab.TabIndex = 1;
            this.miscTab.Text = "Miscellaneous";
            this.miscTab.UseVisualStyleBackColor = true;
            // 
            // customCmdTabPage
            // 
            this.customCmdTabPage.Controls.Add(splitContainer1);
            this.customCmdTabPage.Location = new System.Drawing.Point(4, 22);
            this.customCmdTabPage.Name = "customCmdTabPage";
            this.customCmdTabPage.Size = new System.Drawing.Size(652, 313);
            this.customCmdTabPage.TabIndex = 2;
            this.customCmdTabPage.Text = "Custom command";
            this.customCmdTabPage.UseVisualStyleBackColor = true;
            // 
            // phymemRW_writeDataTextBox
            // 
            this.phymemRW_writeDataTextBox.Location = new System.Drawing.Point(6, 86);
            this.phymemRW_writeDataTextBox.Name = "phymemRW_writeDataTextBox";
            this.phymemRW_writeDataTextBox.Size = new System.Drawing.Size(100, 20);
            this.phymemRW_writeDataTextBox.TabIndex = 10;
            this.formToolTip.SetToolTip(this.phymemRW_writeDataTextBox, "Data to write (in hex, up to 4 bytes)");
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 586);
            this.Controls.Add(logGroupBox);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(mainMenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = mainMenuStrip;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "SDbgp Tool for PlayStation®Vita";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            logGroupBox.ResumeLayout(false);
            logGroupBox.PerformLayout();
            mainMenuStrip.ResumeLayout(false);
            mainMenuStrip.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(splitContainer1)).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.customCommandTypeUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customCommandUnk13UpDown)).EndInit();
            kshowTabPage.ResumeLayout(false);
            processTabPage.ResumeLayout(false);
            processTabPage.PerformLayout();
            this.processControl_panel.ResumeLayout(false);
            this.processControl_panel.PerformLayout();
            threadGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.processReadMemSizeUpDown)).EndInit();
            targetInfoTabPage.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phymemRW_readSizeUpDown)).EndInit();
            this.phymemRW_size_groupBox.ResumeLayout(false);
            this.phymemRW_size_groupBox.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kernelMemAccessSize)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.miscTab.ResumeLayout(false);
            this.customCmdTabPage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button kshowSendCmdBtn;
        private System.Windows.Forms.TabPage miscTab;
        private System.Windows.Forms.ListBox kshowCmdListBox;
        private System.Windows.Forms.TabPage customCmdTabPage;
        private System.Windows.Forms.Button customCommandSendBtn;
        private System.Windows.Forms.NumericUpDown customCommandUnk13UpDown;
        private System.Windows.Forms.TextBox logTextBox;
        private System.Windows.Forms.ToolStripMenuItem targetPicker_menu;
        private System.Windows.Forms.ToolStripMenuItem logToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearLogToolStripMenuItem;
        private System.Windows.Forms.RadioButton phymemRW_size_8bits_radioBtn;
        private System.Windows.Forms.RadioButton phymemRW_size_32bits_radioBtn;
        private System.Windows.Forms.RadioButton phymemRW_size_16bits_radioBtn;
        private System.Windows.Forms.Button phymemRW_write_Btn;
        private System.Windows.Forms.TextBox phymemRW_target_PA_TextBox;
        private System.Windows.Forms.ToolStripMenuItem targetPicker_statusLabel;
        private System.Windows.Forms.ToolStripMenuItem targetPicker_refreshListBtn;
        private System.Windows.Forms.ToolStripMenuItem targetPicker_noTargetAvailableLabel;
        private System.Windows.Forms.ToolStripMenuItem targetPicker_linkToSelectedBtn;
        private System.Windows.Forms.TextBox customCommandAdditionalBytesTextBox;
        private System.Windows.Forms.TextBox customCommandPreviewTextBox;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.ComboBox process_plistComboBox;
        private System.Windows.Forms.ToolStripMenuItem saveToFileToolStripMenuItem;
        private System.Windows.Forms.Button processResumeBtn;
        private System.Windows.Forms.Button processSuspendBtn;
        private System.Windows.Forms.Button processKillBtn;
        private System.Windows.Forms.Panel processControl_panel;
        private System.Windows.Forms.Button processReadMemBtn;
        private System.Windows.Forms.NumericUpDown processReadMemSizeUpDown;
        private System.Windows.Forms.TextBox processReadMemVATextBox;
        private System.Windows.Forms.Button phymemReadBtn;
        private System.Windows.Forms.ComboBox processControl_threadListComboBox;
        private System.Windows.Forms.TreeView targetInformationTreeView;
        private System.Windows.Forms.ComboBox customCommandGroupComboBox;
        private System.Windows.Forms.NumericUpDown customCommandTypeUpDown;
        private System.Windows.Forms.ToolTip formToolTip;
        private System.Windows.Forms.GroupBox phymemRW_size_groupBox;
        private System.Windows.Forms.NumericUpDown phymemRW_readSizeUpDown;
        private System.Windows.Forms.NumericUpDown kernelMemAccessSize;
        private System.Windows.Forms.Button kernelMemReadBtn;
        private System.Windows.Forms.TextBox kernelMemAccessVA;
        private System.Windows.Forms.TextBox phymemRW_writeDataTextBox;
    }
}

