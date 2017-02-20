using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Lab3Start
{
    public partial class Lab3Params : Form
    {
        public Lab3Params()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);

            if (DialogResult == DialogResult.OK)
            {
                var process = new Process
                {
                    StartInfo =
                    {
                          FileName = "Lab3Console.exe",
                          Arguments = string.Format("{0} {1} {2} {3} {4}", 
                                beginNumericUpDown.Value, endNumericUpDown.Value, countNumericUpDown.Value,
                                showNumbersCheckBox.Checked, createLogFileCheckBox.Checked)
                    }
                };
                process.Start();                
            }
            
        }
    }
}
