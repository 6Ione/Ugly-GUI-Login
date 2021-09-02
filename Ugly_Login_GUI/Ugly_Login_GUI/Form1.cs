using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ugly_Login_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            WebClient wc = new WebClient();
            string name = wc.DownloadString("https://pastebin.com/raw/JMNLkf56");
            string pass = wc.DownloadString("https://pastebin.com/raw/xD9kkD0G");

            if (name.Contains(textBox1.Text) && pass.Contains(pass))
            {
                Main main = new Main();
                main.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Login failed!");
            }
        }
    }
}
