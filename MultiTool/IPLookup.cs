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

namespace MultiTool
{
    public partial class IPLookup : Form
    {
        public IPLookup()
        {
            InitializeComponent();
        }

        private void searchIPButton_Click(object sender, EventArgs e)
        {
            string inputIPaddress = ipTextbox.Text;

            if (inputIPaddress == "")
            {
                MessageBox.Show(@"ERROR: No IP inputted.");
                this.Close();
            }

            WebClient webClient = new WebClient();

            string responce = webClient.DownloadString("http://ip-api.com/json/" + inputIPaddress);

            responceTextBox.Text = responce;
        }

        private void returnBtn_Click(object sender, EventArgs e)
        {
            this.Hide();

            Panel panel = new Panel();
            panel.Show();
        }
    }
}
