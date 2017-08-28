namespace TESTRIG_WX3_AMPLA_V0_1
{
    partial class IMGRECOGNITION
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
            this.LblMessage = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // LblMessage
            // 
            this.LblMessage.AutoSize = true;
            this.LblMessage.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.LblMessage.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.LblMessage.Location = new System.Drawing.Point(158, 150);
            this.LblMessage.Name = "LblMessage";
            this.LblMessage.Size = new System.Drawing.Size(0, 0);
            this.LblMessage.TabIndex = 0;
            // 
            // IMGRECOGNITION
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 377);
            this.Controls.Add(this.LblMessage);
            this.Name = "IMGRECOGNITION";
            this.Text = "IMGRECOGNITION";
            this.Load += new System.EventHandler(this.IMGRECOGNITION_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel LblMessage;
    }
}