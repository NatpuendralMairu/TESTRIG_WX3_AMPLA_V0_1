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
            this.ChrtTemp = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnDaqStart = new MetroFramework.Controls.MetroButton();
            this.chkDAQ_SaveFIle = new MetroFramework.Controls.MetroCheckBox();
            this.lblDaqTimer = new MetroFramework.Controls.MetroLabel();
            this.btnDaqStop = new MetroFramework.Controls.MetroButton();
            this.WebBrwsr = new System.Windows.Forms.WebBrowser();
            this.lblSensor = new MetroFramework.Controls.MetroLabel();
            this.lblTemperature = new MetroFramework.Controls.MetroLabel();
            this.lbl1 = new MetroFramework.Controls.MetroLabel();
            this.lblTemp1 = new MetroFramework.Controls.MetroLabel();
            this.lblTemp3 = new MetroFramework.Controls.MetroLabel();
            this.lbl3 = new MetroFramework.Controls.MetroLabel();
            this.lblTemp2 = new MetroFramework.Controls.MetroLabel();
            this.lbl2 = new MetroFramework.Controls.MetroLabel();
            this.lblTemp7 = new MetroFramework.Controls.MetroLabel();
            this.lbl7 = new MetroFramework.Controls.MetroLabel();
            this.lblTemp6 = new MetroFramework.Controls.MetroLabel();
            this.lbl6 = new MetroFramework.Controls.MetroLabel();
            this.lblTemp5 = new MetroFramework.Controls.MetroLabel();
            this.lbl5 = new MetroFramework.Controls.MetroLabel();
            this.lblTemp4 = new MetroFramework.Controls.MetroLabel();
            this.lbl4 = new MetroFramework.Controls.MetroLabel();
            this.lblTemp10 = new MetroFramework.Controls.MetroLabel();
            this.lbl10 = new MetroFramework.Controls.MetroLabel();
            this.lblTemp9 = new MetroFramework.Controls.MetroLabel();
            this.lbl9 = new MetroFramework.Controls.MetroLabel();
            this.lblTemp8 = new MetroFramework.Controls.MetroLabel();
            this.lbl8 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.ChrtTemp)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
            this.btnDaqStop.Click += new System.EventHandler(this.btnDaqStop_Click);
            // 
            // WebBrwsr
            // 
            this.WebBrwsr.Location = new System.Drawing.Point(357, 554);
            this.WebBrwsr.MinimumSize = new System.Drawing.Size(20, 20);
            this.WebBrwsr.Name = "WebBrwsr";
            this.WebBrwsr.Size = new System.Drawing.Size(339, 44);
            this.WebBrwsr.TabIndex = 7;
            // 
            // lblSensor
            // 
            this.lblSensor.AutoSize = true;
            this.lblSensor.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblSensor.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblSensor.Location = new System.Drawing.Point(24, 74);
            this.lblSensor.Name = "lblSensor";
            this.lblSensor.Size = new System.Drawing.Size(105, 25);
            this.lblSensor.TabIndex = 8;
            this.lblSensor.Text = "SENSOR Nº";
            this.lblSensor.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lblTemperature
            // 
            this.lblTemperature.AutoSize = true;
            this.lblTemperature.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblTemperature.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblTemperature.Location = new System.Drawing.Point(146, 74);
            this.lblTemperature.Name = "lblTemperature";
            this.lblTemperature.Size = new System.Drawing.Size(146, 25);
            this.lblTemperature.TabIndex = 9;
            this.lblTemperature.Text = "Temperature (ºC)";
            this.lblTemperature.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(24, 120);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(117, 38);
            this.lbl1.TabIndex = 10;
            this.lbl1.Text = "Black Body 1\r\nEsquerda Superior";
            this.lbl1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lblTemp1
            // 
            this.lblTemp1.AutoSize = true;
            this.lblTemp1.Location = new System.Drawing.Point(200, 130);
            this.lblTemp1.Name = "lblTemp1";
            this.lblTemp1.Size = new System.Drawing.Size(33, 19);
            this.lblTemp1.TabIndex = 11;
            this.lblTemp1.Text = "N/A";
            this.lblTemp1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lblTemp3
            // 
            this.lblTemp3.AutoSize = true;
            this.lblTemp3.Location = new System.Drawing.Point(200, 236);
            this.lblTemp3.Name = "lblTemp3";
            this.lblTemp3.Size = new System.Drawing.Size(33, 19);
            this.lblTemp3.TabIndex = 15;
            this.lblTemp3.Text = "N/A";
            this.lblTemp3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(23, 227);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(93, 38);
            this.lbl3.TabIndex = 14;
            this.lbl3.Text = "Black Body 3\r\nDireita Inferior";
            this.lbl3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lblTemp2
            // 
            this.lblTemp2.AutoSize = true;
            this.lblTemp2.Location = new System.Drawing.Point(200, 183);
            this.lblTemp2.Name = "lblTemp2";
            this.lblTemp2.Size = new System.Drawing.Size(33, 19);
            this.lblTemp2.TabIndex = 13;
            this.lblTemp2.Text = "N/A";
            this.lblTemp2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(23, 174);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(101, 38);
            this.lbl2.TabIndex = 12;
            this.lbl2.Text = "Black Body 2\r\nDireita Superior";
            this.lbl2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lblTemp7
            // 
            this.lblTemp7.AutoSize = true;
            this.lblTemp7.Location = new System.Drawing.Point(200, 409);
            this.lblTemp7.Name = "lblTemp7";
            this.lblTemp7.Size = new System.Drawing.Size(33, 19);
            this.lblTemp7.TabIndex = 23;
            this.lblTemp7.Text = "N/A";
            this.lblTemp7.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lbl7
            // 
            this.lbl7.AutoSize = true;
            this.lbl7.Location = new System.Drawing.Point(23, 409);
            this.lbl7.Name = "lbl7";
            this.lbl7.Size = new System.Drawing.Size(142, 19);
            this.lbl7.TabIndex = 22;
            this.lbl7.Text = "Dissipador Luminária 7";
            this.lbl7.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lblTemp6
            // 
            this.lblTemp6.AutoSize = true;
            this.lblTemp6.Location = new System.Drawing.Point(200, 374);
            this.lblTemp6.Name = "lblTemp6";
            this.lblTemp6.Size = new System.Drawing.Size(33, 19);
            this.lblTemp6.TabIndex = 21;
            this.lblTemp6.Text = "N/A";
            this.lblTemp6.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.Location = new System.Drawing.Point(23, 374);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(139, 19);
            this.lbl6.TabIndex = 20;
            this.lbl6.Text = "Guarda de Proteção 6";
            this.lbl6.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lblTemp5
            // 
            this.lblTemp5.AutoSize = true;
            this.lblTemp5.Location = new System.Drawing.Point(200, 328);
            this.lblTemp5.Name = "lblTemp5";
            this.lblTemp5.Size = new System.Drawing.Size(33, 19);
            this.lblTemp5.TabIndex = 19;
            this.lblTemp5.Text = "N/A";
            this.lblTemp5.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Location = new System.Drawing.Point(23, 328);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(84, 38);
            this.lbl5.TabIndex = 18;
            this.lbl5.Text = "Black Body 5\r\nCentro";
            this.lbl5.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lblTemp4
            // 
            this.lblTemp4.AutoSize = true;
            this.lblTemp4.Location = new System.Drawing.Point(200, 285);
            this.lblTemp4.Name = "lblTemp4";
            this.lblTemp4.Size = new System.Drawing.Size(33, 19);
            this.lblTemp4.TabIndex = 17;
            this.lblTemp4.Text = "N/A";
            this.lblTemp4.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(23, 275);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(109, 38);
            this.lbl4.TabIndex = 16;
            this.lbl4.Text = "Black Body 4\r\nEsquerda Inferior";
            this.lbl4.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lblTemp10
            // 
            this.lblTemp10.AutoSize = true;
            this.lblTemp10.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblTemp10.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblTemp10.Location = new System.Drawing.Point(195, 552);
            this.lblTemp10.Name = "lblTemp10";
            this.lblTemp10.Size = new System.Drawing.Size(44, 25);
            this.lblTemp10.TabIndex = 29;
            this.lblTemp10.Text = "N/A";
            this.lblTemp10.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lbl10
            // 
            this.lbl10.AutoSize = true;
            this.lbl10.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbl10.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbl10.Location = new System.Drawing.Point(23, 536);
            this.lbl10.Name = "lbl10";
            this.lbl10.Size = new System.Drawing.Size(117, 50);
            this.lbl10.TabIndex = 28;
            this.lbl10.Text = "Temperatura \r\nAmbiente 10";
            this.lbl10.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lblTemp9
            // 
            this.lblTemp9.AutoSize = true;
            this.lblTemp9.Location = new System.Drawing.Point(200, 500);
            this.lblTemp9.Name = "lblTemp9";
            this.lblTemp9.Size = new System.Drawing.Size(33, 19);
            this.lblTemp9.TabIndex = 27;
            this.lblTemp9.Text = "N/A";
            this.lblTemp9.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lbl9
            // 
            this.lbl9.AutoSize = true;
            this.lbl9.Location = new System.Drawing.Point(23, 500);
            this.lbl9.Name = "lbl9";
            this.lbl9.Size = new System.Drawing.Size(103, 19);
            this.lbl9.TabIndex = 26;
            this.lbl9.Text = "Filtro de Linha 9";
            this.lbl9.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lblTemp8
            // 
            this.lblTemp8.AutoSize = true;
            this.lblTemp8.Location = new System.Drawing.Point(200, 445);
            this.lblTemp8.Name = "lblTemp8";
            this.lblTemp8.Size = new System.Drawing.Size(33, 19);
            this.lblTemp8.TabIndex = 25;
            this.lblTemp8.Text = "N/A";
            this.lblTemp8.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // lbl8
            // 
            this.lbl8.AutoSize = true;
            this.lbl8.Location = new System.Drawing.Point(24, 445);
            this.lbl8.Name = "lbl8";
            this.lbl8.Size = new System.Drawing.Size(82, 38);
            this.lbl8.TabIndex = 24;
            this.lbl8.Text = "Louça da\r\nResistencia 8";
            this.lbl8.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // DAQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1195, 610);
            this.Controls.Add(this.lblTemp10);
            this.Controls.Add(this.lbl10);
            this.Controls.Add(this.lblTemp9);
            this.Controls.Add(this.lbl9);
            this.Controls.Add(this.lblTemp8);
            this.Controls.Add(this.lbl8);
            this.Controls.Add(this.lblTemp7);
            this.Controls.Add(this.lbl7);
            this.Controls.Add(this.lblTemp6);
            this.Controls.Add(this.lbl6);
            this.Controls.Add(this.lblTemp5);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.lblTemp4);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lblTemp3);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lblTemp2);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lblTemp1);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.lblTemperature);
            this.Controls.Add(this.lblSensor);
            this.Controls.Add(this.WebBrwsr);
            this.Controls.Add(this.btnDaqStop);
            this.Controls.Add(this.lblDaqTimer);
            this.Controls.Add(this.chkDAQ_SaveFIle);
            this.Controls.Add(this.btnDaqStart);
            this.Controls.Add(this.ChrtTemp);
            this.Name = "DAQ";
            this.Text = "D.A.Q TEST";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.Load += new System.EventHandler(this.DAQ_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ChrtTemp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChrtTemp;
        private MetroFramework.Controls.MetroButton btnDaqStart;
        private MetroFramework.Controls.MetroCheckBox chkDAQ_SaveFIle;
        private MetroFramework.Controls.MetroLabel lblDaqTimer;
        private MetroFramework.Controls.MetroButton btnDaqStop;
        private System.Windows.Forms.WebBrowser WebBrwsr;
        private MetroFramework.Controls.MetroLabel lblSensor;
        private MetroFramework.Controls.MetroLabel lblTemperature;
        private MetroFramework.Controls.MetroLabel lbl1;
        private MetroFramework.Controls.MetroLabel lblTemp1;
        private MetroFramework.Controls.MetroLabel lblTemp3;
        private MetroFramework.Controls.MetroLabel lbl3;
        private MetroFramework.Controls.MetroLabel lblTemp2;
        private MetroFramework.Controls.MetroLabel lbl2;
        private MetroFramework.Controls.MetroLabel lblTemp7;
        private MetroFramework.Controls.MetroLabel lbl7;
        private MetroFramework.Controls.MetroLabel lblTemp6;
        private MetroFramework.Controls.MetroLabel lbl6;
        private MetroFramework.Controls.MetroLabel lblTemp5;
        private MetroFramework.Controls.MetroLabel lbl5;
        private MetroFramework.Controls.MetroLabel lblTemp4;
        private MetroFramework.Controls.MetroLabel lbl4;
        private MetroFramework.Controls.MetroLabel lblTemp10;
        private MetroFramework.Controls.MetroLabel lbl10;
        private MetroFramework.Controls.MetroLabel lblTemp9;
        private MetroFramework.Controls.MetroLabel lbl9;
        private MetroFramework.Controls.MetroLabel lblTemp8;
        private MetroFramework.Controls.MetroLabel lbl8;
    }
}