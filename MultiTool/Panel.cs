using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Memory;

namespace MultiTool
{
    public partial class Panel : Form
    {
        public Panel()
        {
            InitializeComponent();
        }

        private void editMemory_Click(object sender, EventArgs e)
        {
            this.Hide();

            MemoryEdit memEdit = new MemoryEdit();
            memEdit.Show();
        }

        private void lookupIP_Click(object sender, EventArgs e)
        {
            this.Hide();

            IPLookup ipLookup = new IPLookup();
            ipLookup.Show();
        }

        private void runPowershell_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("powershell.exe");
        }
    }
}
