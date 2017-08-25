namespace TESTRIG_WX3_AMPLA_V0_1
{
    partial class WEBCAM
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
            this.wbCam1 = new System.Windows.Forms.PictureBox();
            this.cmbbxWebcam = new MetroFramework.Controls.MetroComboBox();
            this.wbCam2 = new System.Windows.Forms.PictureBox();
            this.btnStartStop = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.wbCam1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wbCam2)).BeginInit();
            this.SuspendLayout();
            // 
            // wbCam1
            // 
            this.wbCam1.Location = new System.Drawing.Point(24, 64);
            this.wbCam1.Name = "wbCam1";
            this.wbCam1.Size = new System.Drawing.Size(353, 240);
            this.wbCam1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.wbCam1.TabIndex = 0;
            this.wbCam1.TabStop = false;
            // 
            // cmbbxWebcam
            // 
            this.cmbbxWebcam.FormattingEnabled = true;
            this.cmbbxWebcam.ItemHeight = 23;
            this.cmbbxWebcam.Location = new System.Drawing.Point(24, 332);
            this.cmbbxWebcam.Name = "cmbbxWebcam";
            this.cmbbxWebcam.Size = new System.Drawing.Size(253, 29);
            this.cmbbxWebcam.TabIndex = 1;
            this.cmbbxWebcam.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cmbbxWebcam.UseSelectable = true;
            // 
            // wbCam2
            // 
            this.wbCam2.Location = new System.Drawing.Point(444, 64);
            this.wbCam2.Name = "wbCam2";
            this.wbCam2.Size = new System.Drawing.Size(353, 240);
            this.wbCam2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.wbCam2.TabIndex = 2;
            this.wbCam2.TabStop = false;
            // 
            // btnStartStop
            // 
            this.btnStartStop.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnStartStop.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnStartStop.Location = new System.Drawing.Point(618, 369);
            this.btnStartStop.Name = "btnStartStop";
            this.btnStartStop.Size = new System.Drawing.Size(179, 52);
            this.btnStartStop.TabIndex = 4;
            this.btnStartStop.Text = "S.T.A.R.T";
            this.btnStartStop.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnStartStop.UseSelectable = true;
            this.btnStartStop.Click += new System.EventHandler(this.btnStartStop_Click);
            // 
            // WEBCAM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 444);
            this.Controls.Add(this.btnStartStop);
            this.Controls.Add(this.wbCam2);
            this.Controls.Add(this.cmbbxWebcam);
            this.Controls.Add(this.wbCam1);
            this.Name = "WEBCAM";
            this.Text = "WEBCAM";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WEBCAM_FormClosed);
            this.Load += new System.EventHandler(this.WEBCAM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wbCam1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wbCam2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox wbCam1;
        private MetroFramework.Controls.MetroComboBox cmbbxWebcam;
        private System.Windows.Forms.PictureBox wbCam2;
        private MetroFramework.Controls.MetroButton btnStartStop;
    }
}