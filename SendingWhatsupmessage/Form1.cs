using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WhatsAppApi;

namespace SendingWhatsupmessage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string from = "7503065558";
            string to = textBox1.Text;
            string msg = textBox2.Text;
            WhatsApp wa = new WhatsApp(from, "adhajfhsdjhsdjg", "priya", false, false);
            wa.OnConnectSuccess += () =>
              {
                  MessageBox.Show("connected to whatsup");
                  wa.OnLoginSuccess += (phoneNumeber, data) =>
                  wa.SendMessage(to, msg);
                  MessageBox.Show("Message sent......");

              };
            wa.OnLoginFailed += (data) =>
              {
                  MessageBox.Show("Login failed...." + data);
              };
            wa.Login();
            
        }

       
    }
}
