using System;

namespace TESTRIG_WX3_AMPLA_V0_1
{
    public partial class TestRig : MetroFramework.Forms.MetroForm
    {
        public TestRig()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Default Language is Set to "English"
            cmbBoxLanguage.SelectedIndex = 1;
        }
        /// <summary>
        /// LANGUAGE SELECTION
        /// </summary>
        #region ENGLISH LANGUAGE
        private void lang_Eng()
        {
            btnDAQ.Text = "D.A.Q TEST";
            btnIR.Text = "IRRADIANCE TEST";
            btnWebCam_Capture.Text = " CAPTURE \n SNAPSHOTS";
            btnImageRecognition.Text = "IMAGE RECOGNITION \n(Offline Version)";
            return;
        }
        #endregion

        #region PORTUGUESE LANGUAGE
        private void lang_Portuguese()
        {
            btnDAQ.Text = "TESTE DE \nD.A.Q";
            btnIR.Text = "TEST DE \nIRRADIÂNCIA";
            btnWebCam_Capture.Text = "CAPTURAR \nIMAGEM";
            btnImageRecognition.Text = "RECONHECIMENTO DE\nIMAGEM (Versão Offline)";
            return;
        }
        #endregion

        #region LANGUAGE SELECTION COMBO BOX
        private void cmbBoxLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Cases for Combo box Selection
            switch (cmbBoxLanguage.SelectedIndex)
            {
                case 0:
                    lang_Eng();
                    break;
                case 1:
                    lang_Portuguese();
                    break;
            }
        }
        #endregion

        /// <summary>
        /// BUTTON'S IMPLEMENTATION
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        #region DAQ BUTTON IMPLEMENTATION
        private void btnDAQ_Click(object sender, EventArgs e)
        {
            DAQ daqfrm = new DAQ();
            daqfrm.Show();
        }
        #endregion

        #region IRRADIANCE BUTTON IMPLEMENTATION
        private void btnIR_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
