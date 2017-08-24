using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace TESTRIG_WX3_AMPLA_V0_1
{
    public partial class IRRADIANCE : MetroFramework.Forms.MetroForm
    {
        private Thorlabs.PM100D.PM100D pm100d;
        static Timer myTimer = new Timer();
        double powerValue;
        double wavelength = 780;

        public IRRADIANCE()
        {
            InitializeComponent();
        }

        private void chkIR_FileSave_CheckedChanged(object sender, EventArgs e)
        {
            if (chkIR_FileSave.Checked == false)
            {
                const string message = "Data WILL NOT be logged.\n Are you sure, you want to proceed?";
                const string caption = "Data Logging";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes) return;
            }
        }

        private void btnIR_StartStop_Click(object sender, EventArgs e)
        {
            pm100d = new Thorlabs.PM100D.PM100D("USB0::0x1313::0x8075::P5000256::INSTR", false, false);  //  For valid Ressource_Name see NI-Visa documentation.
            if (btnIR_StartStop.Text == "S.T.O.P")
            {
                btnIR_StartStop.Text = "S.T.A.R.T";
                timer1.Enabled = false;
            }
            else
            {
                btnIR_StartStop.Text = "S.T.O.P";
                timer1.Enabled = true;
            }
        }
    }
}
