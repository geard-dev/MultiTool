using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Memory;

namespace MultiTool
{
    public partial class MemoryEdit : Form
    {
        Memory.Mem memory = new Memory.Mem();

        public MemoryEdit()
        {
            InitializeComponent();
        }

        private void setButton_Click(object sender, EventArgs e)
        {
            string address = addressTextBox.Text;
            string value = valueTextBox.Text;
            string valuetype = typeTextBox.Text;
            string processname = processNameTextBox.Text;

            memory.OpenProcess(Process.GetProcessesByName(processname).FirstOrDefault().Id);
            memory.WriteMemory(address, valuetype, value);
        }
    }
}
