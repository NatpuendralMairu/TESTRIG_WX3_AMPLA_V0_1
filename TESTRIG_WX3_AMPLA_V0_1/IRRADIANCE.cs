using System;
using rtChart;
using System.IO;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Thorlabs.PM100D;

namespace TESTRIG_WX3_AMPLA_V0_1
{
    public partial class IRRADIANCE : MetroFramework.Forms.MetroForm
    {
        #region LOCAL VARIABLES
        private Thorlabs.PM100D.PM100D pm100d;
        static Timer myTimer = new Timer();
        double factor = 1000D;
        double powerValue = 0D;                 // Power
        double sens_Area = 1.27D;                  // Sensor Area
        double IRValue = 0D;                    // Power/Sensor Area
        double power = 0D;
        //double tempValue = 0D;
        double wavelength = 780;
        #endregion

        public IRRADIANCE()
        {
            InitializeComponent();
            // Initializing the Device PM 400 with Address: 'USB0::0x1313::0x8075::P5000256::INSTR'
            try
            {
                pm100d = new PM100D("USB0::0x1313::0x8075::P5000256::INSTR", true, true);  //  For valid Ressource_Name see NI-Visa documentation.

            }

            catch (BadImageFormatException bie)
            {
                labelPower.Text = bie.Message;
            }
            catch (NullReferenceException nre)
            {
                labelPower.Text = nre.Message;
            }
            catch (ExternalException ex)
            {
                labelPower.Text = ex.Message;
            }
            finally
            {
                if (pm100d != null)
                    pm100d.Dispose();
            }
        }

        #region SAVE FILE CHECKBOX UNCHECKED
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
        #endregion

        #region START/STOP BUTTON IMPLEMENTATION
        private void btnIR_StartStop_Click(object sender, EventArgs e)
        {
            pm100d = new Thorlabs.PM100D.PM100D("USB0::0x1313::0x8075::P5000256::INSTR", true, true);  //  For valid Ressource_Name see NI-Visa documentation.
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
        #endregion

        #region TIMER EVENT UPDATING ALL VALUES
        private void timer1_Tick(object sender, EventArgs e)
        {
            pm100d.setWavelength(wavelength);
            lblIR_Timer.Text = DateTime.Now.ToString();
            List<string> strdata = new List<string>();

            pm100d.measPower(out powerValue);           // Output the Power in Format: 'double'
            power = powerValue * factor;
            labelPower.Text = power.ToString();    // Convert the double to string

            if (sens_Area > 0)
            {
                IRValue = power * sens_Area;
                labelIR.Text = IRValue.ToString();
            }
            else
            {
                string ex = "Area Cannot be Zero";
                MessageBox.Show(ex);
            }
            //pm100d.measEmmTemperature(out tempValue);   // Output the Temperature in Format: 'double'
            //labelTemp.Text = tempValue.ToString();      // Convert the double to string

            strdata.Add(lblIR_Timer.Text);  // [0]
            strdata.Add(labelPower.Text);   // [1]
            strdata.Add(labelIR.Text);  // [2]

            txtLogdata.Text += strdata[0] + ", P = " + strdata[1] + ", IR = " + strdata[2] + "\r\n";

            // Update Chart
            GraphTemp();

            if (chkIR_FileSave.Checked)
            {
                using (StreamWriter file = new StreamWriter(@"C:\Users\prajwal.nimmagadda\Desktop\Automation GitHub\Thorlabs_Data_Log\Power.txt", true))
                {
                    file.WriteLine(strdata[0] + ", P = " + strdata[1] + ", IR = " + strdata[2] + "\n");
                }
            }
            else
            {

            }
        }
        #endregion

        public void GraphTemp()
        {
            kayChart tempData = new kayChart(tempChart, 120);
            //tempData.serieName = "TEMPERATURE";

            Task.Factory.StartNew(() =>
            {
                tempData.updateChart(updatePower,5000);
            }
            );
        }

        private double updatePower()
        {
            double POWER = double.Parse(labelIR.Text);
            return POWER;
        }
    }
}
