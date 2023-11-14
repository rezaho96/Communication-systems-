using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace WindowsFormsApplication4
{
    
    public partial class Form1 : Form
    {
        Socket cl;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnconect_Click(object sender, EventArgs e)
        {
            cl = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                cl.Connect(IPAddress.Parse(tbip.Text), Convert.ToInt32(tbnum.Text));
      
            }
            catch (SocketException err)
            {
                
                MessageBox.Show(err.Message);
            }
             }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] buffer = new byte[500];
                cl.Receive(buffer);
                string str = System.Text.UTF8Encoding.UTF8.GetString(buffer);
                tbrecieve.Text = "\n" + str;
            }
            catch (SocketException err)
            {

                MessageBox.Show(err.Message);
            }
        }
    }
}
