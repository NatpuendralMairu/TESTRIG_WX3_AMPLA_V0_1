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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ClmnChkBx = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clmnSensor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnTemperature = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChrtTemp = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnDaqStart = new MetroFramework.Controls.MetroButton();
            this.chkDAQ_SaveFIle = new MetroFramework.Controls.MetroCheckBox();
            this.lblDaqTimer = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.btnDaqStop = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChrtTemp)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
            chartArea3.AxisX.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Lines;
            chartArea3.AxisX.InterlacedColor = System.Drawing.Color.Transparent;
            chartArea3.AxisX.LabelStyle.ForeColor = System.Drawing.Color.Silver;
            chartArea3.AxisX.LineColor = System.Drawing.Color.Gray;
            chartArea3.AxisY.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Lines;
            chartArea3.AxisY.LabelStyle.ForeColor = System.Drawing.Color.Silver;
            chartArea3.AxisY.LineColor = System.Drawing.Color.Gray;
            chartArea3.BackColor = System.Drawing.Color.Transparent;
            chartArea3.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea3.BackSecondaryColor = System.Drawing.Color.DarkGray;
            chartArea3.BorderColor = System.Drawing.Color.White;
            chartArea3.BorderWidth = 2;
            chartArea3.CursorX.LineColor = System.Drawing.Color.White;
            chartArea3.IsSameFontSizeForAllAxes = true;
            chartArea3.Name = "ChartArea1";
            chartArea3.ShadowColor = System.Drawing.Color.Transparent;
            this.ChrtTemp.ChartAreas.Add(chartArea3);
            legend3.BackColor = System.Drawing.Color.Transparent;
            legend3.BackSecondaryColor = System.Drawing.Color.Transparent;
            legend3.BorderColor = System.Drawing.Color.LightSlateGray;
            legend3.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend3.ForeColor = System.Drawing.Color.DarkGray;
            legend3.IsTextAutoFit = false;
            legend3.Name = "Legend1";
            legend3.TitleSeparator = System.Windows.Forms.DataVisualization.Charting.LegendSeparatorStyle.Line;
            this.ChrtTemp.Legends.Add(legend3);
            this.ChrtTemp.Location = new System.Drawing.Point(331, 74);
            this.ChrtTemp.Name = "ChrtTemp";
            this.ChrtTemp.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            this.ChrtTemp.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Yellow};
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "Temperature";
            this.ChrtTemp.Series.Add(series3);
            this.ChrtTemp.Size = new System.Drawing.Size(840, 445);
            this.ChrtTemp.TabIndex = 1;
            this.ChrtTemp.Text = "Temperature Plot";
            // 
            // btnDaqStart
            // 
            this.btnDaqStart.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnDaqStart.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnDaqStart.Location = new System.Drawing.Point(891, 536);
            this.btnDaqStart.Name = "btnDaqStart";
            this.btnDaqStart.Size = new System.Drawing.Size(131, 62);
            this.btnDaqStart.TabIndex = 2;
            this.btnDaqStart.Text = "S.T.A.R.T";
            this.btnDaqStart.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnDaqStart.UseSelectable = true;
            this.btnDaqStart.Click += new System.EventHandler(this.btnDaqStart_Click);
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
            this.lblDaqTimer.Location = new System.Drawing.Point(357, 526);
            this.lblDaqTimer.Name = "lblDaqTimer";
            this.lblDaqTimer.Size = new System.Drawing.Size(56, 25);
            this.lblDaqTimer.TabIndex = 4;
            this.lblDaqTimer.Text = "Timer";
            this.lblDaqTimer.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Cursor = System.Windows.Forms.Cursors.No;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(419, 526);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(56, 25);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "00:00";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // btnDaqStop
            // 
            this.btnDaqStop.Enabled = false;
            this.btnDaqStop.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnDaqStop.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnDaqStop.Location = new System.Drawing.Point(1040, 536);
            this.btnDaqStop.Name = "btnDaqStop";
            this.btnDaqStop.Size = new System.Drawing.Size(131, 62);
            this.btnDaqStop.TabIndex = 6;
            this.btnDaqStop.Text = "S.T.O.P";
            this.btnDaqStop.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnDaqStop.UseSelectable = true;
            // 
            // DAQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1195, 610);
            this.Controls.Add(this.btnDaqStop);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.lblDaqTimer);
            this.Controls.Add(this.chkDAQ_SaveFIle);
            this.Controls.Add(this.btnDaqStart);
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
        private MetroFramework.Controls.MetroButton btnDaqStart;
        private MetroFramework.Controls.MetroCheckBox chkDAQ_SaveFIle;
        private MetroFramework.Controls.MetroLabel lblDaqTimer;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton btnDaqStop;
    }
}