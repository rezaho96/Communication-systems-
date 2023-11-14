namespace WindowsFormsApplication5
{
    partial class Form1
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
            this.lblprop = new System.Windows.Forms.Label();
            this.btnconect = new System.Windows.Forms.Button();
            this.tbnum = new System.Windows.Forms.TextBox();
            this.tbip = new System.Windows.Forms.TextBox();
            this.lblnum = new System.Windows.Forms.Label();
            this.lblip = new System.Windows.Forms.Label();
            this.lblcolor = new System.Windows.Forms.Label();
            this.lblshape = new System.Windows.Forms.Label();
            this.lblstatus = new System.Windows.Forms.Label();
            this.btndisconect = new System.Windows.Forms.Button();
            this.cmbportname = new System.Windows.Forms.ComboBox();
            this.btnconectt = new System.Windows.Forms.Button();
            this.btnplay = new System.Windows.Forms.Button();
            this.tstart = new System.Windows.Forms.Timer(this.components);
            this.tshow = new System.Windows.Forms.Timer(this.components);
            this.Myserialport = new System.IO.Ports.SerialPort(this.components);
            this.lblscore = new System.Windows.Forms.Label();
            this.btnmorabaa = new System.Windows.Forms.Button();
            this.btnmosalas = new System.Windows.Forms.Button();
            this.btndayere = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblprop
            // 
            this.lblprop.AutoSize = true;
            this.lblprop.Location = new System.Drawing.Point(114, 119);
            this.lblprop.Name = "lblprop";
            this.lblprop.Size = new System.Drawing.Size(0, 13);
            this.lblprop.TabIndex = 13;
            // 
            // btnconect
            // 
            this.btnconect.Location = new System.Drawing.Point(101, 89);
            this.btnconect.Name = "btnconect";
            this.btnconect.Size = new System.Drawing.Size(75, 23);
            this.btnconect.TabIndex = 12;
            this.btnconect.Text = "مجوز ارتباط";
            this.btnconect.UseVisualStyleBackColor = true;
            this.btnconect.Click += new System.EventHandler(this.btnconect_Click);
            // 
            // tbnum
            // 
            this.tbnum.Location = new System.Drawing.Point(152, 50);
            this.tbnum.Name = "tbnum";
            this.tbnum.Size = new System.Drawing.Size(100, 20);
            this.tbnum.TabIndex = 11;
            // 
            // tbip
            // 
            this.tbip.Location = new System.Drawing.Point(10, 50);
            this.tbip.Name = "tbip";
            this.tbip.Size = new System.Drawing.Size(100, 20);
            this.tbip.TabIndex = 10;
            // 
            // lblnum
            // 
            this.lblnum.AutoSize = true;
            this.lblnum.Location = new System.Drawing.Point(165, 20);
            this.lblnum.Name = "lblnum";
            this.lblnum.Size = new System.Drawing.Size(62, 13);
            this.lblnum.TabIndex = 9;
            this.lblnum.Text = "شماره پورت";
            // 
            // lblip
            // 
            this.lblip.AutoSize = true;
            this.lblip.Location = new System.Drawing.Point(24, 20);
            this.lblip.Name = "lblip";
            this.lblip.Size = new System.Drawing.Size(65, 13);
            this.lblip.TabIndex = 8;
            this.lblip.Text = "سرورIPآدرس";
            // 
            // lblcolor
            // 
            this.lblcolor.AutoSize = true;
            this.lblcolor.Enabled = false;
            this.lblcolor.Location = new System.Drawing.Point(599, 389);
            this.lblcolor.Name = "lblcolor";
            this.lblcolor.Size = new System.Drawing.Size(23, 13);
            this.lblcolor.TabIndex = 23;
            this.lblcolor.Text = "رنگ";
            // 
            // lblshape
            // 
            this.lblshape.AutoSize = true;
            this.lblshape.Location = new System.Drawing.Point(658, 362);
            this.lblshape.Name = "lblshape";
            this.lblshape.Size = new System.Drawing.Size(30, 13);
            this.lblshape.TabIndex = 22;
            this.lblshape.Text = "شکل";
            // 
            // lblstatus
            // 
            this.lblstatus.AutoSize = true;
            this.lblstatus.Location = new System.Drawing.Point(298, 197);
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(0, 13);
            this.lblstatus.TabIndex = 21;
            // 
            // btndisconect
            // 
            this.btndisconect.Location = new System.Drawing.Point(199, 187);
            this.btndisconect.Name = "btndisconect";
            this.btndisconect.Size = new System.Drawing.Size(75, 23);
            this.btndisconect.TabIndex = 20;
            this.btndisconect.Text = "disconect";
            this.btndisconect.UseVisualStyleBackColor = true;
            this.btndisconect.Click += new System.EventHandler(this.btndisconect_Click);
            // 
            // cmbportname
            // 
            this.cmbportname.FormattingEnabled = true;
            this.cmbportname.Location = new System.Drawing.Point(280, 158);
            this.cmbportname.Name = "cmbportname";
            this.cmbportname.Size = new System.Drawing.Size(121, 21);
            this.cmbportname.TabIndex = 19;
            // 
            // btnconectt
            // 
            this.btnconectt.Enabled = false;
            this.btnconectt.Location = new System.Drawing.Point(199, 158);
            this.btnconectt.Name = "btnconectt";
            this.btnconectt.Size = new System.Drawing.Size(75, 23);
            this.btnconectt.TabIndex = 18;
            this.btnconectt.Text = "conect";
            this.btnconectt.UseVisualStyleBackColor = true;
            this.btnconectt.Click += new System.EventHandler(this.btnconectt_Click);
            // 
            // btnplay
            // 
            this.btnplay.Enabled = false;
            this.btnplay.Location = new System.Drawing.Point(280, 389);
            this.btnplay.Name = "btnplay";
            this.btnplay.Size = new System.Drawing.Size(75, 25);
            this.btnplay.TabIndex = 17;
            this.btnplay.Text = "play";
            this.btnplay.UseVisualStyleBackColor = true;
            this.btnplay.Click += new System.EventHandler(this.btnplay_Click);
            // 
            // tstart
            // 
            this.tstart.Interval = 60000;
            this.tstart.Tick += new System.EventHandler(this.tstart_Tick);
            // 
            // tshow
            // 
            this.tshow.Interval = 3000;
            this.tshow.Tick += new System.EventHandler(this.tshow_Tick);
            // 
            // Myserialport
            // 
            this.Myserialport.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.Myserialport_DataReceived);
            // 
            // lblscore
            // 
            this.lblscore.AutoSize = true;
            this.lblscore.Location = new System.Drawing.Point(7, 9);
            this.lblscore.Name = "lblscore";
            this.lblscore.Size = new System.Drawing.Size(0, 13);
            this.lblscore.TabIndex = 24;
            // 
            // btnmorabaa
            // 
            this.btnmorabaa.AutoSize = true;
            this.btnmorabaa.Enabled = false;
            this.btnmorabaa.Image = global::WindowsFormsApplication5.Properties.Resources.screenshot_20210627_192151;
            this.btnmorabaa.Location = new System.Drawing.Point(599, 384);
            this.btnmorabaa.Name = "btnmorabaa";
            this.btnmorabaa.Size = new System.Drawing.Size(56, 56);
            this.btnmorabaa.TabIndex = 16;
            this.btnmorabaa.UseVisualStyleBackColor = true;
            this.btnmorabaa.Visible = false;
            // 
            // btnmosalas
            // 
            this.btnmosalas.AutoSize = true;
            this.btnmosalas.Enabled = false;
            this.btnmosalas.Image = global::WindowsFormsApplication5.Properties.Resources.screenshot_20210627_192633;
            this.btnmosalas.Location = new System.Drawing.Point(599, 384);
            this.btnmosalas.Name = "btnmosalas";
            this.btnmosalas.Size = new System.Drawing.Size(56, 59);
            this.btnmosalas.TabIndex = 15;
            this.btnmosalas.UseVisualStyleBackColor = true;
            this.btnmosalas.Visible = false;
            // 
            // btndayere
            // 
            this.btndayere.Enabled = false;
            this.btndayere.Image = global::WindowsFormsApplication5.Properties.Resources.screenshot_20210627_192120;
            this.btndayere.Location = new System.Drawing.Point(602, 389);
            this.btndayere.Name = "btndayere";
            this.btndayere.Size = new System.Drawing.Size(53, 52);
            this.btndayere.TabIndex = 14;
            this.btndayere.UseVisualStyleBackColor = true;
            this.btndayere.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 469);
            this.Controls.Add(this.lblscore);
            this.Controls.Add(this.lblcolor);
            this.Controls.Add(this.lblshape);
            this.Controls.Add(this.lblstatus);
            this.Controls.Add(this.btndisconect);
            this.Controls.Add(this.cmbportname);
            this.Controls.Add(this.btnconectt);
            this.Controls.Add(this.btnplay);
            this.Controls.Add(this.btnmorabaa);
            this.Controls.Add(this.btnmosalas);
            this.Controls.Add(this.btndayere);
            this.Controls.Add(this.lblprop);
            this.Controls.Add(this.btnconect);
            this.Controls.Add(this.tbnum);
            this.Controls.Add(this.tbip);
            this.Controls.Add(this.lblnum);
            this.Controls.Add(this.lblip);
            this.Name = "Form1";
            this.Text = "Server";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblprop;
        private System.Windows.Forms.Button btnconect;
        private System.Windows.Forms.TextBox tbnum;
        private System.Windows.Forms.TextBox tbip;
        private System.Windows.Forms.Label lblnum;
        private System.Windows.Forms.Label lblip;
        private System.Windows.Forms.Label lblcolor;
        private System.Windows.Forms.Label lblshape;
        private System.Windows.Forms.Label lblstatus;
        private System.Windows.Forms.Button btndisconect;
        private System.Windows.Forms.ComboBox cmbportname;
        private System.Windows.Forms.Button btnconectt;
        private System.Windows.Forms.Button btnplay;
        private System.Windows.Forms.Button btnmorabaa;
        private System.Windows.Forms.Button btnmosalas;
        private System.Windows.Forms.Button btndayere;
        private System.Windows.Forms.Timer tstart;
        private System.Windows.Forms.Timer tshow;
        private System.IO.Ports.SerialPort Myserialport;
        private System.Windows.Forms.Label lblscore;
    }
}

