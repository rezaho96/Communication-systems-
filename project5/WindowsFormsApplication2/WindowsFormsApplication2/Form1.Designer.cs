namespace WindowsFormsApplication2
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
            this.btnmorabaa = new System.Windows.Forms.Button();
            this.tstart = new System.Windows.Forms.Timer(this.components);
            this.tshow = new System.Windows.Forms.Timer(this.components);
            this.btnplay = new System.Windows.Forms.Button();
            this.cmbportname = new System.Windows.Forms.ComboBox();
            this.btnconect = new System.Windows.Forms.Button();
            this.Myserialport = new System.IO.Ports.SerialPort(this.components);
            this.lblstatus = new System.Windows.Forms.Label();
            this.btndisconect = new System.Windows.Forms.Button();
            this.lblshape = new System.Windows.Forms.Label();
            this.lblcolor = new System.Windows.Forms.Label();
            this.btnmosalas = new System.Windows.Forms.Button();
            this.btndayere = new System.Windows.Forms.Button();
            this.lblscore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnmorabaa
            // 
            this.btnmorabaa.AutoSize = true;
            this.btnmorabaa.Enabled = false;
            this.btnmorabaa.Image = global::WindowsFormsApplication2.Properties.Resources.screenshot_20210627_192151;
            this.btnmorabaa.Location = new System.Drawing.Point(443, 267);
            this.btnmorabaa.Name = "btnmorabaa";
            this.btnmorabaa.Size = new System.Drawing.Size(56, 56);
            this.btnmorabaa.TabIndex = 2;
            this.btnmorabaa.UseVisualStyleBackColor = true;
            this.btnmorabaa.Visible = false;
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
            // btnplay
            // 
            this.btnplay.Enabled = false;
            this.btnplay.Location = new System.Drawing.Point(124, 270);
            this.btnplay.Name = "btnplay";
            this.btnplay.Size = new System.Drawing.Size(75, 25);
            this.btnplay.TabIndex = 3;
            this.btnplay.Text = "play";
            this.btnplay.UseVisualStyleBackColor = true;
            this.btnplay.Click += new System.EventHandler(this.btnplay_Click);
            // 
            // cmbportname
            // 
            this.cmbportname.FormattingEnabled = true;
            this.cmbportname.Location = new System.Drawing.Point(124, 39);
            this.cmbportname.Name = "cmbportname";
            this.cmbportname.Size = new System.Drawing.Size(121, 21);
            this.cmbportname.TabIndex = 8;
            // 
            // btnconect
            // 
            this.btnconect.Location = new System.Drawing.Point(43, 39);
            this.btnconect.Name = "btnconect";
            this.btnconect.Size = new System.Drawing.Size(75, 23);
            this.btnconect.TabIndex = 7;
            this.btnconect.Text = "conect";
            this.btnconect.UseVisualStyleBackColor = true;
            this.btnconect.Click += new System.EventHandler(this.btnconect_Click);
            // 
            // Myserialport
            // 
            this.Myserialport.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.Myserialport_DataReceived);
            // 
            // lblstatus
            // 
            this.lblstatus.AutoSize = true;
            this.lblstatus.Location = new System.Drawing.Point(142, 78);
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(0, 13);
            this.lblstatus.TabIndex = 10;
            // 
            // btndisconect
            // 
            this.btndisconect.Location = new System.Drawing.Point(43, 68);
            this.btndisconect.Name = "btndisconect";
            this.btndisconect.Size = new System.Drawing.Size(75, 23);
            this.btndisconect.TabIndex = 9;
            this.btndisconect.Text = "disconect";
            this.btndisconect.UseVisualStyleBackColor = true;
            this.btndisconect.Click += new System.EventHandler(this.btndisconect_Click);
            // 
            // lblshape
            // 
            this.lblshape.AutoSize = true;
            this.lblshape.Location = new System.Drawing.Point(502, 243);
            this.lblshape.Name = "lblshape";
            this.lblshape.Size = new System.Drawing.Size(30, 13);
            this.lblshape.TabIndex = 11;
            this.lblshape.Text = "شکل";
            // 
            // lblcolor
            // 
            this.lblcolor.AutoSize = true;
            this.lblcolor.Enabled = false;
            this.lblcolor.Location = new System.Drawing.Point(443, 270);
            this.lblcolor.Name = "lblcolor";
            this.lblcolor.Size = new System.Drawing.Size(23, 13);
            this.lblcolor.TabIndex = 12;
            this.lblcolor.Text = "رنگ";
            // 
            // btnmosalas
            // 
            this.btnmosalas.AutoSize = true;
            this.btnmosalas.Enabled = false;
            this.btnmosalas.Image = global::WindowsFormsApplication2.Properties.Resources.screenshot_20210627_192633;
            this.btnmosalas.Location = new System.Drawing.Point(443, 266);
            this.btnmosalas.Name = "btnmosalas";
            this.btnmosalas.Size = new System.Drawing.Size(56, 59);
            this.btnmosalas.TabIndex = 1;
            this.btnmosalas.UseVisualStyleBackColor = true;
            this.btnmosalas.Visible = false;
            // 
            // btndayere
            // 
            this.btndayere.BackgroundImage = global::WindowsFormsApplication2.Properties.Resources.screenshot_20210627_192120;
            this.btndayere.Enabled = false;
            this.btndayere.Location = new System.Drawing.Point(446, 266);
            this.btndayere.Name = "btndayere";
            this.btndayere.Size = new System.Drawing.Size(53, 52);
            this.btndayere.TabIndex = 0;
            this.btndayere.UseVisualStyleBackColor = true;
            this.btndayere.Visible = false;
            // 
            // lblscore
            // 
            this.lblscore.AutoSize = true;
            this.lblscore.Location = new System.Drawing.Point(0, 0);
            this.lblscore.Name = "lblscore";
            this.lblscore.Size = new System.Drawing.Size(0, 13);
            this.lblscore.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 379);
            this.Controls.Add(this.lblscore);
            this.Controls.Add(this.lblcolor);
            this.Controls.Add(this.lblshape);
            this.Controls.Add(this.lblstatus);
            this.Controls.Add(this.btndisconect);
            this.Controls.Add(this.cmbportname);
            this.Controls.Add(this.btnconect);
            this.Controls.Add(this.btnplay);
            this.Controls.Add(this.btnmorabaa);
            this.Controls.Add(this.btnmosalas);
            this.Controls.Add(this.btndayere);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btndayere;
        private System.Windows.Forms.Button btnmosalas;
        private System.Windows.Forms.Button btnmorabaa;
        private System.Windows.Forms.Timer tstart;
        private System.Windows.Forms.Timer tshow;
        private System.Windows.Forms.Button btnplay;
        private System.Windows.Forms.ComboBox cmbportname;
        private System.Windows.Forms.Button btnconect;
        private System.IO.Ports.SerialPort Myserialport;
        private System.Windows.Forms.Label lblstatus;
        private System.Windows.Forms.Button btndisconect;
        private System.Windows.Forms.Label lblshape;
        private System.Windows.Forms.Label lblcolor;
        private System.Windows.Forms.Label lblscore;

    }
}

