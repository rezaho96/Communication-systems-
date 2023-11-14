using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.IO.Ports;
using System.Threading;

namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        Color c = new Color();
        Button b = new Button();
        Color c1 = new Color();
        Button b1 = new Button();
        Color c2 = new Color();
        int score, scoree;
        Socket sk;
        public Form1()
        {
            InitializeComponent();
            c2 = BackColor;
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
            btndisconect.Enabled = false;
            lblstatus.Text = "waiting for conecting..";
            CheckForIllegalCrossThreadCalls = false;
            Random rand = new Random();
            int randshape = rand.Next(1, 4), randcolor = rand.Next(1, 4);
            string rs = randshape.ToString(), rc = randcolor.ToString();
            switch (rs)
            {
                case "1": b = btndayere; break;
                case "2": b = btnmosalas; break;
                case "3": b = btnmorabaa; break;
            }
            switch (rc)
            {
                case "1": c = Color.Red; ; break;
                case "2": c = Color.Blue; break;
                case "3": c = Color.Green; break;
            }
            b.Visible = true;
            lblcolor.BackColor = c;
        }

        private void btnconectt_Click(object sender, EventArgs e)
        {
            try
            {
                Myserialport.PortName = cmbportname.Text;
                Myserialport.Open();
                cmbportname.Enabled = false;
                btndisconect.Enabled = true;
                btnconectt.Enabled = false;
                lblstatus.Text = "conected";
                btnplay.Enabled = true;
            }
            catch (Exception ex)
            {
                lblstatus.Text = ex.Message;
            }
        }

        private void btndisconect_Click(object sender, EventArgs e)
        {
            Myserialport.Close();
            cmbportname.Enabled = true;
            btndisconect.Enabled = false;
            btnconectt.Enabled = true;
            lblstatus.Text = "waiting for conecting..";
            btnplay.Enabled = false;
        }

        private void tshow_Tick(object sender, EventArgs e)
        {
            btndayere.Visible = false;
            btnmosalas.Visible = false;
            btnmorabaa.Visible = false;
            int a = (this.Size.Width) - 56, z = (this.Size.Height) - 56;
            Random loc = new Random();
            int r1 = loc.Next(a), r2 = loc.Next(z);
            Random rand = new Random();

            b1.Visible = false;
            lblcolor.Visible = false;
            int randshape = rand.Next(1, 4), randcolor = rand.Next(1, 4);
            string rs = randshape.ToString(), rc = randcolor.ToString();
            switch (rs)
            {
                case "1": b1 = btndayere; break;
                case "2": b1 = btnmosalas; break;
                case "3": b1 = btnmorabaa; break;
            }
            switch (rc)
            {
                case "1": c1 = Color.Red; ; break;
                case "2": c1 = Color.Blue; break;
                case "3": c1 = Color.Green; break;
            }
            b1.Location = new Point(r1, r2);
            lblcolor.Location = new Point(r1, r2);
            b1.Visible = true;
            lblcolor.BackColor = c1;
            lblcolor.Visible = true;
        }

        private void btnplay_Click(object sender, EventArgs e)
        {
            lblprop.Visible = false;
            btnconectt.Visible = false;
            btndisconect.Visible = false;
            cmbportname.Visible = false;
            btnplay.Visible = false;
            b.Visible = false;
            lblcolor.Visible = false;
            lblstatus.Visible = false;
            lblshape.Visible = false;
            tshow.Start();
            tstart.Start();
            lblscore.Visible = true;
        }

        private void tstart_Tick(object sender, EventArgs e)
        {
            tshow.Stop();
            b1.Visible = false;
            Random rand = new Random();
            int randshape = rand.Next(1, 4), randcolor = rand.Next(1, 4);
            string rs = randshape.ToString(), rc = randcolor.ToString();
            switch (rs)
            {
                case "1": b = btndayere; break;
                case "2": b = btnmosalas; break;
                case "3": b = btnmorabaa; break;
            }
            switch (rc)
            {
                case "1": c = Color.Red; ; break;
                case "2": c = Color.Blue; break;
                case "3": c = Color.Green; break;
            }
            b.Visible = true;
            lblcolor.BackColor = c;
            btnconectt.Visible = true;
            btndisconect.Visible = true;
            cmbportname.Visible = true;
            btnplay.Visible = true;
            b.Location = new Point(599, 384);
            lblcolor.Location = new Point(599, 389);
            b.Visible = true;
            lblcolor.Visible = true;
            lblstatus.Visible = true;
            lblshape.Visible = true;
            score = 0;
            scoree = 0;
            lblscore.Text = "";
            lblscore.Visible = false;
            lblprop.Visible = true;
        }

        private void Myserialport_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            int m = 1,n=0;
            if (b == b1 || c == c1)
            {
                
                BackColor = Color.Green;
                Myserialport.WriteLine(m.ToString());
                Thread.Sleep(500);
                scoree = scoree + 1;
                lblscore.Text = "score" + "\n" + "-" + score.ToString() + "\n" + "+" + scoree.ToString();
                Myserialport.WriteLine(n.ToString());
                try
                {
                    byte[] msg = Encoding.UTF8.GetBytes(lblscore.Text + "\n" + "Green");
                    sk.Send(msg);
                }
                catch (SocketException err)
                {

                    MessageBox.Show(err.Message);
                }
            }
            else if (b != b1 || c != c1)
            {
                
                BackColor = Color.Red;
                Thread.Sleep(500);
                score = score + 1;
                lblscore.Text = "score" + "\n" + "-" + score.ToString() + "\n" + "+" + scoree.ToString();
                try
                {
                    byte[] msg = Encoding.UTF8.GetBytes(lblscore.Text + "\n" + "RED");
                    sk.Send(msg);
                }
                catch (SocketException err)
                {

                    MessageBox.Show(err.Message);
                }
            }
            BackColor = c2;
            
        
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

            if (Myserialport.IsOpen)
            {
                Myserialport.Close();
            }
        }

        private void btnconect_Click(object sender, EventArgs e)
        {
            sk = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint iplocal = new IPEndPoint(IPAddress.Parse(tbip.Text), Convert.ToInt32(tbnum.Text));
            sk.Bind(iplocal);
            sk.Listen(10);
            sk = sk.Accept();
            lblprop.Text = "conect to:" + sk.RemoteEndPoint.ToString();
            btnconect.Visible = false;
            tbip.Visible = false;
            tbnum.Visible = false;
            lblip.Visible = false;
            lblnum.Visible = false;
            btnconectt.Enabled = true;
        }
    }
}
