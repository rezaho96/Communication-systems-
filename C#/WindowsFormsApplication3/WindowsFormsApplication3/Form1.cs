using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        Socket sk;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnconect_Click(object sender, EventArgs e)
        {
            sk = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint iplocal = new IPEndPoint(IPAddress.Parse(tbip.Text), Convert.ToInt32(tbnum.Text));
            sk.Bind(iplocal);
            sk.Listen(10);
            sk = sk.Accept();
            lblprop.Text = "conect to:" + sk.RemoteEndPoint.ToString();
        }

        private void btnsend_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] msg = Encoding.UTF8.GetBytes(tbsend.Text);
                sk.Send(msg);
            }
            catch (SocketException err)
            {

                MessageBox.Show(err.Message);
            }
        }
    }
}
