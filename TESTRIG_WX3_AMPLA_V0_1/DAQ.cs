using System;
using System.Windows.Forms;

namespace TESTRIG_WX3_AMPLA_V0_1
{
    public partial class DAQ : MetroFramework.Forms.MetroForm
    {
        TestRig testrig = new TestRig();
        public DAQ()
        {
            InitializeComponent();
        }

        private void DAQ_Load(object sender, EventArgs e)
        {

        }

        private void btnDaqStartStop_Click(object sender, EventArgs e)
        {
            //btnDaqStartStop.Text = "START";
            // Update Website
            MessageBox.Show("LOGIC IS CORRECT");
            // Get the updated Values into the DataGridView

            // Default Checkbox status = TRUE

            // Update the Graph every, when a new value is available in the box 
        }

        private void chkBxSaveTxt_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBxSaveTxt.Checked == false)
            {
                const string message = "Data WILL NOT be logged.\n Are you sure, you want to proceed?";
                const string caption = "Data Logging";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes) return;
            }
        }
    }
}
