using System;
using rtChart;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Thorlabs.PM100D;

namespace TESTRIG_WX3_AMPLA_V0_1
{
    public partial class IRRADIANCE : MetroFramework.Forms.MetroForm
    {
        #region LOCAL VARIABLES
        private PM100D pm100d;
        static Timer myTimer = new Timer();
        double factor = 1000D;
        double powerValue = 0D;               // Power
        double sens_Area = 1.27D;             // Sensor Area
        double IRValue = 0D;                  // Power/Sensor Area
        double power = 0D;
        double irdata = 0D;
        //double tempValue = 0D;
        double wavelength = 780;
        kayChart IRdataChart;
        #endregion

        public IRRADIANCE()
        {
            InitializeComponent();

            // Initializing the Device PM 400 with Address: 'USB0::0x1313::0x8075::P5000256::INSTR'
            try
            {
                pm100d = new PM100D("USB0::0x1313::0x8075::P5000256::INSTR", true, false);  //  For valid Ressource_Name see NI-Visa documentation.

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

        #region START BUTTON IMPLEMENTATION
        private void btnIR_Start_Click(object sender, EventArgs e)
        {
            pm100d = new PM100D("USB0::0x1313::0x8075::P5000256::INSTR",true, false);  //  For valid Ressource_Name see NI-Visa documentation.
            timer1.Enabled = true;
            btnIR_Start.Enabled = false;
            btnIR_Stop.Enabled = true;
        }
        #endregion

        #region STOP BUTTON IMPLEMENTATION
        private void btnIR_Stop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;                             // Disable Timer to stop capture
            btnIR_Start.Enabled = true;                         // Enable Start button
            btnIR_Stop.Enabled = false;                         // Disable the Stop button
            if (pm100d != null)
                pm100d.Dispose();                               // Free the memory 
            this.Close();                                       // Close the Window
        }
        #endregion

        #region TIMER EVENT UPDATING ALL VALUES
        private void timer1_Tick(object sender, EventArgs e)
        {
            pm100d.setWavelength(wavelength);
            lblIR_Timer.Text = DateTime.Now.ToString();
            List<string> strdata = new List<string>();

            pm100d.measPower(out powerValue);                           // Output the Power in Format: 'double'
            power = powerValue * factor;                                // Multiply the power with a factor of 1000 to convert to mW
            labelPower.Text = power.ToString();                         // Convert the double to string

            if (sens_Area > 0)
            {
                IRValue = power * sens_Area;
                labelIR.Text = IRValue.ToString();      
               
                string recvData = labelIR.Text;                         // Graphing Arrangement Starts here
                bool result = Double.TryParse(recvData, out irdata);
                if (result)
                {
                    IRdataChart.TriggeredUpdate(irdata);
                }
            }
            else
            {
                string ex = "Area Cannot be Zero";
                MessageBox.Show(ex);
            }

            strdata.Add(lblIR_Timer.Text);                              // [0] - Timer
            strdata.Add(labelPower.Text);                               // [1] - Power
            strdata.Add(labelIR.Text);                                  // [2] - Irradiance
            txtLogdata.Text += strdata[0] + ", P = " + strdata[1] + ", IR = " + strdata[2] +"\r\n";    // Format of Display in the Text Box

            if (chkIR_FileSave.Checked)
            {
                using (StreamWriter file = new StreamWriter(@"C:\Users\prajwal.nimmagadda\Desktop\Automation GitHub\Thorlabs_Data_Log\Power.txt", true))
                {
                    file.WriteLine(strdata[0]+"," + strdata[2] + "\n"); 
                }
            }
            else
            {

            }
        }
        #endregion

        private void IRRADIANCE_Load(object sender, EventArgs e)
        {
            IRdataChart = new kayChart(IRchart, 120);
            IRdataChart.serieName = "IRdata";
        }

        private void labelIR_TextChanged(object sender, EventArgs e)
        {
            txtLogdata.ScrollToCaret();
        }
    }
}
