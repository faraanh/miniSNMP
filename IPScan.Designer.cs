namespace minisnmp
{
    partial class IPScan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IPScan));
            this._ilQuality = new System.Windows.Forms.ImageList(this.components);
            this._lRangeEnd = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this._spnPingsPerScan = new System.Windows.Forms.NumericUpDown();
            this._spnConcurrentPings = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this._ttQuality = new System.Windows.Forms.ToolTip(this.components);
            this._colQuality = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._colIPAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this._spnBufferSize = new System.Windows.Forms.NumericUpDown();
            this._lbLog = new System.Windows.Forms.ListBox();
            this._colAvgResponseTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._spnTTL = new System.Windows.Forms.NumericUpDown();
            this._colHostName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._spnTimeout = new System.Windows.Forms.NumericUpDown();
            this._lRangeSep = new System.Windows.Forms.Label();
            this._tbRangeEnd = new System.Windows.Forms.TextBox();
            this._tbRangeStart = new System.Windows.Forms.TextBox();
            this._cmbRangeType = new System.Windows.Forms.ComboBox();
            this._colLosses = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._splMaster = new System.Windows.Forms.SplitContainer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._btnStartStop = new System.Windows.Forms.Button();
            this._prgScanProgress = new System.Windows.Forms.ProgressBar();
            this._lvAliveHosts = new System.Windows.Forms.ListView();
            this._colMAC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this._spnPingsPerScan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._spnConcurrentPings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._spnBufferSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._spnTTL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._spnTimeout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._splMaster)).BeginInit();
            this._splMaster.Panel1.SuspendLayout();
            this._splMaster.Panel2.SuspendLayout();
            this._splMaster.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _ilQuality
            // 
            this._ilQuality.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("_ilQuality.ImageStream")));
            this._ilQuality.TransparentColor = System.Drawing.Color.Transparent;
            this._ilQuality.Images.SetKeyName(0, "0");
            this._ilQuality.Images.SetKeyName(1, "1");
            this._ilQuality.Images.SetKeyName(2, "2");
            this._ilQuality.Images.SetKeyName(3, "3");
            this._ilQuality.Images.SetKeyName(4, "4");
            this._ilQuality.Images.SetKeyName(5, "5");
            this._ilQuality.Images.SetKeyName(6, "6");
            // 
            // _lRangeEnd
            // 
            this._lRangeEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._lRangeEnd.AutoSize = true;
            this._lRangeEnd.Location = new System.Drawing.Point(94, 60);
            this._lRangeEnd.Name = "_lRangeEnd";
            this._lRangeEnd.Size = new System.Drawing.Size(38, 13);
            this._lRangeEnd.TabIndex = 4;
            this._lRangeEnd.Text = "IP end";
            this._lRangeEnd.Click += new System.EventHandler(this._lRangeEnd_Click);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(93, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "&IP start:";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "T&ype:";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(145, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Ti&mes:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(148, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "&Ping:";
            // 
            // _spnPingsPerScan
            // 
            this._spnPingsPerScan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._spnPingsPerScan.Location = new System.Drawing.Point(185, 149);
            this._spnPingsPerScan.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this._spnPingsPerScan.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this._spnPingsPerScan.Name = "_spnPingsPerScan";
            this._spnPingsPerScan.Size = new System.Drawing.Size(46, 20);
            this._spnPingsPerScan.TabIndex = 16;
            this._spnPingsPerScan.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // _spnConcurrentPings
            // 
            this._spnConcurrentPings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._spnConcurrentPings.Location = new System.Drawing.Point(185, 123);
            this._spnConcurrentPings.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this._spnConcurrentPings.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this._spnConcurrentPings.Name = "_spnConcurrentPings";
            this._spnConcurrentPings.Size = new System.Drawing.Size(46, 20);
            this._spnConcurrentPings.TabIndex = 14;
            this._spnConcurrentPings.Value = new decimal(new int[] {
            64,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "&Buffer Size:";
            // 
            // _colQuality
            // 
            this._colQuality.Text = "Q";
            this._colQuality.Width = 20;
            // 
            // _colIPAddress
            // 
            this._colIPAddress.Text = "IP Address";
            this._colIPAddress.Width = 130;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "TT&L:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "&Timeout:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // _spnBufferSize
            // 
            this._spnBufferSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._spnBufferSize.Location = new System.Drawing.Point(80, 175);
            this._spnBufferSize.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this._spnBufferSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this._spnBufferSize.Name = "_spnBufferSize";
            this._spnBufferSize.Size = new System.Drawing.Size(54, 20);
            this._spnBufferSize.TabIndex = 11;
            this._spnBufferSize.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
            // 
            // _lbLog
            // 
            this._lbLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._lbLog.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this._lbLog.ForeColor = System.Drawing.Color.Lime;
            this._lbLog.FormattingEnabled = true;
            this._lbLog.Location = new System.Drawing.Point(559, 10);
            this._lbLog.Name = "_lbLog";
            this._lbLog.Size = new System.Drawing.Size(283, 147);
            this._lbLog.TabIndex = 3;
            this._lbLog.SelectedIndexChanged += new System.EventHandler(this._lbLog_SelectedIndexChanged);
            // 
            // _colAvgResponseTime
            // 
            this._colAvgResponseTime.Text = "Respone time";
            this._colAvgResponseTime.Width = 102;
            // 
            // _spnTTL
            // 
            this._spnTTL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._spnTTL.Location = new System.Drawing.Point(80, 149);
            this._spnTTL.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this._spnTTL.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this._spnTTL.Name = "_spnTTL";
            this._spnTTL.Size = new System.Drawing.Size(54, 20);
            this._spnTTL.TabIndex = 9;
            this._spnTTL.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
            // 
            // _colHostName
            // 
            this._colHostName.Text = "Host Name";
            this._colHostName.Width = 150;
            // 
            // _spnTimeout
            // 
            this._spnTimeout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._spnTimeout.Location = new System.Drawing.Point(80, 123);
            this._spnTimeout.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this._spnTimeout.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this._spnTimeout.Name = "_spnTimeout";
            this._spnTimeout.Size = new System.Drawing.Size(54, 20);
            this._spnTimeout.TabIndex = 7;
            this._spnTimeout.Value = new decimal(new int[] {
            1500,
            0,
            0,
            0});
            this._spnTimeout.ValueChanged += new System.EventHandler(this._spnTimeout_ValueChanged_1);
            // 
            // _lRangeSep
            // 
            this._lRangeSep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._lRangeSep.AutoSize = true;
            this._lRangeSep.Location = new System.Drawing.Point(77, 79);
            this._lRangeSep.Name = "_lRangeSep";
            this._lRangeSep.Size = new System.Drawing.Size(10, 13);
            this._lRangeSep.TabIndex = 19;
            this._lRangeSep.Text = "-";
            // 
            // _tbRangeEnd
            // 
            this._tbRangeEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._tbRangeEnd.Location = new System.Drawing.Point(93, 76);
            this._tbRangeEnd.Name = "_tbRangeEnd";
            this._tbRangeEnd.Size = new System.Drawing.Size(138, 20);
            this._tbRangeEnd.TabIndex = 5;
            // 
            // _tbRangeStart
            // 
            this._tbRangeStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._tbRangeStart.Location = new System.Drawing.Point(94, 37);
            this._tbRangeStart.Name = "_tbRangeStart";
            this._tbRangeStart.Size = new System.Drawing.Size(137, 20);
            this._tbRangeStart.TabIndex = 3;
            // 
            // _cmbRangeType
            // 
            this._cmbRangeType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._cmbRangeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cmbRangeType.FormattingEnabled = true;
            this._cmbRangeType.Items.AddRange(new object[] {
            "Range",
            "Subnet"});
            this._cmbRangeType.Location = new System.Drawing.Point(20, 38);
            this._cmbRangeType.Name = "_cmbRangeType";
            this._cmbRangeType.Size = new System.Drawing.Size(69, 21);
            this._cmbRangeType.TabIndex = 1;
            this._cmbRangeType.SelectedIndexChanged += new System.EventHandler(this._cmbRangeType_SelectedIndexChanged);
            this._cmbRangeType.Click += new System.EventHandler(this._cmbRangeType_SelectedIndexChanged);
            // 
            // _colLosses
            // 
            this._colLosses.Text = "Losses";
            this._colLosses.Width = 56;
            // 
            // _splMaster
            // 
            this._splMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this._splMaster.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this._splMaster.IsSplitterFixed = true;
            this._splMaster.Location = new System.Drawing.Point(0, 0);
            this._splMaster.Name = "_splMaster";
            this._splMaster.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // _splMaster.Panel1
            // 
            this._splMaster.Panel1.Controls.Add(this.pictureBox1);
            this._splMaster.Panel1.Controls.Add(this.button3);
            this._splMaster.Panel1.Controls.Add(this.button2);
            this._splMaster.Panel1.Controls.Add(this.button1);
            this._splMaster.Panel1.Controls.Add(this.dateTimePicker1);
            this._splMaster.Panel1.Controls.Add(this._lbLog);
            this._splMaster.Panel1.Controls.Add(this.textBox2);
            // 
            // _splMaster.Panel2
            // 
            this._splMaster.Panel2.Controls.Add(this.label1);
            this._splMaster.Panel2.Controls.Add(this.groupBox1);
            this._splMaster.Panel2.Controls.Add(this._prgScanProgress);
            this._splMaster.Panel2.Controls.Add(this._lvAliveHosts);
            this._splMaster.Size = new System.Drawing.Size(846, 448);
            this._splMaster.SplitterDistance = 160;
            this._splMaster.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MJSniff.Properties.Resources.transmit;
            this.pictureBox1.Location = new System.Drawing.Point(421, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 34);
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(399, 102);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 27;
            this.button3.Text = "About";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(463, 73);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 26;
            this.button2.Text = "Help";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(338, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "&Get Info";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(338, 137);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 24;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox2.ForeColor = System.Drawing.Color.Lime;
            this.textBox2.Location = new System.Drawing.Point(2, 10);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox2.Size = new System.Drawing.Size(318, 147);
            this.textBox2.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(264, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "This program is writen by doan dac ngoc anh and powered by C#";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this._btnStartStop);
            this.groupBox1.Controls.Add(this._spnPingsPerScan);
            this.groupBox1.Controls.Add(this._spnTimeout);
            this.groupBox1.Controls.Add(this._lRangeEnd);
            this.groupBox1.Controls.Add(this._spnTTL);
            this.groupBox1.Controls.Add(this._spnBufferSize);
            this.groupBox1.Controls.Add(this._cmbRangeType);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this._tbRangeStart);
            this.groupBox1.Controls.Add(this._lRangeSep);
            this.groupBox1.Controls.Add(this._spnConcurrentPings);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this._tbRangeEnd);
            this.groupBox1.ForeColor = System.Drawing.Color.LawnGreen;
            this.groupBox1.Location = new System.Drawing.Point(596, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 222);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "&Option";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // _btnStartStop
            // 
            this._btnStartStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._btnStartStop.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this._btnStartStop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this._btnStartStop.Location = new System.Drawing.Point(151, 175);
            this._btnStartStop.Name = "_btnStartStop";
            this._btnStartStop.Size = new System.Drawing.Size(80, 41);
            this._btnStartStop.TabIndex = 18;
            this._btnStartStop.Text = "&ReScan_IP";
            this._btnStartStop.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this._btnStartStop, "Nhấn để bắt đầu quét IP");
            this._btnStartStop.UseVisualStyleBackColor = false;
            this._btnStartStop.Click += new System.EventHandler(this._btnStartStop_Click);
            // 
            // _prgScanProgress
            // 
            this._prgScanProgress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._prgScanProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._prgScanProgress.Location = new System.Drawing.Point(124, 3);
            this._prgScanProgress.Name = "_prgScanProgress";
            this._prgScanProgress.Size = new System.Drawing.Size(604, 23);
            this._prgScanProgress.TabIndex = 5;
            this._prgScanProgress.Text = "Scanner is not running!";
            // 
            // _lvAliveHosts
            // 
            this._lvAliveHosts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._lvAliveHosts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this._colQuality,
            this._colIPAddress,
            this._colAvgResponseTime,
            this._colLosses,
            this._colHostName,
            this._colMAC});
            this._lvAliveHosts.FullRowSelect = true;
            this._lvAliveHosts.GridLines = true;
            this._lvAliveHosts.Location = new System.Drawing.Point(3, 32);
            this._lvAliveHosts.MultiSelect = false;
            this._lvAliveHosts.Name = "_lvAliveHosts";
            this._lvAliveHosts.Size = new System.Drawing.Size(578, 222);
            this._lvAliveHosts.SmallImageList = this._ilQuality;
            this._lvAliveHosts.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this._lvAliveHosts.TabIndex = 0;
            this._lvAliveHosts.UseCompatibleStateImageBehavior = false;
            this._lvAliveHosts.View = System.Windows.Forms.View.Details;
            this._lvAliveHosts.SelectedIndexChanged += new System.EventHandler(this._lvAliveHosts_SelectedIndexChanged);
            // 
            // _colMAC
            // 
            this._colMAC.Text = "MAC";
            this._colMAC.Width = 300;
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // IPScan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(846, 448);
            this.Controls.Add(this._splMaster);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IPScan";
            this.Text = "IPScan";
            this.Load += new System.EventHandler(this.IPScan_Load);
            ((System.ComponentModel.ISupportInitialize)(this._spnPingsPerScan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._spnConcurrentPings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._spnBufferSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._spnTTL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._spnTimeout)).EndInit();
            this._splMaster.Panel1.ResumeLayout(false);
            this._splMaster.Panel1.PerformLayout();
            this._splMaster.Panel2.ResumeLayout(false);
            this._splMaster.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._splMaster)).EndInit();
            this._splMaster.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList _ilQuality;
        private System.Windows.Forms.Label _lRangeEnd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown _spnPingsPerScan;
        private System.Windows.Forms.NumericUpDown _spnConcurrentPings;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolTip _ttQuality;
        private System.Windows.Forms.ColumnHeader _colQuality;
        private System.Windows.Forms.ColumnHeader _colIPAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown _spnBufferSize;
        private System.Windows.Forms.ListBox _lbLog;
        private System.Windows.Forms.ColumnHeader _colAvgResponseTime;
        private System.Windows.Forms.NumericUpDown _spnTTL;
        private System.Windows.Forms.ColumnHeader _colHostName;
        private System.Windows.Forms.NumericUpDown _spnTimeout;
        private System.Windows.Forms.Label _lRangeSep;
        private System.Windows.Forms.TextBox _tbRangeEnd;
        private System.Windows.Forms.TextBox _tbRangeStart;
        private System.Windows.Forms.ComboBox _cmbRangeType;
        private System.Windows.Forms.Button _btnStartStop;
        private System.Windows.Forms.ColumnHeader _colLosses;
        private System.Windows.Forms.SplitContainer _splMaster;
        private System.Windows.Forms.ListView _lvAliveHosts;
        private System.Windows.Forms.ProgressBar _prgScanProgress;
        private System.Windows.Forms.ColumnHeader _colMAC;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}