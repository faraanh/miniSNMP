namespace minisnmp
{
    partial class SNMP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SNMP));
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Loai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BangThong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PacketIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PacketOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtConStr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rtbGuiGet = new System.Windows.Forms.RichTextBox();
            this.txtIPAgent = new System.Windows.Forms.TextBox();
            this.lblIPAgent = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnGuiGet = new System.Windows.Forms.Button();
            this.rtbInfo = new System.Windows.Forms.RichTextBox();
            this.rtbAddInfo = new System.Windows.Forms.RichTextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AllowUserToDeleteRows = false;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.Ten,
            this.Loai,
            this.BangThong,
            this.PacketIn,
            this.PacketOut});
            this.dgvList.Location = new System.Drawing.Point(273, 341);
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            this.dgvList.RowHeadersVisible = false;
            this.dgvList.Size = new System.Drawing.Size(676, 205);
            this.dgvList.TabIndex = 25;
            this.dgvList.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvList_RowEnter);
            // 
            // stt
            // 
            this.stt.HeaderText = "Num";
            this.stt.Name = "stt";
            this.stt.ReadOnly = true;
            this.stt.Width = 30;
            // 
            // Ten
            // 
            this.Ten.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Ten.HeaderText = "Name";
            this.Ten.Name = "Ten";
            this.Ten.ReadOnly = true;
            // 
            // Loai
            // 
            this.Loai.HeaderText = "Type";
            this.Loai.Name = "Loai";
            this.Loai.ReadOnly = true;
            this.Loai.Width = 125;
            // 
            // BangThong
            // 
            this.BangThong.HeaderText = "Bandwidth";
            this.BangThong.Name = "BangThong";
            this.BangThong.ReadOnly = true;
            this.BangThong.Width = 80;
            // 
            // PacketIn
            // 
            this.PacketIn.HeaderText = "Packet In";
            this.PacketIn.Name = "PacketIn";
            this.PacketIn.ReadOnly = true;
            this.PacketIn.Width = 80;
            // 
            // PacketOut
            // 
            this.PacketOut.HeaderText = "Packet Out";
            this.PacketOut.Name = "PacketOut";
            this.PacketOut.ReadOnly = true;
            this.PacketOut.Width = 80;
            // 
            // txtConStr
            // 
            this.txtConStr.Location = new System.Drawing.Point(81, 57);
            this.txtConStr.Name = "txtConStr";
            this.txtConStr.Size = new System.Drawing.Size(98, 20);
            this.txtConStr.TabIndex = 24;
            this.txtConStr.Text = "public";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Connect String";
            // 
            // rtbGuiGet
            // 
            this.rtbGuiGet.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rtbGuiGet.ForeColor = System.Drawing.Color.Lime;
            this.rtbGuiGet.Location = new System.Drawing.Point(273, 2);
            this.rtbGuiGet.Name = "rtbGuiGet";
            this.rtbGuiGet.Size = new System.Drawing.Size(676, 112);
            this.rtbGuiGet.TabIndex = 22;
            this.rtbGuiGet.Text = "";
            // 
            // txtIPAgent
            // 
            this.txtIPAgent.Location = new System.Drawing.Point(81, 31);
            this.txtIPAgent.Name = "txtIPAgent";
            this.txtIPAgent.Size = new System.Drawing.Size(98, 20);
            this.txtIPAgent.TabIndex = 21;
            this.txtIPAgent.Text = "127.0.0.1";
            // 
            // lblIPAgent
            // 
            this.lblIPAgent.AutoSize = true;
            this.lblIPAgent.Location = new System.Drawing.Point(4, 34);
            this.lblIPAgent.Name = "lblIPAgent";
            this.lblIPAgent.Size = new System.Drawing.Size(48, 13);
            this.lblIPAgent.TabIndex = 20;
            this.lblIPAgent.Text = "IP Agent";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnGuiGet
            // 
            this.btnGuiGet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuiGet.Location = new System.Drawing.Point(179, 74);
            this.btnGuiGet.Name = "btnGuiGet";
            this.btnGuiGet.Size = new System.Drawing.Size(60, 40);
            this.btnGuiGet.TabIndex = 19;
            this.btnGuiGet.Text = "&Get Info ";
            this.btnGuiGet.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnGuiGet, "Nhấn để nhận thông tin từ máy trạm");
            this.btnGuiGet.UseVisualStyleBackColor = true;
            this.btnGuiGet.Click += new System.EventHandler(this.btnGuiGet_Click);
            // 
            // rtbInfo
            // 
            this.rtbInfo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rtbInfo.ForeColor = System.Drawing.Color.Lime;
            this.rtbInfo.Location = new System.Drawing.Point(7, 341);
            this.rtbInfo.Name = "rtbInfo";
            this.rtbInfo.Size = new System.Drawing.Size(266, 205);
            this.rtbInfo.TabIndex = 33;
            this.rtbInfo.Text = "";
            // 
            // rtbAddInfo
            // 
            this.rtbAddInfo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rtbAddInfo.ForeColor = System.Drawing.Color.Lime;
            this.rtbAddInfo.Location = new System.Drawing.Point(273, 120);
            this.rtbAddInfo.Name = "rtbAddInfo";
            this.rtbAddInfo.Size = new System.Drawing.Size(676, 215);
            this.rtbAddInfo.TabIndex = 34;
            this.rtbAddInfo.Text = "";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MJSniff.Properties.Resources.a3;
            this.pictureBox2.Location = new System.Drawing.Point(7, 122);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(260, 215);
            this.pictureBox2.TabIndex = 37;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MJSniff.Properties.Resources.transmit;
            this.pictureBox1.Location = new System.Drawing.Point(193, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 33);
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // SNMP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(953, 558);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.rtbAddInfo);
            this.Controls.Add(this.rtbInfo);
            this.Controls.Add(this.dgvList);
            this.Controls.Add(this.txtConStr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbGuiGet);
            this.Controls.Add(this.txtIPAgent);
            this.Controls.Add(this.lblIPAgent);
            this.Controls.Add(this.btnGuiGet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SNMP";
            this.Text = "SNMP";
            this.Load += new System.EventHandler(this.SNMPForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.TextBox txtConStr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbGuiGet;
        private System.Windows.Forms.TextBox txtIPAgent;
        private System.Windows.Forms.Label lblIPAgent;
        private System.Windows.Forms.Button btnGuiGet;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RichTextBox rtbInfo;
        private System.Windows.Forms.RichTextBox rtbAddInfo;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn Loai;
        private System.Windows.Forms.DataGridViewTextBoxColumn BangThong;
        private System.Windows.Forms.DataGridViewTextBoxColumn PacketIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PacketOut;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}