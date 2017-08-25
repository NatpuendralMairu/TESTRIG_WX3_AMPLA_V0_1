using System;
using System.Windows.Forms;

namespace TESTRIG_WX3_AMPLA_V0_1
{
    public partial class TestRig : MetroFramework.Forms.MetroForm
    {
        IRRADIANCE GetIRRADIANCE;
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
        public void lang_Eng()
        {
            btnDAQ.Text = "D.A.Q TEST";
            btnIR.Text = "IRRADIANCE TEST";
            btnWebCam_Capture.Text = " CAPTURE \n SNAPSHOTS";
            btnImageRecognition.Text = "IMAGE RECOGNITION \n(Offline Version)";
        }
        #endregion

        #region PORTUGUESE LANGUAGE
        public void lang_Portuguese()
        {
            btnDAQ.Text = "TESTE DE \nD.A.Q";
            btnIR.Text = "TEST DE \nIRRADIÂNCIA";
            btnWebCam_Capture.Text = "CAPTURAR \nIMAGEM";
            btnImageRecognition.Text = "RECONHECIMENTO DE\nIMAGEM (Versão Offline)";
        }
        #endregion

        #region LANGUAGE SELECTION COMBO BOX
        public void cmbBoxLanguage_SelectedIndexChanged(object sender, EventArgs e)
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
        DAQ GetDAQ;
        private void btnDAQ_Click(object sender, EventArgs e)
        {
            if (GetDAQ == null)
            {
                GetDAQ = new DAQ();
                GetDAQ.FormClosed += new FormClosedEventHandler(GetDAQ_FormClosed);
                GetDAQ.Show();
            }
            else
            {
                GetDAQ.Activate(); // Avoids opening of Multiple Instances of DAQ Window
                switch(cmbBoxLanguage.SelectedIndex)
                {
                case 0:
                        MessageBox.Show("The 'D.A.Q TEST' window is already open!");
                        break;
                case 1:
                        MessageBox.Show("A janela 'D.A.Q TEST' já está aberta!");
                        break;
                }
            }
        }

        private void GetDAQ_FormClosed(object sender, FormClosedEventArgs e)
        {
            GetDAQ = null;
        }
        #endregion

        #region IRRADIANCE BUTTON IMPLEMENTATION
        public void btnIR_Click(object sender, EventArgs e)
        {
         if (GetIRRADIANCE == null)
            {
                GetIRRADIANCE = new IRRADIANCE();
                GetIRRADIANCE.FormClosed += new FormClosedEventHandler(GetIRRADIANCE_FormClosed);
                GetIRRADIANCE.Show();
            }
            else
            {
                GetIRRADIANCE.Activate();
                switch (cmbBoxLanguage.SelectedIndex)
                {
                    case 0:
                        MessageBox.Show("The 'IRRADIANCE TEST' window is already open!");
                        break;
                    case 1:
                        MessageBox.Show("A janela 'TESTE DE IRRADIÂNCIA' já está aberta!");
                        break;
                }
            }
        }
        
        private void GetIRRADIANCE_FormClosed(object sender, FormClosedEventArgs e)
        {
            GetIRRADIANCE = null;
        }
        #endregion
    }
}
