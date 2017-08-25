using System;
using rtChart;
using System.IO;
using HtmlAgilityPack;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace TESTRIG_WX3_AMPLA_V0_1
{
    public partial class DAQ : MetroFramework.Forms.MetroForm
    {
        #region LOCAL VARIABLES
        kayChart TempChart;
        TestRig testrig = new TestRig();
        string html = "http://10.1.4.252/cgi-bin/ope/allch.cgi";    // Place where DAQ data is updated to
        HtmlWeb daqWeb = new HtmlWeb();

        List<string> tempData = new List<string>();                 // Temperature Data Array
        #endregion

        public DAQ()
        {
            InitializeComponent();
        }

        private void DAQ_Load(object sender, EventArgs e)
        {
            // Update the Graph every time, when a new value is available in the box 
            TempChart = new kayChart(ChrtTemp, 120);
            TempChart.serieName = "Temperature";
        }

        #region START BUTTON IMPLEMENTATION
        private void btnDaqStart_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == false)
            {
                btnDaqStart.Enabled = false;                            // Disable the Start button
                btnDaqStop.Enabled = true;                              // Enable the Stop button
                chkDAQ_SaveFIle.Enabled = false;                        // Deactivate the checkbox functionality
                timer1.Enabled = true;
            }
        }
        #endregion

        #region STOP BUTTON IMPLEMENTATION
        private void btnDaqStop_Click(object sender, EventArgs e)
        {
            btnDaqStart.Enabled = true;
            btnDaqStop.Enabled = false;
            chkDAQ_SaveFIle.Enabled = true;
            timer1.Enabled = false;
            this.Close();
        }
        #endregion

        #region CHECKBOX UNCHECKED IMPLEMENTATION
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
        #endregion

        #region TIMER EVENT UPDATING ALL VALUES
        private void timer1_Tick(object sender, EventArgs e)
        {
            // Update Timer Label
            lblDaqTimer.Text = DateTime.Now.ToString();

            // Update Website
            try
            {
                if (WebBrwsr.IsOffline)
                {
                    foreach (HtmlElement elem in WebBrwsr.Document.GetElementsByTagName("input"))
                    {
                        if (elem.GetAttribute("value") == "Refresh")
                        {
                            elem.InvokeMember("click");
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Refresh Exception!!");
            }
            // Get the updated Values into the labels
            tempGetClean();



            // Saving to File
            //if (chkDAQ_SaveFIle.Checked)
            //{
            //    using (StreamWriter file = new StreamWriter(@"C:\Users\prajwal.nimmagadda\Desktop\Automation GitHub\Thorlabs_Data_Log\Power.txt", true))
            //    {
            //        file.WriteLine(tempData[0] + "," + tempData[2] + "\n");
            //    }
            //}
            //else
            //{

            //}
        }
        #endregion
        
        #region GET CLEAN SPLIT THE TABLE DATA FROM WEBSITE INTO LABELS
        private void tempGetClean()
        {
            var htmlDoc = daqWeb.Load(html);
            // Temp Nodes
            var tempNode1 = htmlDoc.DocumentNode.SelectNodes("//body//table[2]//tr[2]")[1].InnerText;
            var tempNode2 = htmlDoc.DocumentNode.SelectNodes("//body//table[2]//tr[3]")[0].InnerText;   // XPath: /html/body/table[2]/tbody/tr[3]/td[3]/font/b
            var tempNode3 = htmlDoc.DocumentNode.SelectNodes("//body//table[2]//tr[4]")[0].InnerText;   // XPath: /html/body/table[2]/tbody/tr[4]/td[3]/font/b
            var tempNode4 = htmlDoc.DocumentNode.SelectNodes("//body//table[2]//tr[5]")[0].InnerText;   // XPath: /html/body/table[2]/tbody/tr[5]/td[3]/font/b
            var tempNode5 = htmlDoc.DocumentNode.SelectNodes("//body//table[2]//tr[6]")[0].InnerText;   // XPath: /html/body/table[2]/tbody/tr[6]/td[3]/font/b
            var tempNode6 = htmlDoc.DocumentNode.SelectNodes("//body//table[2]//tr[7]")[0].InnerText;   // XPath: /html/body/table[2]/tbody/tr[7]/td[3]/font/b
            var tempNode7 = htmlDoc.DocumentNode.SelectNodes("//body//table[2]//tr[8]")[0].InnerText;   // XPath: /html/body/table[2]/tbody/tr[8]/td[3]/font/b
            var tempNode8 = htmlDoc.DocumentNode.SelectNodes("//body//table[2]//tr[9]")[0].InnerText;   // XPath: /html/body/table[2]/tbody/tr[9]/td[3]/font/b
            var tempNode9 = htmlDoc.DocumentNode.SelectNodes("//body//table[2]//tr[10]")[0].InnerText;  // XPath: /html/body/table[2]/tbody/tr[10]/td[3]/font/b
            var tempNode10 = htmlDoc.DocumentNode.SelectNodes("//body//table[2]//tr[11]")[0].InnerText;  // XPath: /html/body/table[2]/tbody/tr[11]/td[3]/font/b

            // Convert white spaces to Single white space
            string clTemp1 = ConvertWhitespacesToSingleSpaces(tempNode1);
            string clTemp2 = ConvertWhitespacesToSingleSpaces(tempNode2);
            string clTemp3 = ConvertWhitespacesToSingleSpaces(tempNode3);
            string clTemp4 = ConvertWhitespacesToSingleSpaces(tempNode4);
            string clTemp5 = ConvertWhitespacesToSingleSpaces(tempNode5);
            string clTemp6 = ConvertWhitespacesToSingleSpaces(tempNode6);
            string clTemp7 = ConvertWhitespacesToSingleSpaces(tempNode7);
            string clTemp8 = ConvertWhitespacesToSingleSpaces(tempNode8);
            string clTemp9 = ConvertWhitespacesToSingleSpaces(tempNode9);
            string clTemp10 = ConvertWhitespacesToSingleSpaces(tempNode10);

            // Split and save just the temperature
            lblTemp1.Text = clTemp1.Split(' ')[1];
            lblTemp2.Text = clTemp2.Split(' ')[1];
            lblTemp3.Text = clTemp3.Split(' ')[1];
            lblTemp4.Text = clTemp4.Split(' ')[1];
            lblTemp5.Text = clTemp5.Split(' ')[1];
            lblTemp6.Text = clTemp6.Split(' ')[1];
            lblTemp7.Text = clTemp7.Split(' ')[1];
            lblTemp8.Text = clTemp8.Split(' ')[1];
            lblTemp9.Text = clTemp9.Split(' ')[1];
            lblTemp10.Text = clTemp10.Split(' ')[1];
        }
        #endregion

        #region CONVERT MULTIPLE WHITE SPACE TO SINGLE SPACE
        public static string ConvertWhitespacesToSingleSpaces(string value)
        {
            value = Regex.Replace(value, @"\s+", " ");
            return value;
        }
        #endregion
    }
}
