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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.lblPwr = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.btnIR_StartStop = new MetroFramework.Controls.MetroButton();
            this.chkIR_FileSave = new MetroFramework.Controls.MetroCheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTxt = new MetroFramework.Controls.MetroLabel();
            this.lblIR_Timer = new MetroFramework.Controls.MetroLabel();
            this.lblWave = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            chartArea3.AxisX.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Lines;
            chartArea3.AxisX.IsLabelAutoFit = false;
            chartArea3.AxisX.LabelStyle.Font = new System.Drawing.Font("Monospac821 BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea3.AxisX.LabelStyle.ForeColor = System.Drawing.Color.DarkGray;
            chartArea3.AxisX.LineColor = System.Drawing.Color.DarkGray;
            chartArea3.AxisX.MajorGrid.Interval = 0D;
            chartArea3.AxisX.MajorGrid.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Minutes;
            chartArea3.AxisX.MajorGrid.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea3.AxisX.MajorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea3.AxisX.MajorTickMark.LineColor = System.Drawing.Color.Gainsboro;
            chartArea3.AxisX.TitleForeColor = System.Drawing.Color.DarkGray;
            chartArea3.AxisX2.LineColor = System.Drawing.Color.Orchid;
            chartArea3.AxisY.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Lines;
            chartArea3.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea3.AxisY.IsLabelAutoFit = false;
            chartArea3.AxisY.LabelStyle.Font = new System.Drawing.Font("Monospac821 BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea3.AxisY.LabelStyle.ForeColor = System.Drawing.Color.DarkGray;
            chartArea3.AxisY.LineColor = System.Drawing.Color.DarkGray;
            chartArea3.AxisY.MajorGrid.LineColor = System.Drawing.Color.DarkGray;
            chartArea3.AxisY2.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;
            chartArea3.AxisY2.InterlacedColor = System.Drawing.Color.Transparent;
            chartArea3.AxisY2.LineColor = System.Drawing.Color.DarkGray;
            chartArea3.BackColor = System.Drawing.Color.Transparent;
            chartArea3.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea3.BorderColor = System.Drawing.Color.White;
            chartArea3.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea3.Name = "Irradiance_TempChart";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.BackColor = System.Drawing.Color.Transparent;
            legend3.Font = new System.Drawing.Font("Monospac821 BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend3.ForeColor = System.Drawing.Color.DarkGray;
            legend3.IsTextAutoFit = false;
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(306, 63);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series3.ChartArea = "Irradiance_TempChart";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(630, 404);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "Irradiance_Temp Chart";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.ForeColor = System.Drawing.Color.DarkGray;
            this.metroLabel1.Location = new System.Drawing.Point(26, 198);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(106, 25);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Irradiance =";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(161, 198);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(44, 25);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "N/A";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.metroLabel3.Location = new System.Drawing.Point(26, 233);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(129, 25);
            this.metroLabel3.TabIndex = 3;
            this.metroLabel3.Text = "Temperature =";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(161, 233);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(44, 25);
            this.metroLabel4.TabIndex = 4;
            this.metroLabel4.Text = "N/A";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lblPwr
            // 
            this.lblPwr.AutoSize = true;
            this.lblPwr.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblPwr.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblPwr.Location = new System.Drawing.Point(26, 162);
            this.lblPwr.Name = "lblPwr";
            this.lblPwr.Size = new System.Drawing.Size(78, 25);
            this.lblPwr.TabIndex = 5;
            this.lblPwr.Text = "Power =";
            this.lblPwr.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(161, 162);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(44, 25);
            this.metroLabel5.TabIndex = 6;
            this.metroLabel5.Text = "N/A";
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Dark;
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
            // lblTxt
            // 
            this.lblTxt.AutoSize = true;
            this.lblTxt.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblTxt.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblTxt.Location = new System.Drawing.Point(26, 271);
            this.lblTxt.Name = "lblTxt";
            this.lblTxt.Size = new System.Drawing.Size(73, 25);
            this.lblTxt.TabIndex = 9;
            this.lblTxt.Text = "Timer =";
            this.lblTxt.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lblIR_Timer
            // 
            this.lblIR_Timer.AutoSize = true;
            this.lblIR_Timer.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblIR_Timer.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblIR_Timer.Location = new System.Drawing.Point(161, 271);
            this.lblIR_Timer.Name = "lblIR_Timer";
            this.lblIR_Timer.Size = new System.Drawing.Size(44, 25);
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
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel6.Location = new System.Drawing.Point(211, 162);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(45, 25);
            this.metroLabel6.TabIndex = 12;
            this.metroLabel6.Text = "mW";
            this.metroLabel6.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel7.Location = new System.Drawing.Point(211, 198);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(98, 25);
            this.metroLabel7.TabIndex = 13;
            this.metroLabel7.Text = "mW/cm^2";
            this.metroLabel7.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel8.Location = new System.Drawing.Point(211, 233);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(31, 25);
            this.metroLabel8.TabIndex = 14;
            this.metroLabel8.Text = "ºC";
            this.metroLabel8.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 368);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(296, 172);
            this.textBox1.TabIndex = 15;
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
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.lblWave);
            this.Controls.Add(this.lblIR_Timer);
            this.Controls.Add(this.lblTxt);
            this.Controls.Add(this.chkIR_FileSave);
            this.Controls.Add(this.btnIR_StartStop);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.lblPwr);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.chart1);
            this.Name = "IRRADIANCE";
            this.Text = "IRRADIANCE TEST";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel lblPwr;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroButton btnIR_StartStop;
        private MetroFramework.Controls.MetroCheckBox chkIR_FileSave;
        private System.Windows.Forms.Timer timer1;
        private MetroFramework.Controls.MetroLabel lblTxt;
        private MetroFramework.Controls.MetroLabel lblIR_Timer;
        private MetroFramework.Controls.MetroLabel lblWave;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private System.Windows.Forms.TextBox textBox1;
        private MetroFramework.Controls.MetroLabel metroLabel9;
    }
}