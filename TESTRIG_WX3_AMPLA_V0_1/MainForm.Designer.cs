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
            this.btnDAQ.AutoSize = true;
            this.btnDAQ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDAQ.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnDAQ.Location = new System.Drawing.Point(23, 143);
            this.btnDAQ.Name = "btnDAQ";
            this.btnDAQ.Size = new System.Drawing.Size(217, 60);
            this.btnDAQ.TabIndex = 0;
            this.btnDAQ.Text = "D.A.Q TEST";
            this.btnDAQ.UseSelectable = true;
            this.btnDAQ.Click += new System.EventHandler(this.btnDAQ_Click);
            // 
            // btnIR
            // 
            this.btnIR.AutoSize = true;
            this.btnIR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIR.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnIR.Location = new System.Drawing.Point(301, 143);
            this.btnIR.Name = "btnIR";
            this.btnIR.Size = new System.Drawing.Size(217, 60);
            this.btnIR.TabIndex = 1;
            this.btnIR.Text = "IRRADIANCE TEST";
            this.btnIR.UseSelectable = true;
            this.btnIR.Click += new System.EventHandler(this.btnIR_Click);
            // 
            // btnWebCam_Capture
            // 
            this.btnWebCam_Capture.AutoSize = true;
            this.btnWebCam_Capture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWebCam_Capture.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnWebCam_Capture.Location = new System.Drawing.Point(23, 276);
            this.btnWebCam_Capture.Name = "btnWebCam_Capture";
            this.btnWebCam_Capture.Size = new System.Drawing.Size(217, 60);
            this.btnWebCam_Capture.TabIndex = 2;
            this.btnWebCam_Capture.Text = "CAPTURE\r\nSNAPSHOTS";
            this.btnWebCam_Capture.UseSelectable = true;
            // 
            // btnImageRecognition
            // 
            this.btnImageRecognition.AutoSize = true;
            this.btnImageRecognition.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImageRecognition.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnImageRecognition.Location = new System.Drawing.Point(301, 276);
            this.btnImageRecognition.Name = "btnImageRecognition";
            this.btnImageRecognition.Size = new System.Drawing.Size(217, 60);
            this.btnImageRecognition.TabIndex = 3;
            this.btnImageRecognition.Text = "IMAGE RECOGNITION\r\n(Offline Version)";
            this.btnImageRecognition.UseSelectable = true;
            // 
            // cmbBoxLanguage
            // 
            this.cmbBoxLanguage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbBoxLanguage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbBoxLanguage.FormattingEnabled = true;
            this.cmbBoxLanguage.ItemHeight = 23;
            this.cmbBoxLanguage.Items.AddRange(new object[] {
            "English",
            "Português"});
            this.cmbBoxLanguage.Location = new System.Drawing.Point(301, 63);
            this.cmbBoxLanguage.Name = "cmbBoxLanguage";
            this.cmbBoxLanguage.Size = new System.Drawing.Size(180, 29);
            this.cmbBoxLanguage.TabIndex = 4;
            this.cmbBoxLanguage.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cmbBoxLanguage.UseSelectable = true;
            this.cmbBoxLanguage.SelectedIndexChanged += new System.EventHandler(this.cmbBoxLanguage_SelectedIndexChanged);
            // 
            // lblLanguage
            // 
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.lblLanguage.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblLanguage.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblLanguage.ForeColor = System.Drawing.Color.White;
            this.lblLanguage.Location = new System.Drawing.Point(301, 35);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(160, 25);
            this.lblLanguage.Style = MetroFramework.MetroColorStyle.Black;
            this.lblLanguage.TabIndex = 5;
            this.lblLanguage.Text = "Idioma (Language)";
            this.lblLanguage.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // TestRig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(541, 376);
            this.Controls.Add(this.lblLanguage);
            this.Controls.Add(this.cmbBoxLanguage);
            this.Controls.Add(this.btnImageRecognition);
            this.Controls.Add(this.btnWebCam_Capture);
            this.Controls.Add(this.btnIR);
            this.Controls.Add(this.btnDAQ);
            this.Name = "TestRig";
            this.Text = "TESTING RIG";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
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

