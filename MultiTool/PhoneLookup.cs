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
    public partial class PhoneLookup : Form
    {
        public PhoneLookup()
        {
            InitializeComponent();
        }

        private void searchPhoneButton_Click(object sender, EventArgs e)
        {
            string inputPhoneNumber = phoneTextbox.Text;

            if (inputPhoneNumber == "")
            {
                MessageBox.Show(@"ERROR: No Phone Number inputted.");
                this.Close();
            }

            WebClient webClient = new WebClient();

            string responce = webClient.DownloadString("https://api.telnyx.com/anonymous/v2/number_lookup/" + inputPhoneNumber);

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
