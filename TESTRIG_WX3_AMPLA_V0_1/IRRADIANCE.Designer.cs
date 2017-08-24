namespace TESTRIG_WX3_AMPLA_V0_1
{
    partial class IRRADIANCE
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
            this.IRchart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.labelIR = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.labelTemp = new MetroFramework.Controls.MetroLabel();
            this.lblPwr = new MetroFramework.Controls.MetroLabel();
            this.labelPower = new MetroFramework.Controls.MetroLabel();
            this.btnIR_StartStop = new MetroFramework.Controls.MetroButton();
            this.chkIR_FileSave = new MetroFramework.Controls.MetroCheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTxt = new MetroFramework.Controls.MetroLabel();
            this.lblIR_Timer = new MetroFramework.Controls.MetroLabel();
            this.lblWave = new MetroFramework.Controls.MetroLabel();
            this.txtLogdata = new System.Windows.Forms.TextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.IRchart)).BeginInit();
            this.SuspendLayout();
            // 
            // IRchart
            // 
            this.IRchart.BackColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Lines;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Monospac821 BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.DarkGray;
            chartArea1.AxisX.LineColor = System.Drawing.Color.DarkGray;
            chartArea1.AxisX.MajorGrid.Interval = 0D;
            chartArea1.AxisX.MajorGrid.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Minutes;
            chartArea1.AxisX.MajorGrid.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.Color.Gainsboro;
            chartArea1.AxisX.TitleForeColor = System.Drawing.Color.DarkGray;
            chartArea1.AxisX2.LineColor = System.Drawing.Color.Orchid;
            chartArea1.AxisY.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Lines;
            chartArea1.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Monospac821 BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.DarkGray;
            chartArea1.AxisY.LineColor = System.Drawing.Color.DarkGray;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.DarkGray;
            chartArea1.AxisY2.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;
            chartArea1.AxisY2.InterlacedColor = System.Drawing.Color.Transparent;
            chartArea1.AxisY2.LineColor = System.Drawing.Color.DarkGray;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea1.BorderColor = System.Drawing.Color.White;
            chartArea1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.Name = "Irradiance_TempChart";
            this.IRchart.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Font = new System.Drawing.Font("Monospac821 BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend1.ForeColor = System.Drawing.Color.DarkGray;
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            this.IRchart.Legends.Add(legend1);
            this.IRchart.Location = new System.Drawing.Point(306, 63);
            this.IRchart.Name = "IRchart";
            this.IRchart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series1.ChartArea = "Irradiance_TempChart";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "IRdata";
            this.IRchart.Series.Add(series1);
            this.IRchart.Size = new System.Drawing.Size(630, 404);
            this.IRchart.TabIndex = 0;
            this.IRchart.Text = "Irradiance_Temp Chart";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.ForeColor = System.Drawing.Color.DarkGray;
            this.metroLabel1.Location = new System.Drawing.Point(26, 198);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(161, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Irradiance (mW/cm^2) =";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // labelIR
            // 
            this.labelIR.AutoSize = true;
            this.labelIR.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.labelIR.Location = new System.Drawing.Point(211, 198);
            this.labelIR.Name = "labelIR";
            this.labelIR.Size = new System.Drawing.Size(33, 19);
            this.labelIR.TabIndex = 2;
            this.labelIR.Text = "N/A";
            this.labelIR.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.labelIR.TextChanged += new System.EventHandler(this.labelIR_TextChanged);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.metroLabel3.Location = new System.Drawing.Point(26, 233);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(128, 19);
            this.metroLabel3.TabIndex = 3;
            this.metroLabel3.Text = "Temperature (ºC) =";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // labelTemp
            // 
            this.labelTemp.AutoSize = true;
            this.labelTemp.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.labelTemp.Location = new System.Drawing.Point(211, 233);
            this.labelTemp.Name = "labelTemp";
            this.labelTemp.Size = new System.Drawing.Size(33, 19);
            this.labelTemp.TabIndex = 4;
            this.labelTemp.Text = "N/A";
            this.labelTemp.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lblPwr
            // 
            this.lblPwr.AutoSize = true;
            this.lblPwr.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblPwr.Location = new System.Drawing.Point(26, 162);
            this.lblPwr.Name = "lblPwr";
            this.lblPwr.Size = new System.Drawing.Size(98, 19);
            this.lblPwr.TabIndex = 5;
            this.lblPwr.Text = "Power (mW) =";
            this.lblPwr.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // labelPower
            // 
            this.labelPower.AutoSize = true;
            this.labelPower.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.labelPower.Location = new System.Drawing.Point(211, 162);
            this.labelPower.Name = "labelPower";
            this.labelPower.Size = new System.Drawing.Size(33, 19);
            this.labelPower.TabIndex = 6;
            this.labelPower.Text = "N/A";
            this.labelPower.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // btnIR_StartStop
            // 
            this.btnIR_StartStop.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnIR_StartStop.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnIR_StartStop.Location = new System.Drawing.Point(658, 486);
            this.btnIR_StartStop.Name = "btnIR_StartStop";
            this.btnIR_StartStop.Size = new System.Drawing.Size(278, 54);
            this.btnIR_StartStop.TabIndex = 7;
            this.btnIR_StartStop.Text = "S.T.A.R.T";
            this.btnIR_StartStop.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnIR_StartStop.UseSelectable = true;
            this.btnIR_StartStop.Click += new System.EventHandler(this.btnIR_StartStop_Click);
            // 
            // chkIR_FileSave
            // 
            this.chkIR_FileSave.AutoSize = true;
            this.chkIR_FileSave.Checked = true;
            this.chkIR_FileSave.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIR_FileSave.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.chkIR_FileSave.Location = new System.Drawing.Point(509, 500);
            this.chkIR_FileSave.Name = "chkIR_FileSave";
            this.chkIR_FileSave.Size = new System.Drawing.Size(114, 19);
            this.chkIR_FileSave.TabIndex = 8;
            this.chkIR_FileSave.Text = "Save File (*.txt)";
            this.chkIR_FileSave.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.chkIR_FileSave.UseSelectable = true;
            this.chkIR_FileSave.CheckedChanged += new System.EventHandler(this.chkIR_FileSave_CheckedChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblTxt
            // 
            this.lblTxt.AutoSize = true;
            this.lblTxt.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblTxt.Location = new System.Drawing.Point(26, 271);
            this.lblTxt.Name = "lblTxt";
            this.lblTxt.Size = new System.Drawing.Size(57, 19);
            this.lblTxt.TabIndex = 9;
            this.lblTxt.Text = "Timer =";
            this.lblTxt.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lblIR_Timer
            // 
            this.lblIR_Timer.AutoSize = true;
            this.lblIR_Timer.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblIR_Timer.Location = new System.Drawing.Point(110, 271);
            this.lblIR_Timer.Name = "lblIR_Timer";
            this.lblIR_Timer.Size = new System.Drawing.Size(33, 19);
            this.lblIR_Timer.TabIndex = 10;
            this.lblIR_Timer.Text = "N/A";
            this.lblIR_Timer.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lblWave
            // 
            this.lblWave.AutoSize = true;
            this.lblWave.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblWave.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblWave.Location = new System.Drawing.Point(26, 103);
            this.lblWave.Name = "lblWave";
            this.lblWave.Size = new System.Drawing.Size(189, 25);
            this.lblWave.TabIndex = 11;
            this.lblWave.Text = "Wavelength = 780 nm";
            this.lblWave.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtLogdata
            // 
            this.txtLogdata.Location = new System.Drawing.Point(13, 368);
            this.txtLogdata.Multiline = true;
            this.txtLogdata.Name = "txtLogdata";
            this.txtLogdata.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLogdata.Size = new System.Drawing.Size(296, 172);
            this.txtLogdata.TabIndex = 15;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel9.Location = new System.Drawing.Point(13, 346);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(113, 19);
            this.metroLabel9.TabIndex = 16;
            this.metroLabel9.Text = "Irradiance Values";
            this.metroLabel9.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // IRRADIANCE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 563);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.txtLogdata);
            this.Controls.Add(this.lblWave);
            this.Controls.Add(this.lblIR_Timer);
            this.Controls.Add(this.lblTxt);
            this.Controls.Add(this.chkIR_FileSave);
            this.Controls.Add(this.btnIR_StartStop);
            this.Controls.Add(this.labelPower);
            this.Controls.Add(this.lblPwr);
            this.Controls.Add(this.labelTemp);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.labelIR);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.IRchart);
            this.Name = "IRRADIANCE";
            this.Text = "IRRADIANCE TEST";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.IRRADIANCE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IRchart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart IRchart;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel labelIR;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel labelTemp;
        private MetroFramework.Controls.MetroLabel lblPwr;
        private MetroFramework.Controls.MetroLabel labelPower;
        private MetroFramework.Controls.MetroButton btnIR_StartStop;
        private MetroFramework.Controls.MetroCheckBox chkIR_FileSave;
        private System.Windows.Forms.Timer timer1;
        private MetroFramework.Controls.MetroLabel lblTxt;
        private MetroFramework.Controls.MetroLabel lblIR_Timer;
        private MetroFramework.Controls.MetroLabel lblWave;
        private System.Windows.Forms.TextBox txtLogdata;
        private MetroFramework.Controls.MetroLabel metroLabel9;
    }
}