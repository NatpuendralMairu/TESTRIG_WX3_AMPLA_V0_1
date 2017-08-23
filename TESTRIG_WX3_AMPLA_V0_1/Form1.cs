using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TESTRIG_WX3_AMPLA_V0_1
{
    public partial class TestRig : MetroFramework.Forms.MetroForm
    {
        public TestRig()
        {
            InitializeComponent();
        }
        // English Language Buttons
        private void lang_Eng()
        {
            btnDAQ.Text = "D.A.Q TEST";
            btnIR.Text = "IRRADIANCE TEST";
            btnWebCam_Capture.Text = " CAPTURE \n SNAPSHOTS";
            btnImageRecognition.Text = "IMAGE RECOGNITION \n(Offline Version)";
            return;
        }

        private void lang_Portuguese()
        {
            btnDAQ.Text = "TESTE DE \nD.A.Q";
            btnIR.Text = "TEST DE \nIRRADIÂNCIA";
            btnWebCam_Capture.Text = "CAPTURAR \nIMAGEM";
            btnImageRecognition.Text = "RECONHECIMENTO DE\nIMAGEM (Versão Offline)";
            return;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Default Language is Set to "English"
            cmbBoxLanguage.SelectedIndex = 1;
        }

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
    }
}
