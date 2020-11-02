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
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;
            string name_pass = username + ":" + password;

            if (username == "" && password == "")
            {
                MessageBox.Show(@"ERROR: No fields filled in.");
                this.Close();
            }
            if (password == "")
            {
                MessageBox.Show(@"ERROR: Password Field not filled in.");
                this.Close();
            }

            if (username == "")
            {
                MessageBox.Show(@"ERROR: Username Field not filled in.");
                this.Close();
            }

            WebClient webClient = new WebClient();

            bool name_pass_fromweb = webClient.DownloadString("https://pastebin.com/raw/N4FNVgQG").Contains(name_pass);
            if (name_pass_fromweb)
            {
                this.Hide();

                Panel panel = new Panel();
                panel.Show();
            }
            else
            {

                MessageBox.Show("Incorrect credentials.");

            }

        }
    }
}