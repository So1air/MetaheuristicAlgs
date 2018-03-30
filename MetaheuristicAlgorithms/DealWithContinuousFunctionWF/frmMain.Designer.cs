namespace DealWithContinuousFunctionWF
{
    partial class frmMain
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.grB_SettingsStart = new System.Windows.Forms.GroupBox();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.lblSizeSwarm = new System.Windows.Forms.Label();
            this.lblDimension = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.lblInertia = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txB_Global = new System.Windows.Forms.TextBox();
            this.txB_Personal = new System.Windows.Forms.TextBox();
            this.txB_Inertia = new System.Windows.Forms.TextBox();
            this.btnAddNewFitFunc = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.cmB_FitnessFunc = new System.Windows.Forms.ComboBox();
            this.lblPersonal = new System.Windows.Forms.Label();
            this.lblSocial = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.chtDemoState = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblCurrSolution = new System.Windows.Forms.Label();
            this.lblValueCurrSolution = new System.Windows.Forms.Label();
            this.btnNextIteration = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.grB_SettingsStart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtDemoState)).BeginInit();
            this.SuspendLayout();
            // 
            // grB_SettingsStart
            // 
            this.grB_SettingsStart.Controls.Add(this.numericUpDown2);
            this.grB_SettingsStart.Controls.Add(this.lblSizeSwarm);
            this.grB_SettingsStart.Controls.Add(this.lblDimension);
            this.grB_SettingsStart.Controls.Add(this.numericUpDown1);
            this.grB_SettingsStart.Controls.Add(this.textBox4);
            this.grB_SettingsStart.Controls.Add(this.textBox5);
            this.grB_SettingsStart.Controls.Add(this.textBox6);
            this.grB_SettingsStart.Controls.Add(this.lblInertia);
            this.grB_SettingsStart.Controls.Add(this.lblStatus);
            this.grB_SettingsStart.Controls.Add(this.txB_Global);
            this.grB_SettingsStart.Controls.Add(this.txB_Personal);
            this.grB_SettingsStart.Controls.Add(this.txB_Inertia);
            this.grB_SettingsStart.Controls.Add(this.btnAddNewFitFunc);
            this.grB_SettingsStart.Controls.Add(this.btnRun);
            this.grB_SettingsStart.Controls.Add(this.cmB_FitnessFunc);
            this.grB_SettingsStart.Controls.Add(this.lblPersonal);
            this.grB_SettingsStart.Controls.Add(this.lblSocial);
            this.grB_SettingsStart.Controls.Add(this.label7);
            this.grB_SettingsStart.Controls.Add(this.label8);
            this.grB_SettingsStart.Controls.Add(this.label9);
            this.grB_SettingsStart.Location = new System.Drawing.Point(12, 12);
            this.grB_SettingsStart.Name = "grB_SettingsStart";
            this.grB_SettingsStart.Size = new System.Drawing.Size(275, 257);
            this.grB_SettingsStart.TabIndex = 0;
            this.grB_SettingsStart.TabStop = false;
            this.grB_SettingsStart.Text = "Налаштування запуску";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(105, 87);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(61, 20);
            this.numericUpDown2.TabIndex = 22;
            // 
            // lblSizeSwarm
            // 
            this.lblSizeSwarm.AutoSize = true;
            this.lblSizeSwarm.Location = new System.Drawing.Point(6, 89);
            this.lblSizeSwarm.Name = "lblSizeSwarm";
            this.lblSizeSwarm.Size = new System.Drawing.Size(93, 13);
            this.lblSizeSwarm.TabIndex = 21;
            this.lblSizeSwarm.Text = "Кількість часток:";
            // 
            // lblDimension
            // 
            this.lblDimension.AutoSize = true;
            this.lblDimension.Location = new System.Drawing.Point(132, 62);
            this.lblDimension.Name = "lblDimension";
            this.lblDimension.Size = new System.Drawing.Size(70, 13);
            this.lblDimension.TabIndex = 20;
            this.lblDimension.Text = "Розмірність:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(208, 60);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(61, 20);
            this.numericUpDown1.TabIndex = 19;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(183, 191);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(86, 20);
            this.textBox4.TabIndex = 15;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(183, 167);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(86, 20);
            this.textBox5.TabIndex = 14;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(183, 143);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(86, 20);
            this.textBox6.TabIndex = 13;
            // 
            // lblInertia
            // 
            this.lblInertia.AutoSize = true;
            this.lblInertia.Location = new System.Drawing.Point(6, 146);
            this.lblInertia.Name = "lblInertia";
            this.lblInertia.Size = new System.Drawing.Size(27, 13);
            this.lblInertia.TabIndex = 12;
            this.lblInertia.Text = "w = ";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(68, 217);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(9, 13);
            this.lblStatus.TabIndex = 9;
            this.lblStatus.Text = "l";
            // 
            // txB_Global
            // 
            this.txB_Global.Location = new System.Drawing.Point(47, 191);
            this.txB_Global.Name = "txB_Global";
            this.txB_Global.Size = new System.Drawing.Size(86, 20);
            this.txB_Global.TabIndex = 8;
            // 
            // txB_Personal
            // 
            this.txB_Personal.Location = new System.Drawing.Point(47, 167);
            this.txB_Personal.Name = "txB_Personal";
            this.txB_Personal.Size = new System.Drawing.Size(86, 20);
            this.txB_Personal.TabIndex = 7;
            // 
            // txB_Inertia
            // 
            this.txB_Inertia.Location = new System.Drawing.Point(47, 143);
            this.txB_Inertia.Name = "txB_Inertia";
            this.txB_Inertia.Size = new System.Drawing.Size(86, 20);
            this.txB_Inertia.TabIndex = 6;
            // 
            // btnAddNewFitFunc
            // 
            this.btnAddNewFitFunc.Location = new System.Drawing.Point(200, 31);
            this.btnAddNewFitFunc.Name = "btnAddNewFitFunc";
            this.btnAddNewFitFunc.Size = new System.Drawing.Size(69, 23);
            this.btnAddNewFitFunc.TabIndex = 5;
            this.btnAddNewFitFunc.Text = "+";
            this.btnAddNewFitFunc.UseVisualStyleBackColor = true;
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(194, 212);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 23);
            this.btnRun.TabIndex = 1;
            this.btnRun.Text = "Старт";
            this.btnRun.UseVisualStyleBackColor = true;
            // 
            // cmB_FitnessFunc
            // 
            this.cmB_FitnessFunc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmB_FitnessFunc.FormattingEnabled = true;
            this.cmB_FitnessFunc.Items.AddRange(new object[] {
            "Сферична",
            "Еліптична"});
            this.cmB_FitnessFunc.Location = new System.Drawing.Point(6, 32);
            this.cmB_FitnessFunc.Name = "cmB_FitnessFunc";
            this.cmB_FitnessFunc.Size = new System.Drawing.Size(188, 21);
            this.cmB_FitnessFunc.TabIndex = 0;
            // 
            // lblPersonal
            // 
            this.lblPersonal.AutoSize = true;
            this.lblPersonal.Location = new System.Drawing.Point(6, 170);
            this.lblPersonal.Name = "lblPersonal";
            this.lblPersonal.Size = new System.Drawing.Size(46, 13);
            this.lblPersonal.TabIndex = 11;
            this.lblPersonal.Text = "cPers = ";
            // 
            // lblSocial
            // 
            this.lblSocial.AutoSize = true;
            this.lblSocial.Location = new System.Drawing.Point(6, 195);
            this.lblSocial.Name = "lblSocial";
            this.lblSocial.Size = new System.Drawing.Size(44, 13);
            this.lblSocial.TabIndex = 10;
            this.lblSocial.Text = "cSoc = ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(142, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "cGlob = ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(138, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "StSize = ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(134, 195);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "maxIter = ";
            // 
            // chtDemoState
            // 
            this.chtDemoState.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.DimGray;
            chartArea1.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.Color.Gray;
            chartArea1.AxisX.MajorTickMark.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.AxisX.MajorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.AcrossAxis;
            chartArea1.AxisX.MinorGrid.Enabled = true;
            chartArea1.AxisX.MinorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea1.AxisX.MinorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.AxisX.MinorTickMark.Enabled = true;
            chartArea1.AxisX.MinorTickMark.LineColor = System.Drawing.Color.LightGray;
            chartArea1.AxisX.MinorTickMark.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.AxisX.MinorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.InsideArea;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.DimGray;
            chartArea1.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.AxisY.MajorTickMark.LineColor = System.Drawing.Color.Gray;
            chartArea1.AxisY.MajorTickMark.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.AxisY.MajorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.AcrossAxis;
            chartArea1.AxisY.MinorGrid.Enabled = true;
            chartArea1.AxisY.MinorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea1.AxisY.MinorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.AxisY.MinorTickMark.Enabled = true;
            chartArea1.AxisY.MinorTickMark.LineColor = System.Drawing.Color.LightGray;
            chartArea1.AxisY.MinorTickMark.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.AxisY.MinorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.InsideArea;
            chartArea1.CursorX.LineColor = System.Drawing.Color.MintCream;
            chartArea1.CursorX.SelectionColor = System.Drawing.Color.Honeydew;
            chartArea1.CursorY.LineColor = System.Drawing.Color.LightGoldenrodYellow;
            chartArea1.CursorY.SelectionColor = System.Drawing.Color.Honeydew;
            chartArea1.Name = "chaMain";
            chartArea1.ShadowColor = System.Drawing.Color.Gainsboro;
            this.chtDemoState.ChartAreas.Add(chartArea1);
            this.chtDemoState.Location = new System.Drawing.Point(293, 12);
            this.chtDemoState.Name = "chtDemoState";
            series1.ChartArea = "chaMain";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series1.Color = System.Drawing.Color.YellowGreen;
            series1.Name = "srsParticles";
            series2.ChartArea = "chaMain";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series2.Color = System.Drawing.Color.Lime;
            series2.Name = "srsDirections";
            this.chtDemoState.Series.Add(series1);
            this.chtDemoState.Series.Add(series2);
            this.chtDemoState.Size = new System.Drawing.Size(682, 318);
            this.chtDemoState.TabIndex = 1;
            // 
            // lblCurrSolution
            // 
            this.lblCurrSolution.AutoSize = true;
            this.lblCurrSolution.Location = new System.Drawing.Point(290, 333);
            this.lblCurrSolution.Name = "lblCurrSolution";
            this.lblCurrSolution.Size = new System.Drawing.Size(95, 13);
            this.lblCurrSolution.TabIndex = 2;
            this.lblCurrSolution.Text = "Поточне рішення:";
            // 
            // lblValueCurrSolution
            // 
            this.lblValueCurrSolution.AutoSize = true;
            this.lblValueCurrSolution.Location = new System.Drawing.Point(290, 346);
            this.lblValueCurrSolution.Name = "lblValueCurrSolution";
            this.lblValueCurrSolution.Size = new System.Drawing.Size(9, 13);
            this.lblValueCurrSolution.TabIndex = 3;
            this.lblValueCurrSolution.Text = "l";
            // 
            // btnNextIteration
            // 
            this.btnNextIteration.Location = new System.Drawing.Point(497, 333);
            this.btnNextIteration.Name = "btnNextIteration";
            this.btnNextIteration.Size = new System.Drawing.Size(75, 23);
            this.btnNextIteration.TabIndex = 4;
            this.btnNextIteration.Text = "Наступна";
            this.btnNextIteration.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(821, 333);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(740, 333);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(659, 333);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 7;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(578, 333);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 8;
            this.button6.Text = "Завершити";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1000, 455);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnNextIteration);
            this.Controls.Add(this.lblValueCurrSolution);
            this.Controls.Add(this.lblCurrSolution);
            this.Controls.Add(this.chtDemoState);
            this.Controls.Add(this.grB_SettingsStart);
            this.Name = "frmMain";
            this.Text = "Демонстрація алгоритму рою часток для випадку багатовимірної неперервної цілової " +
    "функції";
            this.grB_SettingsStart.ResumeLayout(false);
            this.grB_SettingsStart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtDemoState)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grB_SettingsStart;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label lblInertia;
        private System.Windows.Forms.Label lblPersonal;
        private System.Windows.Forms.Label lblSocial;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txB_Global;
        private System.Windows.Forms.TextBox txB_Personal;
        private System.Windows.Forms.TextBox txB_Inertia;
        private System.Windows.Forms.Button btnAddNewFitFunc;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.ComboBox cmB_FitnessFunc;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtDemoState;
        private System.Windows.Forms.Label lblCurrSolution;
        private System.Windows.Forms.Label lblValueCurrSolution;
        private System.Windows.Forms.Button btnNextIteration;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label lblSizeSwarm;
        private System.Windows.Forms.Label lblDimension;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

