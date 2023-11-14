namespace WindowsFormsApplication1
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
            this.btnconect = new System.Windows.Forms.Button();
            this.btndisconect = new System.Windows.Forms.Button();
            this.btnsent = new System.Windows.Forms.Button();
            this.nupNum = new System.Windows.Forms.NumericUpDown();
            this.lblstatus = new System.Windows.Forms.Label();
            this.rtbRecieve = new System.Windows.Forms.RichTextBox();
            this.cmbportname = new System.Windows.Forms.ComboBox();
            this.Myserialport = new System.IO.Ports.SerialPort(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nupNum)).BeginInit();
            this.SuspendLayout();
            // 
            // btnconect
            // 
            this.btnconect.Location = new System.Drawing.Point(60, 40);
            this.btnconect.Name = "btnconect";
            this.btnconect.Size = new System.Drawing.Size(75, 23);
            this.btnconect.TabIndex = 0;
            this.btnconect.Text = "conect";
            this.btnconect.UseVisualStyleBackColor = true;
            this.btnconect.Click += new System.EventHandler(this.btnconect_Click);
            // 
            // btndisconect
            // 
            this.btndisconect.Location = new System.Drawing.Point(60, 69);
            this.btndisconect.Name = "btndisconect";
            this.btndisconect.Size = new System.Drawing.Size(75, 23);
            this.btndisconect.TabIndex = 1;
            this.btndisconect.Text = "disconect";
            this.btndisconect.UseVisualStyleBackColor = true;
            this.btndisconect.Click += new System.EventHandler(this.btndisconect_Click);
            // 
            // btnsent
            // 
            this.btnsent.Location = new System.Drawing.Point(197, 120);
            this.btnsent.Name = "btnsent";
            this.btnsent.Size = new System.Drawing.Size(75, 23);
            this.btnsent.TabIndex = 2;
            this.btnsent.Text = "sent";
            this.btnsent.UseVisualStyleBackColor = true;
            this.btnsent.Click += new System.EventHandler(this.btnsent_Click);
            // 
            // nupNum
            // 
            this.nupNum.Location = new System.Drawing.Point(48, 122);
            this.nupNum.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nupNum.Name = "nupNum";
            this.nupNum.Size = new System.Drawing.Size(120, 20);
            this.nupNum.TabIndex = 3;
            // 
            // lblstatus
            // 
            this.lblstatus.AutoSize = true;
            this.lblstatus.Location = new System.Drawing.Point(159, 79);
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(0, 13);
            this.lblstatus.TabIndex = 4;
            // 
            // rtbRecieve
            // 
            this.rtbRecieve.Location = new System.Drawing.Point(48, 153);
            this.rtbRecieve.Name = "rtbRecieve";
            this.rtbRecieve.Size = new System.Drawing.Size(100, 96);
            this.rtbRecieve.TabIndex = 5;
            this.rtbRecieve.Text = "";
            // 
            // cmbportname
            // 
            this.cmbportname.FormattingEnabled = true;
            this.cmbportname.Location = new System.Drawing.Point(141, 40);
            this.cmbportname.Name = "cmbportname";
            this.cmbportname.Size = new System.Drawing.Size(121, 21);
            this.cmbportname.TabIndex = 6;
            // 
            // Myserialport
            // 
            this.Myserialport.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.Myserialport_DataReceived);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.cmbportname);
            this.Controls.Add(this.rtbRecieve);
            this.Controls.Add(this.lblstatus);
            this.Controls.Add(this.nupNum);
            this.Controls.Add(this.btnsent);
            this.Controls.Add(this.btndisconect);
            this.Controls.Add(this.btnconect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.nupNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnconect;
        private System.Windows.Forms.Button btndisconect;
        private System.Windows.Forms.Button btnsent;
        private System.Windows.Forms.NumericUpDown nupNum;
        private System.Windows.Forms.Label lblstatus;
        private System.Windows.Forms.RichTextBox rtbRecieve;
        private System.Windows.Forms.ComboBox cmbportname;
        private System.IO.Ports.SerialPort Myserialport;
    }
}

