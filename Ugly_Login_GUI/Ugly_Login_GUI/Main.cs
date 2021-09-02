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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            WebClient wc = new WebClient();
            string ip = wc.DownloadString("http://checkip.amazonaws.com/");
            MessageBox.Show($"IP: {ip}\nPC Name: {Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)}", "Goodbye!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
