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
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Button process_refreshPlistBtn;
            System.Windows.Forms.Label label9;
            System.Windows.Forms.Label label10;
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
            this.arbitraryTab_clearCmdBtn = new System.Windows.Forms.Button();
            this.arbitraryTab_sendCmdBtn = new System.Windows.Forms.Button();
            this.arbitraryTab_additionalBytesTextBox = new System.Windows.Forms.TextBox();
            this.arbitraryTab_unk13UpDown = new System.Windows.Forms.NumericUpDown();
            this.arbitraryTab_subCmdIdUpDown = new System.Windows.Forms.NumericUpDown();
            this.arbitraryTab_cmdIdUpDown = new System.Windows.Forms.NumericUpDown();
            this.arbitraryTab_cmdPreviewTextBox = new System.Windows.Forms.TextBox();
            this.kshowCmdListBox = new System.Windows.Forms.ListBox();
            this.kshowSendCmdBtn = new System.Windows.Forms.Button();
            this.processControl_panel = new System.Windows.Forms.Panel();
            this.processReadMemVATextBox = new System.Windows.Forms.TextBox();
            this.processReadMemBtn = new System.Windows.Forms.Button();
            this.processReadMemSizeUpDown = new System.Windows.Forms.NumericUpDown();
            this.processKillBtn = new System.Windows.Forms.Button();
            this.processResumeBtn = new System.Windows.Forms.Button();
            this.processSuspendBtn = new System.Windows.Forms.Button();
            this.process_plistComboBox = new System.Windows.Forms.ComboBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.phyAccessTab = new System.Windows.Forms.TabPage();
            this.phymemReadBtn = new System.Windows.Forms.Button();
            this.phymemRW_target_PA_TextBox = new System.Windows.Forms.TextBox();
            this.phymemRW_written_value_UpDown = new System.Windows.Forms.NumericUpDown();
            this.phymemRW_write_Btn = new System.Windows.Forms.Button();
            this.phymemRW_size_groupBox = new System.Windows.Forms.GroupBox();
            this.phymemRW_size_8bits_radioBtn = new System.Windows.Forms.RadioButton();
            this.phymemRW_size_32bits_radioBtn = new System.Windows.Forms.RadioButton();
            this.phymemRW_size_16bits_radioBtn = new System.Windows.Forms.RadioButton();
            this.customCmdTabPage = new System.Windows.Forms.TabPage();
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
            label8 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            process_refreshPlistBtn = new System.Windows.Forms.Button();
            label9 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            logGroupBox.SuspendLayout();
            mainMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(splitContainer1)).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.arbitraryTab_unk13UpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arbitraryTab_subCmdIdUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arbitraryTab_cmdIdUpDown)).BeginInit();
            kshowTabPage.SuspendLayout();
            processTabPage.SuspendLayout();
            this.processControl_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.processReadMemSizeUpDown)).BeginInit();
            this.tabControl.SuspendLayout();
            this.phyAccessTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phymemRW_written_value_UpDown)).BeginInit();
            this.phymemRW_size_groupBox.SuspendLayout();
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
            label2.Location = new System.Drawing.Point(18, 59);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(86, 13);
            label2.TabIndex = 5;
            label2.Text = "Subcommand ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(36, 30);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(68, 13);
            label1.TabIndex = 4;
            label1.Text = "Command ID";
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
            label5.Location = new System.Drawing.Point(67, 87);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(37, 13);
            label5.TabIndex = 8;
            label5.Text = "unk13";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(27, 114);
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
            splitContainer1.Panel1.Controls.Add(this.arbitraryTab_clearCmdBtn);
            splitContainer1.Panel1.Controls.Add(this.arbitraryTab_sendCmdBtn);
            splitContainer1.Panel1.Controls.Add(label3);
            splitContainer1.Panel1.Controls.Add(this.arbitraryTab_additionalBytesTextBox);
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Controls.Add(this.arbitraryTab_unk13UpDown);
            splitContainer1.Panel1.Controls.Add(label5);
            splitContainer1.Panel1.Controls.Add(this.arbitraryTab_subCmdIdUpDown);
            splitContainer1.Panel1.Controls.Add(this.arbitraryTab_cmdIdUpDown);
            splitContainer1.Panel1.Controls.Add(label2);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(label4);
            splitContainer1.Panel2.Controls.Add(this.arbitraryTab_cmdPreviewTextBox);
            splitContainer1.Size = new System.Drawing.Size(652, 313);
            splitContainer1.SplitterDistance = 326;
            splitContainer1.TabIndex = 11;
            // 
            // arbitraryTab_clearCmdBtn
            // 
            this.arbitraryTab_clearCmdBtn.Location = new System.Drawing.Point(24, 258);
            this.arbitraryTab_clearCmdBtn.Name = "arbitraryTab_clearCmdBtn";
            this.arbitraryTab_clearCmdBtn.Size = new System.Drawing.Size(289, 22);
            this.arbitraryTab_clearCmdBtn.TabIndex = 11;
            this.arbitraryTab_clearCmdBtn.Text = "Clear";
            this.arbitraryTab_clearCmdBtn.UseVisualStyleBackColor = true;
            this.arbitraryTab_clearCmdBtn.Click += new System.EventHandler(this.arbitraryTab_clearCmdBtn_Click);
            // 
            // arbitraryTab_sendCmdBtn
            // 
            this.arbitraryTab_sendCmdBtn.Location = new System.Drawing.Point(24, 286);
            this.arbitraryTab_sendCmdBtn.Name = "arbitraryTab_sendCmdBtn";
            this.arbitraryTab_sendCmdBtn.Size = new System.Drawing.Size(289, 24);
            this.arbitraryTab_sendCmdBtn.TabIndex = 4;
            this.arbitraryTab_sendCmdBtn.Text = "Send command";
            this.arbitraryTab_sendCmdBtn.UseVisualStyleBackColor = true;
            this.arbitraryTab_sendCmdBtn.Click += new System.EventHandler(this.arbitraryTab_sendCmdBtn_Click);
            // 
            // arbitraryTab_additionalBytesTextBox
            // 
            this.arbitraryTab_additionalBytesTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.arbitraryTab_additionalBytesTextBox.Location = new System.Drawing.Point(110, 111);
            this.arbitraryTab_additionalBytesTextBox.MaxLength = 512;
            this.arbitraryTab_additionalBytesTextBox.Multiline = true;
            this.arbitraryTab_additionalBytesTextBox.Name = "arbitraryTab_additionalBytesTextBox";
            this.arbitraryTab_additionalBytesTextBox.Size = new System.Drawing.Size(117, 141);
            this.arbitraryTab_additionalBytesTextBox.TabIndex = 9;
            this.arbitraryTab_additionalBytesTextBox.TextChanged += new System.EventHandler(this.arbitraryTab_additionalBytesTextBox_TextChanged);
            this.arbitraryTab_additionalBytesTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.arbitraryTab_additionalBytesTextBox_KeyDown);
            this.arbitraryTab_additionalBytesTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.arbitraryTab_additionalBytesTextBox_KeyPress);
            this.arbitraryTab_additionalBytesTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.arbitraryTab_additionalBytesTextBox_KeyUp);
            // 
            // arbitraryTab_unk13UpDown
            // 
            this.arbitraryTab_unk13UpDown.Hexadecimal = true;
            this.arbitraryTab_unk13UpDown.Location = new System.Drawing.Point(110, 85);
            this.arbitraryTab_unk13UpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.arbitraryTab_unk13UpDown.Name = "arbitraryTab_unk13UpDown";
            this.arbitraryTab_unk13UpDown.Size = new System.Drawing.Size(117, 20);
            this.arbitraryTab_unk13UpDown.TabIndex = 2;
            this.arbitraryTab_unk13UpDown.ValueChanged += new System.EventHandler(this.arbitraryTab_UpDown_ValueChanged);
            // 
            // arbitraryTab_subCmdIdUpDown
            // 
            this.arbitraryTab_subCmdIdUpDown.Hexadecimal = true;
            this.arbitraryTab_subCmdIdUpDown.Location = new System.Drawing.Point(110, 57);
            this.arbitraryTab_subCmdIdUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.arbitraryTab_subCmdIdUpDown.Name = "arbitraryTab_subCmdIdUpDown";
            this.arbitraryTab_subCmdIdUpDown.Size = new System.Drawing.Size(117, 20);
            this.arbitraryTab_subCmdIdUpDown.TabIndex = 1;
            this.arbitraryTab_subCmdIdUpDown.ValueChanged += new System.EventHandler(this.arbitraryTab_UpDown_ValueChanged);
            // 
            // arbitraryTab_cmdIdUpDown
            // 
            this.arbitraryTab_cmdIdUpDown.Hexadecimal = true;
            this.arbitraryTab_cmdIdUpDown.Location = new System.Drawing.Point(110, 28);
            this.arbitraryTab_cmdIdUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.arbitraryTab_cmdIdUpDown.Name = "arbitraryTab_cmdIdUpDown";
            this.arbitraryTab_cmdIdUpDown.Size = new System.Drawing.Size(117, 20);
            this.arbitraryTab_cmdIdUpDown.TabIndex = 0;
            this.arbitraryTab_cmdIdUpDown.ValueChanged += new System.EventHandler(this.arbitraryTab_UpDown_ValueChanged);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(115, 16);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(94, 13);
            label4.TabIndex = 11;
            label4.Text = "Command preview";
            // 
            // arbitraryTab_cmdPreviewTextBox
            // 
            this.arbitraryTab_cmdPreviewTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.arbitraryTab_cmdPreviewTextBox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arbitraryTab_cmdPreviewTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.arbitraryTab_cmdPreviewTextBox.Location = new System.Drawing.Point(15, 47);
            this.arbitraryTab_cmdPreviewTextBox.MaxLength = 256;
            this.arbitraryTab_cmdPreviewTextBox.Multiline = true;
            this.arbitraryTab_cmdPreviewTextBox.Name = "arbitraryTab_cmdPreviewTextBox";
            this.arbitraryTab_cmdPreviewTextBox.ReadOnly = true;
            this.arbitraryTab_cmdPreviewTextBox.Size = new System.Drawing.Size(294, 253);
            this.arbitraryTab_cmdPreviewTextBox.TabIndex = 0;
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
            "0x2110: start leak chcek for GUID Entry Heap",
            "0x2122: start leak chcek for kernel fixed heap 32B",
            "0x2123: start leak chcek for kernel fixed heap 64B",
            "0x2124: start leak chcek for kernel fixed heap 128B",
            "0x2125: start leak chcek for kernel fixed heap 256B",
            "0x2126: start leak chcek for kernel fixed heap 512B",
            "0x2151: start leak chcek for MemBlock Master Count",
            "0x2170: start leak chcek for PhyMemPart",
            "0x2180: start leak chcek for PhyMemLow",
            "0x21B4: start leak chcek for Process FixedHeap128B",
            "0x2210: stop leak chcek for GUID Entry Heap",
            "0x2222: stop leak chcek for kernel fixed heap 32B",
            "0x2223: stop leak chcek for kernel fixed heap 64B",
            "0x2224: stop leak chcek for kernel fixed heap 128B",
            "0x2225: stop leak chcek for kernel fixed heap 256B",
            "0x2226: stop leak chcek for kernel fixed heap 512B",
            "0x2251: stop leak chcek for MemBlock Master Count",
            "0x2270: stop leak chcek for PhyMemPart",
            "0x2280: stop leak chcek for PhyMemLow",
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
            "0x3170: log start for  PhyMemPart",
            "0x31A0: log start for  NameHeap",
            "0x3270: log stop for  PhyMemPart",
            "0x32A0: log stop for  NameHeap",
            "0x3370: show log for  PhyMemPart",
            "0x33A0: show log for  NameHeap",
            "0x34A0: save log for  NameHeap",
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
            this.kshowSendCmdBtn.Location = new System.Drawing.Point(6, 282);
            this.kshowSendCmdBtn.Name = "kshowSendCmdBtn";
            this.kshowSendCmdBtn.Size = new System.Drawing.Size(640, 25);
            this.kshowSendCmdBtn.TabIndex = 0;
            this.kshowSendCmdBtn.Text = "Send command";
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
            // 
            // processReadMemVATextBox
            // 
            this.processReadMemVATextBox.Location = new System.Drawing.Point(520, 16);
            this.processReadMemVATextBox.Name = "processReadMemVATextBox";
            this.processReadMemVATextBox.Size = new System.Drawing.Size(120, 20);
            this.processReadMemVATextBox.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(484, 45);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(30, 13);
            label8.TabIndex = 9;
            label8.Text = "Size:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(490, 19);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(24, 13);
            label7.TabIndex = 7;
            label7.Text = "VA:";
            // 
            // processReadMemBtn
            // 
            this.processReadMemBtn.Location = new System.Drawing.Point(520, 69);
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
            this.processReadMemSizeUpDown.Location = new System.Drawing.Point(520, 43);
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
            this.processKillBtn.Location = new System.Drawing.Point(18, 17);
            this.processKillBtn.Name = "processKillBtn";
            this.processKillBtn.Size = new System.Drawing.Size(75, 23);
            this.processKillBtn.TabIndex = 3;
            this.processKillBtn.Text = "Kill";
            this.processKillBtn.UseVisualStyleBackColor = true;
            this.processKillBtn.Click += new System.EventHandler(this.processControl_killBtn_Click);
            // 
            // processResumeBtn
            // 
            this.processResumeBtn.Location = new System.Drawing.Point(18, 74);
            this.processResumeBtn.Name = "processResumeBtn";
            this.processResumeBtn.Size = new System.Drawing.Size(75, 23);
            this.processResumeBtn.TabIndex = 5;
            this.processResumeBtn.Text = "Resume";
            this.processResumeBtn.UseVisualStyleBackColor = true;
            this.processResumeBtn.Click += new System.EventHandler(this.processControl_resumeBtn_Click);
            // 
            // processSuspendBtn
            // 
            this.processSuspendBtn.Location = new System.Drawing.Point(18, 45);
            this.processSuspendBtn.Name = "processSuspendBtn";
            this.processSuspendBtn.Size = new System.Drawing.Size(75, 23);
            this.processSuspendBtn.TabIndex = 4;
            this.processSuspendBtn.Text = "Suspend";
            this.processSuspendBtn.UseVisualStyleBackColor = true;
            this.processSuspendBtn.Click += new System.EventHandler(this.processControl_suspendBtn_Click);
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(15, 16);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(48, 13);
            label6.TabIndex = 2;
            label6.Text = "Process:";
            // 
            // process_refreshPlistBtn
            // 
            process_refreshPlistBtn.Location = new System.Drawing.Point(565, 13);
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
            this.process_plistComboBox.Location = new System.Drawing.Point(69, 13);
            this.process_plistComboBox.Name = "process_plistComboBox";
            this.process_plistComboBox.Size = new System.Drawing.Size(490, 21);
            this.process_plistComboBox.TabIndex = 0;
            this.process_plistComboBox.SelectedIndexChanged += new System.EventHandler(this.processControl_plistComboBox_SelectedIndexChanged);
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(199, 33);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(24, 13);
            label9.TabIndex = 7;
            label9.Text = "PA:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(140, 58);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(83, 13);
            label10.TabIndex = 8;
            label10.Text = "Value (for write):";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(processTabPage);
            this.tabControl.Controls.Add(kshowTabPage);
            this.tabControl.Controls.Add(this.phyAccessTab);
            this.tabControl.Controls.Add(this.customCmdTabPage);
            this.tabControl.Location = new System.Drawing.Point(12, 27);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(660, 339);
            this.tabControl.TabIndex = 4;
            // 
            // phyAccessTab
            // 
            this.phyAccessTab.Controls.Add(this.phymemReadBtn);
            this.phyAccessTab.Controls.Add(label10);
            this.phyAccessTab.Controls.Add(label9);
            this.phyAccessTab.Controls.Add(this.phymemRW_target_PA_TextBox);
            this.phyAccessTab.Controls.Add(this.phymemRW_written_value_UpDown);
            this.phyAccessTab.Controls.Add(this.phymemRW_write_Btn);
            this.phyAccessTab.Controls.Add(this.phymemRW_size_groupBox);
            this.phyAccessTab.Location = new System.Drawing.Point(4, 22);
            this.phyAccessTab.Name = "phyAccessTab";
            this.phyAccessTab.Padding = new System.Windows.Forms.Padding(3);
            this.phyAccessTab.Size = new System.Drawing.Size(652, 313);
            this.phyAccessTab.TabIndex = 1;
            this.phyAccessTab.Text = "Phymem R/W";
            this.phyAccessTab.UseVisualStyleBackColor = true;
            // 
            // phymemReadBtn
            // 
            this.phymemReadBtn.Location = new System.Drawing.Point(244, 82);
            this.phymemReadBtn.Name = "phymemReadBtn";
            this.phymemReadBtn.Size = new System.Drawing.Size(75, 23);
            this.phymemReadBtn.TabIndex = 9;
            this.phymemReadBtn.Text = "Read";
            this.phymemReadBtn.UseVisualStyleBackColor = true;
            this.phymemReadBtn.Click += new System.EventHandler(this.phymemReadBtn_Click);
            // 
            // phymemRW_target_PA_TextBox
            // 
            this.phymemRW_target_PA_TextBox.Location = new System.Drawing.Point(229, 30);
            this.phymemRW_target_PA_TextBox.Name = "phymemRW_target_PA_TextBox";
            this.phymemRW_target_PA_TextBox.Size = new System.Drawing.Size(120, 20);
            this.phymemRW_target_PA_TextBox.TabIndex = 6;
            // 
            // phymemRW_written_value_UpDown
            // 
            this.phymemRW_written_value_UpDown.Hexadecimal = true;
            this.phymemRW_written_value_UpDown.Location = new System.Drawing.Point(229, 56);
            this.phymemRW_written_value_UpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.phymemRW_written_value_UpDown.Name = "phymemRW_written_value_UpDown";
            this.phymemRW_written_value_UpDown.Size = new System.Drawing.Size(120, 20);
            this.phymemRW_written_value_UpDown.TabIndex = 5;
            // 
            // phymemRW_write_Btn
            // 
            this.phymemRW_write_Btn.Location = new System.Drawing.Point(244, 112);
            this.phymemRW_write_Btn.Name = "phymemRW_write_Btn";
            this.phymemRW_write_Btn.Size = new System.Drawing.Size(75, 23);
            this.phymemRW_write_Btn.TabIndex = 4;
            this.phymemRW_write_Btn.Text = "Write";
            this.phymemRW_write_Btn.UseVisualStyleBackColor = true;
            this.phymemRW_write_Btn.Click += new System.EventHandler(this.phymemRW_write_Btn_Click);
            // 
            // phymemRW_size_groupBox
            // 
            this.phymemRW_size_groupBox.Controls.Add(this.phymemRW_size_8bits_radioBtn);
            this.phymemRW_size_groupBox.Controls.Add(this.phymemRW_size_32bits_radioBtn);
            this.phymemRW_size_groupBox.Controls.Add(this.phymemRW_size_16bits_radioBtn);
            this.phymemRW_size_groupBox.Location = new System.Drawing.Point(367, 30);
            this.phymemRW_size_groupBox.Name = "phymemRW_size_groupBox";
            this.phymemRW_size_groupBox.Size = new System.Drawing.Size(150, 94);
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
            this.phymemRW_size_8bits_radioBtn.TabIndex = 0;
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
            this.phymemRW_size_32bits_radioBtn.TabIndex = 2;
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
            this.phymemRW_size_16bits_radioBtn.TabIndex = 1;
            this.phymemRW_size_16bits_radioBtn.Text = "16 bits";
            this.phymemRW_size_16bits_radioBtn.UseVisualStyleBackColor = true;
            this.phymemRW_size_16bits_radioBtn.Click += new System.EventHandler(this.phymemRW_size_radioBtn_Clicked);
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
            ((System.ComponentModel.ISupportInitialize)(this.arbitraryTab_unk13UpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arbitraryTab_subCmdIdUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arbitraryTab_cmdIdUpDown)).EndInit();
            kshowTabPage.ResumeLayout(false);
            processTabPage.ResumeLayout(false);
            processTabPage.PerformLayout();
            this.processControl_panel.ResumeLayout(false);
            this.processControl_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.processReadMemSizeUpDown)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.phyAccessTab.ResumeLayout(false);
            this.phyAccessTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phymemRW_written_value_UpDown)).EndInit();
            this.phymemRW_size_groupBox.ResumeLayout(false);
            this.phymemRW_size_groupBox.PerformLayout();
            this.customCmdTabPage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button kshowSendCmdBtn;
        private System.Windows.Forms.TabPage phyAccessTab;
        private System.Windows.Forms.ListBox kshowCmdListBox;
        private System.Windows.Forms.TabPage customCmdTabPage;
        private System.Windows.Forms.NumericUpDown arbitraryTab_subCmdIdUpDown;
        private System.Windows.Forms.NumericUpDown arbitraryTab_cmdIdUpDown;
        private System.Windows.Forms.Button arbitraryTab_sendCmdBtn;
        private System.Windows.Forms.NumericUpDown arbitraryTab_unk13UpDown;
        private System.Windows.Forms.TextBox logTextBox;
        private System.Windows.Forms.ToolStripMenuItem targetPicker_menu;
        private System.Windows.Forms.ToolStripMenuItem logToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearLogToolStripMenuItem;
        private System.Windows.Forms.GroupBox phymemRW_size_groupBox;
        private System.Windows.Forms.RadioButton phymemRW_size_8bits_radioBtn;
        private System.Windows.Forms.RadioButton phymemRW_size_32bits_radioBtn;
        private System.Windows.Forms.RadioButton phymemRW_size_16bits_radioBtn;
        private System.Windows.Forms.NumericUpDown phymemRW_written_value_UpDown;
        private System.Windows.Forms.Button phymemRW_write_Btn;
        private System.Windows.Forms.TextBox phymemRW_target_PA_TextBox;
        private System.Windows.Forms.ToolStripMenuItem targetPicker_statusLabel;
        private System.Windows.Forms.ToolStripMenuItem targetPicker_refreshListBtn;
        private System.Windows.Forms.ToolStripMenuItem targetPicker_noTargetAvailableLabel;
        private System.Windows.Forms.ToolStripMenuItem targetPicker_linkToSelectedBtn;
        private System.Windows.Forms.TextBox arbitraryTab_additionalBytesTextBox;
        private System.Windows.Forms.Button arbitraryTab_clearCmdBtn;
        private System.Windows.Forms.TextBox arbitraryTab_cmdPreviewTextBox;
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
    }
}

