namespace TESTRIG_WX3_AMPLA_V0_1
{
    partial class TestRig
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestRig));
            this.btnDAQ = new MetroFramework.Controls.MetroButton();
            this.btnIR = new MetroFramework.Controls.MetroButton();
            this.btnWebCam_Capture = new MetroFramework.Controls.MetroButton();
            this.btnImageRecognition = new MetroFramework.Controls.MetroButton();
            this.cmbBoxLanguage = new MetroFramework.Controls.MetroComboBox();
            this.lblLanguage = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // btnDAQ
            // 
            resources.ApplyResources(this.btnDAQ, "btnDAQ");
            this.btnDAQ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDAQ.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnDAQ.Name = "btnDAQ";
            this.btnDAQ.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnDAQ.UseSelectable = true;
            this.btnDAQ.Click += new System.EventHandler(this.btnDAQ_Click);
            // 
            // btnIR
            // 
            resources.ApplyResources(this.btnIR, "btnIR");
            this.btnIR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIR.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnIR.Name = "btnIR";
            this.btnIR.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnIR.UseSelectable = true;
            this.btnIR.Click += new System.EventHandler(this.btnIR_Click);
            // 
            // btnWebCam_Capture
            // 
            resources.ApplyResources(this.btnWebCam_Capture, "btnWebCam_Capture");
            this.btnWebCam_Capture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWebCam_Capture.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnWebCam_Capture.Name = "btnWebCam_Capture";
            this.btnWebCam_Capture.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnWebCam_Capture.UseSelectable = true;
            // 
            // btnImageRecognition
            // 
            resources.ApplyResources(this.btnImageRecognition, "btnImageRecognition");
            this.btnImageRecognition.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImageRecognition.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnImageRecognition.Name = "btnImageRecognition";
            this.btnImageRecognition.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnImageRecognition.UseSelectable = true;
            // 
            // cmbBoxLanguage
            // 
            resources.ApplyResources(this.cmbBoxLanguage, "cmbBoxLanguage");
            this.cmbBoxLanguage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbBoxLanguage.FormattingEnabled = true;
            this.cmbBoxLanguage.Items.AddRange(new object[] {
            resources.GetString("cmbBoxLanguage.Items"),
            resources.GetString("cmbBoxLanguage.Items1")});
            this.cmbBoxLanguage.Name = "cmbBoxLanguage";
            this.cmbBoxLanguage.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cmbBoxLanguage.UseSelectable = true;
            this.cmbBoxLanguage.SelectedIndexChanged += new System.EventHandler(this.cmbBoxLanguage_SelectedIndexChanged);
            // 
            // lblLanguage
            // 
            resources.ApplyResources(this.lblLanguage, "lblLanguage");
            this.lblLanguage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.lblLanguage.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblLanguage.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblLanguage.ForeColor = System.Drawing.Color.White;
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Style = MetroFramework.MetroColorStyle.Black;
            this.lblLanguage.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // TestRig
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.Controls.Add(this.lblLanguage);
            this.Controls.Add(this.cmbBoxLanguage);
            this.Controls.Add(this.btnImageRecognition);
            this.Controls.Add(this.btnWebCam_Capture);
            this.Controls.Add(this.btnIR);
            this.Controls.Add(this.btnDAQ);
            this.Name = "TestRig";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnDAQ;
        private MetroFramework.Controls.MetroButton btnIR;
        private MetroFramework.Controls.MetroButton btnWebCam_Capture;
        private MetroFramework.Controls.MetroButton btnImageRecognition;
        private MetroFramework.Controls.MetroComboBox cmbBoxLanguage;
        private MetroFramework.Controls.MetroLabel lblLanguage;
    }
}

