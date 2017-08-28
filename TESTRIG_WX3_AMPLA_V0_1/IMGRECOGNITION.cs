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
    public partial class IMGRECOGNITION : MetroFramework.Forms.MetroForm
    {
        public IMGRECOGNITION()
        {
            InitializeComponent();
        }

        private void IMGRECOGNITION_Load(object sender, EventArgs e)
        {
            LblMessage.Text = "Ooops! I did it again";
        }
    }
}
