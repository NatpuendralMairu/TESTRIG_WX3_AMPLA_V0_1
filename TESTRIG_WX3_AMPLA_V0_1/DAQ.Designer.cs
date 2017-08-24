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
            this.ClmnChkBx = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clmnSensor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnTemperature = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChrtTemp = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnDaqStartStop = new MetroFramework.Controls.MetroButton();
            this.chkDAQ_SaveFIle = new MetroFramework.Controls.MetroCheckBox();
            this.lblDaqTimer = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChrtTemp)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClmnChkBx,
            this.clmnSensor,
            this.clmnTemperature});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(23, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(302, 524);
            this.dataGridView1.TabIndex = 0;
            // 
            // ClmnChkBx
            // 
            this.ClmnChkBx.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ClmnChkBx.HeaderText = "Select Sensor";
            this.ClmnChkBx.Name = "ClmnChkBx";
            this.ClmnChkBx.ToolTipText = "Choose the data to be updated and plotted to the Graph";
            this.ClmnChkBx.Width = 71;
            // 
            // clmnSensor
            // 
            this.clmnSensor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmnSensor.HeaderText = "Sensor Name";
            this.clmnSensor.Name = "clmnSensor";
            this.clmnSensor.ReadOnly = true;
            this.clmnSensor.ToolTipText = "Corresponds to the name on the DAQ";
            this.clmnSensor.Width = 88;
            // 
            // clmnTemperature
            // 
            this.clmnTemperature.HeaderText = "Temperature (ºC)";
            this.clmnTemperature.Name = "clmnTemperature";
            // 
            // ChrtTemp
            // 
            this.ChrtTemp.BackColor = System.Drawing.Color.Transparent;
            this.ChrtTemp.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Lines;
            chartArea1.AxisX.InterlacedColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.Silver;
            chartArea1.AxisX.LineColor = System.Drawing.Color.Gray;
            chartArea1.AxisY.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Lines;
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.Silver;
            chartArea1.AxisY.LineColor = System.Drawing.Color.Gray;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea1.BackSecondaryColor = System.Drawing.Color.DarkGray;
            chartArea1.BorderColor = System.Drawing.Color.White;
            chartArea1.BorderWidth = 2;
            chartArea1.CursorX.LineColor = System.Drawing.Color.White;
            chartArea1.IsSameFontSizeForAllAxes = true;
            chartArea1.Name = "ChartArea1";
            chartArea1.ShadowColor = System.Drawing.Color.Transparent;
            this.ChrtTemp.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.BackSecondaryColor = System.Drawing.Color.Transparent;
            legend1.BorderColor = System.Drawing.Color.LightSlateGray;
            legend1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend1.ForeColor = System.Drawing.Color.DarkGray;
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            legend1.TitleSeparator = System.Windows.Forms.DataVisualization.Charting.LegendSeparatorStyle.Line;
            this.ChrtTemp.Legends.Add(legend1);
            this.ChrtTemp.Location = new System.Drawing.Point(331, 74);
            this.ChrtTemp.Name = "ChrtTemp";
            this.ChrtTemp.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            this.ChrtTemp.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Yellow};
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "chrtTemperature";
            this.ChrtTemp.Series.Add(series1);
            this.ChrtTemp.Size = new System.Drawing.Size(840, 445);
            this.ChrtTemp.TabIndex = 1;
            this.ChrtTemp.Text = "Temperature Plot";
            // 
            // btnDaqStartStop
            // 
            this.btnDaqStartStop.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnDaqStartStop.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnDaqStartStop.Location = new System.Drawing.Point(891, 525);
            this.btnDaqStartStop.Name = "btnDaqStartStop";
            this.btnDaqStartStop.Size = new System.Drawing.Size(280, 70);
            this.btnDaqStartStop.TabIndex = 2;
            this.btnDaqStartStop.Text = "S.T.A.R.T";
            this.btnDaqStartStop.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnDaqStartStop.UseSelectable = true;
            this.btnDaqStartStop.Click += new System.EventHandler(this.btnDaqStartStop_Click);
            // 
            // chkDAQ_SaveFIle
            // 
            this.chkDAQ_SaveFIle.Checked = true;
            this.chkDAQ_SaveFIle.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDAQ_SaveFIle.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.chkDAQ_SaveFIle.Location = new System.Drawing.Point(730, 543);
            this.chkDAQ_SaveFIle.Name = "chkDAQ_SaveFIle";
            this.chkDAQ_SaveFIle.Size = new System.Drawing.Size(124, 34);
            this.chkDAQ_SaveFIle.TabIndex = 3;
            this.chkDAQ_SaveFIle.Text = "Save File (*.txt)";
            this.chkDAQ_SaveFIle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkDAQ_SaveFIle.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.chkDAQ_SaveFIle.UseSelectable = true;
            this.chkDAQ_SaveFIle.CheckedChanged += new System.EventHandler(this.chkBxSaveTxt_CheckedChanged);
            // 
            // lblDaqTimer
            // 
            this.lblDaqTimer.AutoSize = true;
            this.lblDaqTimer.Cursor = System.Windows.Forms.Cursors.No;
            this.lblDaqTimer.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblDaqTimer.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblDaqTimer.Location = new System.Drawing.Point(407, 522);
            this.lblDaqTimer.Name = "lblDaqTimer";
            this.lblDaqTimer.Size = new System.Drawing.Size(56, 25);
            this.lblDaqTimer.TabIndex = 4;
            this.lblDaqTimer.Text = "Timer";
            this.lblDaqTimer.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Cursor = System.Windows.Forms.Cursors.No;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(469, 522);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(56, 25);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "00:00";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // DAQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1193, 610);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.lblDaqTimer);
            this.Controls.Add(this.chkDAQ_SaveFIle);
            this.Controls.Add(this.btnDaqStartStop);
            this.Controls.Add(this.ChrtTemp);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DAQ";
            this.Text = "D.A.Q TEST";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.Load += new System.EventHandler(this.DAQ_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChrtTemp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ClmnChkBx;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnSensor;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnTemperature;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChrtTemp;
        private MetroFramework.Controls.MetroButton btnDaqStartStop;
        private MetroFramework.Controls.MetroCheckBox chkDAQ_SaveFIle;
        private MetroFramework.Controls.MetroLabel lblDaqTimer;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}