using System;
using System.Windows.Forms;

namespace TESTRIG_WX3_AMPLA_V0_1
{
    public partial class TestRig : MetroFramework.Forms.MetroForm
    {
        #region INSTANCES OF THE CHILD WINDOWS (NOT USING MDI)
        IRRADIANCE GetIRRADIANCE;
        DAQ GetDAQ;
        WEBCAM GetWEBCAM;
        IMGRECOGNITION GetRECOGNIZED;
        #endregion

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

        #region CAPTURE SNAPSHOTS IMPLEMENTATION
        private void btnWebCam_Capture_Click(object sender, EventArgs e)
        {
            if (GetWEBCAM == null)
            {
                GetWEBCAM = new WEBCAM();
                GetWEBCAM.FormClosed += new FormClosedEventHandler(GetWEBCAM_FormClosed);
                //GetWEBCAM.Show();
                MessageBox.Show("Code needs cleaning!");
            }
            else
            {
                GetWEBCAM.Activate();
                switch (cmbBoxLanguage.SelectedIndex)
                {
                    case 0:
                        MessageBox.Show("The 'CAPTURE SNAPSHOTS' window is already open!");
                        break;
                    case 1:
                        MessageBox.Show("A janela 'CATURAR IMAGENS' já está aberta!");
                        break;
                }
            }
        }
        
        private void GetWEBCAM_FormClosed(object sender, FormClosedEventArgs e)
        {
            GetWEBCAM = null;
        }
        #endregion

        #region IMAGE RECOGNITION IMPLEMENTATION
        private void btnImageRecognition_Click(object sender, EventArgs e)
        {
            if (GetRECOGNIZED == null)
            {
                GetRECOGNIZED = new IMGRECOGNITION();
                GetRECOGNIZED.FormClosed += new FormClosedEventHandler(GetRECOGNIZED_FormClosed);
                GetRECOGNIZED.Show();
            }
            else
            {
                GetRECOGNIZED.Activate();
                switch (cmbBoxLanguage.SelectedIndex)
                {
                    case 0:
                        MessageBox.Show("The 'IMAGE RECOGNITION' window is already open!");
                        break;
                    case 1:
                        MessageBox.Show("A janela 'RECONHECIMENTO DE IMAGENS' já está aberta!");
                        break;
                }
            }
        }

        private void GetRECOGNIZED_FormClosed(object sender, FormClosedEventArgs e)
        {
            GetRECOGNIZED = null;
        }
        #endregion
    }
}
