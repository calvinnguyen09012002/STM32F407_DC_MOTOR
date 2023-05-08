
namespace final
{
    partial class txt_receive_data
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
            this.bt_connect = new System.Windows.Forms.Button();
            this.cbb_select_com = new System.Windows.Forms.ComboBox();
            this.cbb_select_baud = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_receive = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.cbb_datasize = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbb_parity = new System.Windows.Forms.ComboBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cb_led2 = new System.Windows.Forms.CheckBox();
            this.cb_led1 = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bt_update_kd = new System.Windows.Forms.Button();
            this.bt_update_ki = new System.Windows.Forms.Button();
            this.bt_update_kp = new System.Windows.Forms.Button();
            this.bt_update_set_point = new System.Windows.Forms.Button();
            this.txt_kd = new System.Windows.Forms.TextBox();
            this.txt_ki = new System.Windows.Forms.TextBox();
            this.txt_kp = new System.Windows.Forms.TextBox();
            this.txt_setpoint = new System.Windows.Forms.TextBox();
            this.bt_Start = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cb_led15 = new System.Windows.Forms.CheckBox();
            this.cb_led14 = new System.Windows.Forms.CheckBox();
            this.txt_syn = new System.Windows.Forms.TextBox();
            this.Handshake = new System.Windows.Forms.GroupBox();
            this.txt_ack = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_emergency = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.Handshake.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_connect
            // 
            this.bt_connect.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_connect.Location = new System.Drawing.Point(101, 174);
            this.bt_connect.Name = "bt_connect";
            this.bt_connect.Size = new System.Drawing.Size(141, 31);
            this.bt_connect.TabIndex = 0;
            this.bt_connect.Text = "CONNECT";
            this.bt_connect.UseVisualStyleBackColor = true;
            this.bt_connect.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbb_select_com
            // 
            this.cbb_select_com.FormattingEnabled = true;
            this.cbb_select_com.Location = new System.Drawing.Point(101, 37);
            this.cbb_select_com.Name = "cbb_select_com";
            this.cbb_select_com.Size = new System.Drawing.Size(141, 24);
            this.cbb_select_com.TabIndex = 1;
            this.cbb_select_com.Text = "COM5";
            // 
            // cbb_select_baud
            // 
            this.cbb_select_baud.FormattingEnabled = true;
            this.cbb_select_baud.Items.AddRange(new object[] {
            "9600",
            "115200"});
            this.cbb_select_baud.Location = new System.Drawing.Point(101, 67);
            this.cbb_select_baud.Name = "cbb_select_baud";
            this.cbb_select_baud.Size = new System.Drawing.Size(141, 24);
            this.cbb_select_baud.TabIndex = 1;
            this.cbb_select_baud.Text = "9600";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_receive);
            this.groupBox1.Location = new System.Drawing.Point(612, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(202, 59);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SPEED";
            // 
            // txt_receive
            // 
            this.txt_receive.Location = new System.Drawing.Point(4, 23);
            this.txt_receive.Multiline = true;
            this.txt_receive.Name = "txt_receive";
            this.txt_receive.Size = new System.Drawing.Size(188, 26);
            this.txt_receive.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Baud";
            // 
            // serialPort1
            // 
            this.serialPort1.ReceivedBytesThreshold = 8;
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.OnData);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Datasize";
            // 
            // cbb_datasize
            // 
            this.cbb_datasize.FormattingEnabled = true;
            this.cbb_datasize.Items.AddRange(new object[] {
            "7",
            "8",
            "9"});
            this.cbb_datasize.Location = new System.Drawing.Point(101, 101);
            this.cbb_datasize.Name = "cbb_datasize";
            this.cbb_datasize.Size = new System.Drawing.Size(141, 24);
            this.cbb_datasize.TabIndex = 1;
            this.cbb_datasize.Text = "8";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Parity";
            // 
            // cbb_parity
            // 
            this.cbb_parity.FormattingEnabled = true;
            this.cbb_parity.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.cbb_parity.Location = new System.Drawing.Point(101, 134);
            this.cbb_parity.Name = "cbb_parity";
            this.cbb_parity.Size = new System.Drawing.Size(141, 24);
            this.cbb_parity.TabIndex = 1;
            this.cbb_parity.Text = "None";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(101, 211);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(141, 15);
            this.progressBar1.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bt_connect);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cbb_select_com);
            this.groupBox2.Controls.Add(this.cbb_select_baud);
            this.groupBox2.Controls.Add(this.cbb_datasize);
            this.groupBox2.Controls.Add(this.cbb_parity);
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(263, 226);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Serial";
            // 
            // cb_led2
            // 
            this.cb_led2.AutoSize = true;
            this.cb_led2.Location = new System.Drawing.Point(4, 56);
            this.cb_led2.Name = "cb_led2";
            this.cb_led2.Size = new System.Drawing.Size(74, 21);
            this.cb_led2.TabIndex = 9;
            this.cb_led2.Text = "Led 13";
            this.cb_led2.UseVisualStyleBackColor = true;
            this.cb_led2.CheckedChanged += new System.EventHandler(this.cb_led2_CheckedChanged);
            // 
            // cb_led1
            // 
            this.cb_led1.AutoSize = true;
            this.cb_led1.Location = new System.Drawing.Point(4, 29);
            this.cb_led1.Name = "cb_led1";
            this.cb_led1.Size = new System.Drawing.Size(74, 21);
            this.cb_led1.TabIndex = 9;
            this.cb_led1.Text = "Led 12";
            this.cb_led1.UseVisualStyleBackColor = true;
            this.cb_led1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bt_update_kd);
            this.groupBox3.Controls.Add(this.bt_update_ki);
            this.groupBox3.Controls.Add(this.bt_update_kp);
            this.groupBox3.Controls.Add(this.bt_update_set_point);
            this.groupBox3.Controls.Add(this.txt_kd);
            this.groupBox3.Controls.Add(this.txt_ki);
            this.groupBox3.Controls.Add(this.txt_kp);
            this.groupBox3.Controls.Add(this.txt_setpoint);
            this.groupBox3.Controls.Add(this.bt_Start);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(291, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(307, 226);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "DC Motor";
            // 
            // bt_update_kd
            // 
            this.bt_update_kd.Location = new System.Drawing.Point(225, 137);
            this.bt_update_kd.Name = "bt_update_kd";
            this.bt_update_kd.Size = new System.Drawing.Size(75, 30);
            this.bt_update_kd.TabIndex = 10;
            this.bt_update_kd.Text = "update";
            this.bt_update_kd.UseVisualStyleBackColor = true;
            this.bt_update_kd.Click += new System.EventHandler(this.bt_update_kd_Click);
            // 
            // bt_update_ki
            // 
            this.bt_update_ki.Location = new System.Drawing.Point(225, 101);
            this.bt_update_ki.Name = "bt_update_ki";
            this.bt_update_ki.Size = new System.Drawing.Size(75, 30);
            this.bt_update_ki.TabIndex = 10;
            this.bt_update_ki.Text = "update";
            this.bt_update_ki.UseVisualStyleBackColor = true;
            this.bt_update_ki.Click += new System.EventHandler(this.bt_update_ki_Click);
            // 
            // bt_update_kp
            // 
            this.bt_update_kp.Location = new System.Drawing.Point(225, 65);
            this.bt_update_kp.Name = "bt_update_kp";
            this.bt_update_kp.Size = new System.Drawing.Size(75, 30);
            this.bt_update_kp.TabIndex = 10;
            this.bt_update_kp.Text = "update";
            this.bt_update_kp.UseVisualStyleBackColor = true;
            this.bt_update_kp.Click += new System.EventHandler(this.bt_update_kp_Click);
            // 
            // bt_update_set_point
            // 
            this.bt_update_set_point.Location = new System.Drawing.Point(225, 26);
            this.bt_update_set_point.Name = "bt_update_set_point";
            this.bt_update_set_point.Size = new System.Drawing.Size(75, 30);
            this.bt_update_set_point.TabIndex = 10;
            this.bt_update_set_point.Text = "update";
            this.bt_update_set_point.UseVisualStyleBackColor = true;
            this.bt_update_set_point.Click += new System.EventHandler(this.bt_update_set_point_Click);
            // 
            // txt_kd
            // 
            this.txt_kd.Location = new System.Drawing.Point(100, 143);
            this.txt_kd.Name = "txt_kd";
            this.txt_kd.Size = new System.Drawing.Size(119, 22);
            this.txt_kd.TabIndex = 9;
            this.txt_kd.Text = "0";
            // 
            // txt_ki
            // 
            this.txt_ki.Location = new System.Drawing.Point(100, 105);
            this.txt_ki.Name = "txt_ki";
            this.txt_ki.Size = new System.Drawing.Size(119, 22);
            this.txt_ki.TabIndex = 9;
            this.txt_ki.Text = "1";
            // 
            // txt_kp
            // 
            this.txt_kp.Location = new System.Drawing.Point(100, 69);
            this.txt_kp.Name = "txt_kp";
            this.txt_kp.Size = new System.Drawing.Size(119, 22);
            this.txt_kp.TabIndex = 9;
            this.txt_kp.Text = "2.5";
            // 
            // txt_setpoint
            // 
            this.txt_setpoint.Location = new System.Drawing.Point(101, 26);
            this.txt_setpoint.Name = "txt_setpoint";
            this.txt_setpoint.Size = new System.Drawing.Size(119, 22);
            this.txt_setpoint.TabIndex = 9;
            this.txt_setpoint.Text = "150";
            // 
            // bt_Start
            // 
            this.bt_Start.Location = new System.Drawing.Point(105, 186);
            this.bt_Start.Name = "bt_Start";
            this.bt_Start.Size = new System.Drawing.Size(115, 29);
            this.bt_Start.TabIndex = 8;
            this.bt_Start.Text = "START";
            this.bt_Start.UseVisualStyleBackColor = true;
            this.bt_Start.Click += new System.EventHandler(this.bt_Start_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(32, 153);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 17);
            this.label10.TabIndex = 7;
            this.label10.Text = "Kd";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(37, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 17);
            this.label9.TabIndex = 7;
            this.label9.Text = "Ki";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Kp";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "Set Point";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Location = new System.Drawing.Point(3, 236);
            this.zedGraphControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(1226, 385);
            this.zedGraphControl1.TabIndex = 11;
            this.zedGraphControl1.UseExtendedPrintDialog = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cb_led15);
            this.groupBox4.Controls.Add(this.cb_led14);
            this.groupBox4.Controls.Add(this.cb_led1);
            this.groupBox4.Controls.Add(this.cb_led2);
            this.groupBox4.Location = new System.Drawing.Point(613, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(201, 95);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "LED";
            // 
            // cb_led15
            // 
            this.cb_led15.AutoSize = true;
            this.cb_led15.Location = new System.Drawing.Point(100, 53);
            this.cb_led15.Name = "cb_led15";
            this.cb_led15.Size = new System.Drawing.Size(74, 21);
            this.cb_led15.TabIndex = 11;
            this.cb_led15.Text = "Led 15";
            this.cb_led15.UseVisualStyleBackColor = true;
            this.cb_led15.CheckedChanged += new System.EventHandler(this.cb_led15_CheckedChanged);
            // 
            // cb_led14
            // 
            this.cb_led14.AutoSize = true;
            this.cb_led14.Location = new System.Drawing.Point(100, 26);
            this.cb_led14.Name = "cb_led14";
            this.cb_led14.Size = new System.Drawing.Size(74, 21);
            this.cb_led14.TabIndex = 10;
            this.cb_led14.Text = "Led 14";
            this.cb_led14.UseVisualStyleBackColor = true;
            this.cb_led14.CheckedChanged += new System.EventHandler(this.cb_led14_CheckedChanged);
            // 
            // txt_syn
            // 
            this.txt_syn.Location = new System.Drawing.Point(6, 40);
            this.txt_syn.Multiline = true;
            this.txt_syn.Name = "txt_syn";
            this.txt_syn.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_syn.Size = new System.Drawing.Size(189, 166);
            this.txt_syn.TabIndex = 13;
            // 
            // Handshake
            // 
            this.Handshake.Controls.Add(this.txt_ack);
            this.Handshake.Controls.Add(this.txt_syn);
            this.Handshake.Controls.Add(this.label6);
            this.Handshake.Controls.Add(this.label5);
            this.Handshake.Location = new System.Drawing.Point(820, 3);
            this.Handshake.Name = "Handshake";
            this.Handshake.Size = new System.Drawing.Size(409, 225);
            this.Handshake.TabIndex = 14;
            this.Handshake.TabStop = false;
            this.Handshake.Text = "HANDSHAKE";
            // 
            // txt_ack
            // 
            this.txt_ack.Location = new System.Drawing.Point(223, 40);
            this.txt_ack.Multiline = true;
            this.txt_ack.Name = "txt_ack";
            this.txt_ack.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_ack.Size = new System.Drawing.Size(180, 171);
            this.txt_ack.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(220, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "MCU to PC";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "PC to MCU";
            // 
            // txt_emergency
            // 
            this.txt_emergency.ForeColor = System.Drawing.Color.Red;
            this.txt_emergency.Location = new System.Drawing.Point(6, 27);
            this.txt_emergency.Name = "txt_emergency";
            this.txt_emergency.Size = new System.Drawing.Size(184, 22);
            this.txt_emergency.TabIndex = 15;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txt_emergency);
            this.groupBox5.Location = new System.Drawing.Point(614, 169);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 59);
            this.groupBox5.TabIndex = 16;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "EMERGENCY";
            // 
            // txt_receive_data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 676);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.Handshake);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.zedGraphControl1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "txt_receive_data";
            this.Text = "Serial Communication";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.Handshake.ResumeLayout(false);
            this.Handshake.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_connect;
        private System.Windows.Forms.ComboBox cbb_select_com;
        private System.Windows.Forms.ComboBox cbb_select_baud;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbb_datasize;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbb_parity;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cb_led2;
        private System.Windows.Forms.CheckBox cb_led1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button bt_Start;
        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.TextBox txt_setpoint;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button bt_update_kd;
        private System.Windows.Forms.Button bt_update_ki;
        private System.Windows.Forms.Button bt_update_kp;
        private System.Windows.Forms.Button bt_update_set_point;
        private System.Windows.Forms.TextBox txt_kd;
        private System.Windows.Forms.TextBox txt_ki;
        private System.Windows.Forms.TextBox txt_kp;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox cb_led15;
        private System.Windows.Forms.CheckBox cb_led14;
        private System.Windows.Forms.TextBox txt_syn;
        private System.Windows.Forms.GroupBox Handshake;
        private System.Windows.Forms.TextBox txt_ack;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_receive;
        private System.Windows.Forms.TextBox txt_emergency;
        private System.Windows.Forms.GroupBox groupBox5;
    }
}

