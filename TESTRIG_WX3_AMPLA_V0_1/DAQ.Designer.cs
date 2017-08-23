namespace TESTRIG_WX3_AMPLA_V0_1
{
    partial class DAQ
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnDaqStartStop = new MetroFramework.Controls.MetroButton();
            this.ClmnChkBx = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clmnSensor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnTemperature = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chkBxSaveTxt = new MetroFramework.Controls.MetroCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClmnChkBx,
            this.clmnSensor,
            this.clmnTemperature});
            this.dataGridView1.Location = new System.Drawing.Point(23, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(319, 524);
            this.dataGridView1.TabIndex = 0;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(348, 74);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "chrtTemperature";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(822, 444);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // btnDaqStartStop
            // 
            this.btnDaqStartStop.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnDaqStartStop.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnDaqStartStop.Location = new System.Drawing.Point(891, 524);
            this.btnDaqStartStop.Name = "btnDaqStartStop";
            this.btnDaqStartStop.Size = new System.Drawing.Size(279, 68);
            this.btnDaqStartStop.TabIndex = 2;
            this.btnDaqStartStop.Text = "START";
            this.btnDaqStartStop.UseSelectable = true;
            this.btnDaqStartStop.Click += new System.EventHandler(this.btnDaqStartStop_Click);
            // 
            // ClmnChkBx
            // 
            this.ClmnChkBx.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ClmnChkBx.HeaderText = "Select Sensor";
            this.ClmnChkBx.Name = "ClmnChkBx";
            this.ClmnChkBx.ToolTipText = "Choose the data to be updated and plotted to the Graph";
            this.ClmnChkBx.Width = 79;
            // 
            // clmnSensor
            // 
            this.clmnSensor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmnSensor.HeaderText = "Sensor Name";
            this.clmnSensor.Name = "clmnSensor";
            this.clmnSensor.ReadOnly = true;
            this.clmnSensor.ToolTipText = "Corresponds to the name on the DAQ";
            this.clmnSensor.Width = 96;
            // 
            // clmnTemperature
            // 
            this.clmnTemperature.HeaderText = "Temperature (ºC)";
            this.clmnTemperature.Name = "clmnTemperature";
            // 
            // chkBxSaveTxt
            // 
            this.chkBxSaveTxt.Location = new System.Drawing.Point(744, 543);
            this.chkBxSaveTxt.Name = "chkBxSaveTxt";
            this.chkBxSaveTxt.Size = new System.Drawing.Size(110, 34);
            this.chkBxSaveTxt.TabIndex = 3;
            this.chkBxSaveTxt.Text = "Save File (*.txt)";
            this.chkBxSaveTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkBxSaveTxt.Theme = MetroFramework.MetroThemeStyle.Light;
            this.chkBxSaveTxt.UseSelectable = true;
            // 
            // DAQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1193, 610);
            this.Controls.Add(this.chkBxSaveTxt);
            this.Controls.Add(this.btnDaqStartStop);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DAQ";
            this.Text = "D.A.Q TEST";
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.Load += new System.EventHandler(this.DAQ_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ClmnChkBx;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnSensor;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnTemperature;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private MetroFramework.Controls.MetroButton btnDaqStartStop;
        private MetroFramework.Controls.MetroCheckBox chkBxSaveTxt;
    }
}