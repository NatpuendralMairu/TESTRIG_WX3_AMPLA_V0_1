using System;
using rtChart;
using HtmlAgilityPack;
using System.Windows.Forms;

namespace TESTRIG_WX3_AMPLA_V0_1
{
    public partial class DAQ : MetroFramework.Forms.MetroForm
    {
        #region LOCAL VARIABLES
        kayChart TempChart;
        TestRig testrig = new TestRig();

        string html = "http://10.1.4.252/cgi-bin/ope/allch.cgi";    // Place where DAQ data is updated to
        HtmlWeb daqWeb = new HtmlWeb();
        #endregion

        public DAQ()
        {
            InitializeComponent();
        }

        private void DAQ_Load(object sender, EventArgs e)
        {
            // Update the Graph every, when a new value is available in the box 
            TempChart = new kayChart(ChrtTemp, 120);
            TempChart.serieName = "Temperature";
        }

        private void btnDaqStart_Click(object sender, EventArgs e)
        {
            btnDaqStart.Enabled = false;                            // Disable the Start button
            btnDaqStop.Enabled = true;                              // Enable the Stop button
            chkDAQ_SaveFIle.Enabled = false;                        // Deactivate the checkbox functionality
 
            MessageBox.Show("LOGIC IS CORRECT");
        }

        private void chkBxSaveTxt_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDAQ_SaveFIle.Checked == false)
            {
                const string message = "Data WILL NOT be logged.\n Are you sure, you want to proceed?";
                const string caption = "Data Logging";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes) return;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Update Website


            // Get the updated Values into the DataGridView
        }
    }
}
