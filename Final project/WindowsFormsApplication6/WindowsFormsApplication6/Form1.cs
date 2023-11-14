using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace WindowsFormsApplication6
{
    public partial class Form1 : Form
    {
        Socket cl;
        Color c;
        public Form1()
        {
            InitializeComponent();
            c = BackColor;
        }

        private void btnconect_Click(object sender, EventArgs e)
        {
            cl = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                cl.Connect(IPAddress.Parse(tbip.Text), Convert.ToInt32(tbnum.Text));
                trecieve.Start();

            }
            catch (SocketException err)
            {

                MessageBox.Show(err.Message);
            }
        }

        private void trecieve_Tick(object sender, EventArgs e)
        {
            tbip.Visible = false;
            tbnum.Visible = false;
            btnconect.Visible = false;
            lblip.Visible = false;
            lblnum.Visible = false;
            string t;
            try
            {
                byte[] buffer = new byte[500];
                cl.Receive(buffer);
                string str = System.Text.UTF8Encoding.UTF8.GetString(buffer);
                lblrecieve.Text = str;
                t=lblrecieve.Text;
                switch (t[12].ToString())
                {
                    case "R": BackColor = Color.Red; break;
                    case "G": BackColor = Color.Green; break;
                    default:
                        break;
                }
                Thread.Sleep(500);
                BackColor = c;
            }
            catch (SocketException err)
            {

                MessageBox.Show(err.Message);
            }
        }
    }
}
