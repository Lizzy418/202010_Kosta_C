namespace WinApp3_Client
{
    partial class FrmClient
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cbInterval = new System.Windows.Forms.CheckBox();
            this.tbInterval = new System.Windows.Forms.TextBox();
            this.tbHum = new System.Windows.Forms.TextBox();
            this.tbWind = new System.Windows.Forms.TextBox();
            this.tbTemp = new System.Windows.Forms.TextBox();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.tbCode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbProtocol = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbKeepAlive = new System.Windows.Forms.CheckBox();
            this.tbServerPort = new System.Windows.Forms.TextBox();
            this.tbServerIP = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.tbMemo = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuStart = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStop = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuClose = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.cbInterval);
            this.groupBox1.Controls.Add(this.tbInterval);
            this.groupBox1.Controls.Add(this.tbHum);
            this.groupBox1.Controls.Add(this.tbWind);
            this.groupBox1.Controls.Add(this.tbTemp);
            this.groupBox1.Controls.Add(this.tbModel);
            this.groupBox1.Controls.Add(this.tbCode);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("나눔스퀘어라운드 ExtraBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.groupBox1.Location = new System.Drawing.Point(12, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(520, 236);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Virtual Equip Signal";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.Color.LemonChiffon;
            this.dateTimePicker1.Font = new System.Drawing.Font("나눔스퀘어라운드 Bold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dateTimePicker1.Location = new System.Drawing.Point(102, 44);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(293, 25);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // cbInterval
            // 
            this.cbInterval.AutoSize = true;
            this.cbInterval.Checked = true;
            this.cbInterval.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbInterval.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbInterval.Location = new System.Drawing.Point(257, 195);
            this.cbInterval.Name = "cbInterval";
            this.cbInterval.Size = new System.Drawing.Size(18, 17);
            this.cbInterval.TabIndex = 2;
            this.cbInterval.UseVisualStyleBackColor = true;
            // 
            // tbInterval
            // 
            this.tbInterval.BackColor = System.Drawing.Color.Beige;
            this.tbInterval.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbInterval.Font = new System.Drawing.Font("나눔스퀘어라운드 Bold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbInterval.Location = new System.Drawing.Point(278, 193);
            this.tbInterval.Name = "tbInterval";
            this.tbInterval.Size = new System.Drawing.Size(117, 20);
            this.tbInterval.TabIndex = 1;
            this.tbInterval.Text = "2000";
            // 
            // tbHum
            // 
            this.tbHum.BackColor = System.Drawing.Color.Beige;
            this.tbHum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbHum.Font = new System.Drawing.Font("나눔스퀘어라운드 Bold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbHum.Location = new System.Drawing.Point(256, 146);
            this.tbHum.Name = "tbHum";
            this.tbHum.Size = new System.Drawing.Size(139, 20);
            this.tbHum.TabIndex = 1;
            this.tbHum.Text = "30.00";
            // 
            // tbWind
            // 
            this.tbWind.BackColor = System.Drawing.Color.Beige;
            this.tbWind.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbWind.Font = new System.Drawing.Font("나눔스퀘어라운드 Bold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbWind.Location = new System.Drawing.Point(102, 193);
            this.tbWind.Name = "tbWind";
            this.tbWind.Size = new System.Drawing.Size(139, 20);
            this.tbWind.TabIndex = 1;
            this.tbWind.Text = "02.00";
            // 
            // tbTemp
            // 
            this.tbTemp.BackColor = System.Drawing.Color.Beige;
            this.tbTemp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTemp.Font = new System.Drawing.Font("나눔스퀘어라운드 Bold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbTemp.Location = new System.Drawing.Point(102, 146);
            this.tbTemp.Name = "tbTemp";
            this.tbTemp.Size = new System.Drawing.Size(139, 20);
            this.tbTemp.TabIndex = 1;
            this.tbTemp.Text = "10.5";
            // 
            // tbModel
            // 
            this.tbModel.BackColor = System.Drawing.Color.Beige;
            this.tbModel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbModel.Font = new System.Drawing.Font("나눔스퀘어라운드 Bold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbModel.Location = new System.Drawing.Point(256, 94);
            this.tbModel.Name = "tbModel";
            this.tbModel.Size = new System.Drawing.Size(139, 20);
            this.tbModel.TabIndex = 1;
            this.tbModel.Text = "00000";
            // 
            // tbCode
            // 
            this.tbCode.BackColor = System.Drawing.Color.Beige;
            this.tbCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCode.Font = new System.Drawing.Font("나눔스퀘어라운드 Bold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbCode.Location = new System.Drawing.Point(102, 94);
            this.tbCode.Name = "tbCode";
            this.tbCode.Size = new System.Drawing.Size(139, 20);
            this.tbCode.TabIndex = 1;
            this.tbCode.Text = "10001";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("나눔스퀘어라운드 Bold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label5.Location = new System.Drawing.Point(20, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "상태 W";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔스퀘어라운드 Bold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label2.Location = new System.Drawing.Point(20, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "fCode";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("나눔스퀘어라운드 Bold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label4.Location = new System.Drawing.Point(20, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "상태 T";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("나눔스퀘어라운드 Bold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label7.Location = new System.Drawing.Point(412, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "상태 H";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("나눔스퀘어라운드 Bold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label8.Location = new System.Drawing.Point(412, 194);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 18);
            this.label8.TabIndex = 0;
            this.label8.Text = "Interval(ms)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("나눔스퀘어라운드 Bold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label3.Location = new System.Drawing.Point(412, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Model Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔스퀘어라운드 Bold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label1.Location = new System.Drawing.Point(20, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "시작시간";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("나눔스퀘어라운드 Bold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label6.Location = new System.Drawing.Point(20, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Protocol";
            // 
            // tbProtocol
            // 
            this.tbProtocol.BackColor = System.Drawing.Color.Beige;
            this.tbProtocol.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbProtocol.Font = new System.Drawing.Font("나눔스퀘어라운드 Bold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbProtocol.Location = new System.Drawing.Point(102, 91);
            this.tbProtocol.Name = "tbProtocol";
            this.tbProtocol.Size = new System.Drawing.Size(293, 20);
            this.tbProtocol.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.cbKeepAlive);
            this.groupBox2.Controls.Add(this.tbServerPort);
            this.groupBox2.Controls.Add(this.tbServerIP);
            this.groupBox2.Controls.Add(this.tbProtocol);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("나눔스퀘어라운드 ExtraBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.groupBox2.Location = new System.Drawing.Point(12, 374);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(520, 132);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Communication Control";
            // 
            // cbKeepAlive
            // 
            this.cbKeepAlive.AutoSize = true;
            this.cbKeepAlive.Checked = true;
            this.cbKeepAlive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbKeepAlive.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbKeepAlive.Font = new System.Drawing.Font("나눔스퀘어라운드 Bold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbKeepAlive.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.cbKeepAlive.Location = new System.Drawing.Point(331, 47);
            this.cbKeepAlive.Name = "cbKeepAlive";
            this.cbKeepAlive.Size = new System.Drawing.Size(210, 22);
            this.cbKeepAlive.TabIndex = 2;
            this.cbKeepAlive.Text = "Disconnect after Send";
            this.cbKeepAlive.UseVisualStyleBackColor = true;
            // 
            // tbServerPort
            // 
            this.tbServerPort.BackColor = System.Drawing.Color.Beige;
            this.tbServerPort.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbServerPort.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbServerPort.Font = new System.Drawing.Font("나눔스퀘어라운드 Bold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbServerPort.Location = new System.Drawing.Point(256, 47);
            this.tbServerPort.Name = "tbServerPort";
            this.tbServerPort.Size = new System.Drawing.Size(69, 20);
            this.tbServerPort.TabIndex = 1;
            this.tbServerPort.Text = "9000";
            // 
            // tbServerIP
            // 
            this.tbServerIP.BackColor = System.Drawing.Color.Beige;
            this.tbServerIP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbServerIP.Font = new System.Drawing.Font("나눔스퀘어라운드 Bold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbServerIP.Location = new System.Drawing.Point(102, 47);
            this.tbServerIP.Name = "tbServerIP";
            this.tbServerIP.Size = new System.Drawing.Size(152, 20);
            this.tbServerIP.TabIndex = 1;
            this.tbServerIP.Text = "192.168.0.181";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("나눔스퀘어라운드 Bold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label18.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label18.Location = new System.Drawing.Point(20, 50);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(81, 18);
            this.label18.TabIndex = 0;
            this.label18.Text = "Server IP";
            // 
            // tbMemo
            // 
            this.tbMemo.BackColor = System.Drawing.Color.Beige;
            this.tbMemo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbMemo.Location = new System.Drawing.Point(12, 17);
            this.tbMemo.Multiline = true;
            this.tbMemo.Name = "tbMemo";
            this.tbMemo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbMemo.Size = new System.Drawing.Size(520, 67);
            this.tbMemo.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("나눔스퀘어라운드 Bold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuStart,
            this.mnuStop,
            this.mnuClose});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(236, 70);
            // 
            // mnuStart
            // 
            this.mnuStart.Name = "mnuStart";
            this.mnuStart.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mnuStart.Size = new System.Drawing.Size(235, 22);
            this.mnuStart.Text = "시작 (Start)";
            this.mnuStart.Click += new System.EventHandler(this.mnuStart_Click);
            // 
            // mnuStop
            // 
            this.mnuStop.Name = "mnuStop";
            this.mnuStop.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.mnuStop.Size = new System.Drawing.Size(235, 22);
            this.mnuStop.Text = "종료 (Stop)";
            this.mnuStop.Click += new System.EventHandler(this.mnuStop_Click);
            // 
            // mnuClose
            // 
            this.mnuClose.Name = "mnuClose";
            this.mnuClose.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.mnuClose.Size = new System.Drawing.Size(235, 22);
            this.mnuClose.Text = "프로그램 끝내기";
            this.mnuClose.Click += new System.EventHandler(this.mnuClose_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(546, 529);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbMemo);
            this.Font = new System.Drawing.Font("나눔스퀘어라운드 Bold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Name = "FrmClient";
            this.Text = "TCP/IP Client";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbInterval;
        private System.Windows.Forms.TextBox tbInterval;
        private System.Windows.Forms.TextBox tbWind;
        private System.Windows.Forms.TextBox tbTemp;
        private System.Windows.Forms.TextBox tbModel;
        private System.Windows.Forms.TextBox tbCode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbProtocol;
        private System.Windows.Forms.TextBox tbHum;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbKeepAlive;
        private System.Windows.Forms.TextBox tbServerPort;
        private System.Windows.Forms.TextBox tbServerIP;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tbMemo;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuStart;
        private System.Windows.Forms.ToolStripMenuItem mnuStop;
        private System.Windows.Forms.ToolStripMenuItem mnuClose;
        private System.Windows.Forms.Timer timer1;
    }
}

