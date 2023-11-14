using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Myserialport.BaudRate = 9600;
            Myserialport.DataBits = 8;
            Myserialport.StopBits = StopBits.One;
            Myserialport.Parity = Parity.None;
            Myserialport.Handshake = Handshake.None;
            Myserialport.ReadTimeout = 5000;
            Myserialport.WriteTimeout = 5000;
            System.Text.ASCIIEncoding ascii = new System.Text.ASCIIEncoding();
            Myserialport.Encoding = ascii;
            string[] portname = SerialPort.GetPortNames();
            Array.Sort(portname);
            cmbportname.Items.AddRange(portname);
            cmbportname.Text = portname[0];
            nupNum.Enabled = false;
            btndisconect.Enabled = false;
            lblstatus.Text = "waiting for conecting..";
            btnsent.Enabled = false;
            CheckForIllegalCrossThreadCalls = false;

        }

        private void btnconect_Click(object sender, EventArgs e)
        {
          try
          {
              Myserialport.PortName = cmbportname.Text;
              Myserialport.Open();
              cmbportname.Enabled = false;
              btnsent.Enabled = true;
              btndisconect.Enabled = true;
              btnconect.Enabled = false;
              nupNum.Enabled = true;
              lblstatus.Text = "conected";
          }
          catch(Exception ex)
          {
              lblstatus.Text = ex.Message;
          }
        }

        private void btndisconect_Click(object sender, EventArgs e)
        {
            Myserialport.Close();
            cmbportname.Enabled = true;
            btnsent.Enabled = false;
            btndisconect.Enabled = false;
            btnconect.Enabled = true;
            lblstatus.Text = "waiting for conecting..";
            nupNum.Enabled = false;
        }

        private void btnsent_Click(object sender, EventArgs e)
        {
            Myserialport.WriteLine(nupNum.Value.ToString());
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Myserialport.IsOpen)
            {
                Myserialport.Close();
            }
        }

        private void Myserialport_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            rtbRecieve.Text += Myserialport.ReadLine() + "\n";
        }
    }
}
