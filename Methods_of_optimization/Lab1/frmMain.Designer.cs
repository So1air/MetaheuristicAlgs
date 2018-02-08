namespace Lab1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.grB_FunctionSettings = new System.Windows.Forms.GroupBox();
            this.btnCancelAddition = new System.Windows.Forms.Button();
            this.btnAddFunction = new System.Windows.Forms.Button();
            this.lblFunction = new System.Windows.Forms.Label();
            this.lbl_eps = new System.Windows.Forms.Label();
            this.lbl_b = new System.Windows.Forms.Label();
            this.lbl_a = new System.Windows.Forms.Label();
            this.txB_eps = new System.Windows.Forms.TextBox();
            this.txB_b = new System.Windows.Forms.TextBox();
            this.txB_a = new System.Windows.Forms.TextBox();
            this.cmB_Functions = new System.Windows.Forms.ComboBox();
            this.grB_ViewOfResults = new System.Windows.Forms.GroupBox();
            this.dGV_ResultCalculation = new System.Windows.Forms.DataGridView();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblInfoAboutCalculation = new System.Windows.Forms.Label();
            this.rdB_max = new System.Windows.Forms.RadioButton();
            this.rdB_min = new System.Windows.Forms.RadioButton();
            this.chtGraphOfFunction = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.clnNumIteration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cln_a_k = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cln_b_k = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnLjambda_k = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnMju_k = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnFLjambda_k = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnFMju_k = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grB_FunctionSettings.SuspendLayout();
            this.grB_ViewOfResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_ResultCalculation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtGraphOfFunction)).BeginInit();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // grB_FunctionSettings
            // 
            this.grB_FunctionSettings.Controls.Add(this.btnCancelAddition);
            this.grB_FunctionSettings.Controls.Add(this.btnAddFunction);
            this.grB_FunctionSettings.Controls.Add(this.lblFunction);
            this.grB_FunctionSettings.Controls.Add(this.lbl_eps);
            this.grB_FunctionSettings.Controls.Add(this.lbl_b);
            this.grB_FunctionSettings.Controls.Add(this.lbl_a);
            this.grB_FunctionSettings.Controls.Add(this.txB_eps);
            this.grB_FunctionSettings.Controls.Add(this.txB_b);
            this.grB_FunctionSettings.Controls.Add(this.txB_a);
            this.grB_FunctionSettings.Controls.Add(this.cmB_Functions);
            this.grB_FunctionSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.grB_FunctionSettings.Location = new System.Drawing.Point(0, 0);
            this.grB_FunctionSettings.Margin = new System.Windows.Forms.Padding(10);
            this.grB_FunctionSettings.Name = "grB_FunctionSettings";
            this.grB_FunctionSettings.Padding = new System.Windows.Forms.Padding(10);
            this.grB_FunctionSettings.Size = new System.Drawing.Size(639, 121);
            this.grB_FunctionSettings.TabIndex = 0;
            this.grB_FunctionSettings.TabStop = false;
            this.grB_FunctionSettings.Text = "Установки для функції";
            // 
            // btnCancelAddition
            // 
            this.btnCancelAddition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelAddition.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelAddition.Location = new System.Drawing.Point(515, 41);
            this.btnCancelAddition.Name = "btnCancelAddition";
            this.btnCancelAddition.Size = new System.Drawing.Size(106, 23);
            this.btnCancelAddition.TabIndex = 9;
            this.btnCancelAddition.Text = "Відмінити";
            this.btnCancelAddition.UseVisualStyleBackColor = true;
            this.btnCancelAddition.Visible = false;
            this.btnCancelAddition.Click += new System.EventHandler(this.btnCancelAddition_Click);
            // 
            // btnAddFunction
            // 
            this.btnAddFunction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddFunction.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddFunction.Location = new System.Drawing.Point(515, 12);
            this.btnAddFunction.Name = "btnAddFunction";
            this.btnAddFunction.Size = new System.Drawing.Size(106, 23);
            this.btnAddFunction.TabIndex = 8;
            this.btnAddFunction.Text = "Додати";
            this.btnAddFunction.UseVisualStyleBackColor = true;
            this.btnAddFunction.Click += new System.EventHandler(this.btnAddFunction_Click);
            // 
            // lblFunction
            // 
            this.lblFunction.AutoSize = true;
            this.lblFunction.Location = new System.Drawing.Point(12, 29);
            this.lblFunction.Name = "lblFunction";
            this.lblFunction.Size = new System.Drawing.Size(42, 16);
            this.lblFunction.TabIndex = 7;
            this.lblFunction.Text = "f(x) = ";
            // 
            // lbl_eps
            // 
            this.lbl_eps.AutoSize = true;
            this.lbl_eps.Location = new System.Drawing.Point(76, 89);
            this.lbl_eps.Name = "lbl_eps";
            this.lbl_eps.Size = new System.Drawing.Size(41, 16);
            this.lbl_eps.TabIndex = 6;
            this.lbl_eps.Text = "eps =";
            // 
            // lbl_b
            // 
            this.lbl_b.AutoSize = true;
            this.lbl_b.Location = new System.Drawing.Point(163, 56);
            this.lbl_b.Name = "lbl_b";
            this.lbl_b.Size = new System.Drawing.Size(27, 16);
            this.lbl_b.TabIndex = 5;
            this.lbl_b.Text = "b =";
            // 
            // lbl_a
            // 
            this.lbl_a.AutoSize = true;
            this.lbl_a.Location = new System.Drawing.Point(43, 56);
            this.lbl_a.Name = "lbl_a";
            this.lbl_a.Size = new System.Drawing.Size(27, 16);
            this.lbl_a.TabIndex = 4;
            this.lbl_a.Text = "a =";
            // 
            // txB_eps
            // 
            this.txB_eps.Location = new System.Drawing.Point(123, 86);
            this.txB_eps.Name = "txB_eps";
            this.txB_eps.Size = new System.Drawing.Size(88, 22);
            this.txB_eps.TabIndex = 3;
            this.txB_eps.Validated += new System.EventHandler(this.txB_eps_Validated);
            // 
            // txB_b
            // 
            this.txB_b.Location = new System.Drawing.Point(196, 53);
            this.txB_b.Name = "txB_b";
            this.txB_b.Size = new System.Drawing.Size(67, 22);
            this.txB_b.TabIndex = 2;
            this.txB_b.Validated += new System.EventHandler(this.txB_b_Validated);
            // 
            // txB_a
            // 
            this.txB_a.Location = new System.Drawing.Point(76, 53);
            this.txB_a.Name = "txB_a";
            this.txB_a.Size = new System.Drawing.Size(63, 22);
            this.txB_a.TabIndex = 1;
            this.txB_a.Validated += new System.EventHandler(this.txB_a_Validated);
            // 
            // cmB_Functions
            // 
            this.cmB_Functions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmB_Functions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmB_Functions.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmB_Functions.FormattingEnabled = true;
            this.cmB_Functions.Location = new System.Drawing.Point(55, 26);
            this.cmB_Functions.Name = "cmB_Functions";
            this.cmB_Functions.Size = new System.Drawing.Size(442, 24);
            this.cmB_Functions.TabIndex = 0;
            this.cmB_Functions.SelectedIndexChanged += new System.EventHandler(this.cmB_Functions_SelectedIndexChanged);
            // 
            // grB_ViewOfResults
            // 
            this.grB_ViewOfResults.Controls.Add(this.dGV_ResultCalculation);
            this.grB_ViewOfResults.Controls.Add(this.btnCalculate);
            this.grB_ViewOfResults.Controls.Add(this.lblInfoAboutCalculation);
            this.grB_ViewOfResults.Controls.Add(this.rdB_max);
            this.grB_ViewOfResults.Controls.Add(this.rdB_min);
            this.grB_ViewOfResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grB_ViewOfResults.Location = new System.Drawing.Point(0, 121);
            this.grB_ViewOfResults.Name = "grB_ViewOfResults";
            this.grB_ViewOfResults.Size = new System.Drawing.Size(639, 419);
            this.grB_ViewOfResults.TabIndex = 1;
            this.grB_ViewOfResults.TabStop = false;
            this.grB_ViewOfResults.Text = "Знаходження екстремуму";
            // 
            // dGV_ResultCalculation
            // 
            this.dGV_ResultCalculation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGV_ResultCalculation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dGV_ResultCalculation.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dGV_ResultCalculation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_ResultCalculation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnNumIteration,
            this.cln_a_k,
            this.cln_b_k,
            this.clnLjambda_k,
            this.clnMju_k,
            this.clnFLjambda_k,
            this.clnFMju_k});
            this.dGV_ResultCalculation.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dGV_ResultCalculation.Location = new System.Drawing.Point(15, 74);
            this.dGV_ResultCalculation.MultiSelect = false;
            this.dGV_ResultCalculation.Name = "dGV_ResultCalculation";
            this.dGV_ResultCalculation.ReadOnly = true;
            this.dGV_ResultCalculation.RowHeadersVisible = false;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGV_ResultCalculation.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dGV_ResultCalculation.Size = new System.Drawing.Size(600, 296);
            this.dGV_ResultCalculation.TabIndex = 0;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCalculate.Location = new System.Drawing.Point(251, 376);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(364, 23);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Перерахувати";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblInfoAboutCalculation
            // 
            this.lblInfoAboutCalculation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInfoAboutCalculation.AutoSize = true;
            this.lblInfoAboutCalculation.Location = new System.Drawing.Point(13, 25);
            this.lblInfoAboutCalculation.MaximumSize = new System.Drawing.Size(600, 0);
            this.lblInfoAboutCalculation.Name = "lblInfoAboutCalculation";
            this.lblInfoAboutCalculation.Size = new System.Drawing.Size(512, 16);
            this.lblInfoAboutCalculation.TabIndex = 3;
            this.lblInfoAboutCalculation.Text = "Результати розрахунків [min|max] для функції <f(x)> на відрізку [a, b] з точністю" +
    " eps";
            // 
            // rdB_max
            // 
            this.rdB_max.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rdB_max.AutoSize = true;
            this.rdB_max.Location = new System.Drawing.Point(123, 376);
            this.rdB_max.Name = "rdB_max";
            this.rdB_max.Size = new System.Drawing.Size(98, 20);
            this.rdB_max.TabIndex = 2;
            this.rdB_max.Text = "шукати max";
            this.rdB_max.UseVisualStyleBackColor = true;
            // 
            // rdB_min
            // 
            this.rdB_min.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rdB_min.AutoSize = true;
            this.rdB_min.Checked = true;
            this.rdB_min.Location = new System.Drawing.Point(16, 376);
            this.rdB_min.Name = "rdB_min";
            this.rdB_min.Size = new System.Drawing.Size(94, 20);
            this.rdB_min.TabIndex = 1;
            this.rdB_min.TabStop = true;
            this.rdB_min.Text = "шукати min";
            this.rdB_min.UseVisualStyleBackColor = true;
            // 
            // chtGraphOfFunction
            // 
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.DimGray;
            chartArea2.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea2.AxisX.MajorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.AcrossAxis;
            chartArea2.AxisX.MinorGrid.Enabled = true;
            chartArea2.AxisX.MinorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea2.AxisX.MinorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea2.AxisX.MinorTickMark.Enabled = true;
            chartArea2.AxisX.MinorTickMark.LineColor = System.Drawing.Color.DimGray;
            chartArea2.AxisX.MinorTickMark.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea2.AxisX.MinorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.AcrossAxis;
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.DimGray;
            chartArea2.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea2.AxisY.MajorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.AcrossAxis;
            chartArea2.AxisY.MinorGrid.Enabled = true;
            chartArea2.AxisY.MinorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea2.AxisY.MinorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea2.AxisY.MinorTickMark.Enabled = true;
            chartArea2.AxisY.MinorTickMark.LineColor = System.Drawing.Color.DimGray;
            chartArea2.AxisY.MinorTickMark.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea2.AxisY.MinorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.AcrossAxis;
            chartArea2.Name = "ChartArea1";
            this.chtGraphOfFunction.ChartAreas.Add(chartArea2);
            this.chtGraphOfFunction.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend2.Name = "lgdGraphOfFunction";
            this.chtGraphOfFunction.Legends.Add(legend2);
            this.chtGraphOfFunction.Location = new System.Drawing.Point(639, 0);
            this.chtGraphOfFunction.Name = "chtGraphOfFunction";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.Legend = "lgdGraphOfFunction";
            series5.LegendText = "функція";
            series5.Name = "srsFunction";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastPoint;
            series6.Legend = "lgdGraphOfFunction";
            series6.LegendText = "знайдена точка extr м. дихотомії";
            series6.Name = "srsExtrPointHI";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series7.Legend = "lgdGraphOfFunction";
            series7.LegendText = "знайдена точка extr м. золотого перерізу";
            series7.Name = "srsExtrPointGS";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastPoint;
            series8.Legend = "lgdGraphOfFunction";
            series8.LegendText = "знайдена точка extr м. Фібоначчі";
            series8.Name = "srsExtrPointFb";
            this.chtGraphOfFunction.Series.Add(series5);
            this.chtGraphOfFunction.Series.Add(series6);
            this.chtGraphOfFunction.Series.Add(series7);
            this.chtGraphOfFunction.Series.Add(series8);
            this.chtGraphOfFunction.Size = new System.Drawing.Size(614, 540);
            this.chtGraphOfFunction.TabIndex = 2;
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.grB_ViewOfResults);
            this.pnlMain.Controls.Add(this.grB_FunctionSettings);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMain.Font = new System.Drawing.Font("Arial", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(639, 540);
            this.pnlMain.TabIndex = 3;
            // 
            // clnNumIteration
            // 
            this.clnNumIteration.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clnNumIteration.FillWeight = 50F;
            this.clnNumIteration.HeaderText = "k";
            this.clnNumIteration.Name = "clnNumIteration";
            this.clnNumIteration.ReadOnly = true;
            this.clnNumIteration.Width = 40;
            // 
            // cln_a_k
            // 
            this.cln_a_k.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cln_a_k.HeaderText = "aₖ";
            this.cln_a_k.Name = "cln_a_k";
            this.cln_a_k.ReadOnly = true;
            this.cln_a_k.Width = 44;
            // 
            // cln_b_k
            // 
            this.cln_b_k.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cln_b_k.HeaderText = "bₖ";
            this.cln_b_k.Name = "cln_b_k";
            this.cln_b_k.ReadOnly = true;
            this.cln_b_k.Width = 44;
            // 
            // clnLjambda_k
            // 
            this.clnLjambda_k.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clnLjambda_k.HeaderText = "λₖ";
            this.clnLjambda_k.Name = "clnLjambda_k";
            this.clnLjambda_k.ReadOnly = true;
            this.clnLjambda_k.Width = 44;
            // 
            // clnMju_k
            // 
            this.clnMju_k.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clnMju_k.HeaderText = "μₖ";
            this.clnMju_k.Name = "clnMju_k";
            this.clnMju_k.ReadOnly = true;
            this.clnMju_k.Width = 44;
            // 
            // clnFLjambda_k
            // 
            this.clnFLjambda_k.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clnFLjambda_k.HeaderText = "f(λₖ)";
            this.clnFLjambda_k.Name = "clnFLjambda_k";
            this.clnFLjambda_k.ReadOnly = true;
            this.clnFLjambda_k.Width = 55;
            // 
            // clnFMju_k
            // 
            this.clnFMju_k.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clnFMju_k.HeaderText = "f(μₖ)";
            this.clnFMju_k.Name = "clnFMju_k";
            this.clnFMju_k.ReadOnly = true;
            this.clnFMju_k.Width = 55;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 540);
            this.Controls.Add(this.chtGraphOfFunction);
            this.Controls.Add(this.pnlMain);
            this.Name = "frmMain";
            this.Text = "Знаходження мінімуму або максимуму функції на відрізку";
            this.grB_FunctionSettings.ResumeLayout(false);
            this.grB_FunctionSettings.PerformLayout();
            this.grB_ViewOfResults.ResumeLayout(false);
            this.grB_ViewOfResults.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_ResultCalculation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtGraphOfFunction)).EndInit();
            this.pnlMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grB_FunctionSettings;
        private System.Windows.Forms.GroupBox grB_ViewOfResults;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtGraphOfFunction;
        private System.Windows.Forms.Button btnCancelAddition;
        private System.Windows.Forms.Button btnAddFunction;
        private System.Windows.Forms.Label lblFunction;
        private System.Windows.Forms.Label lbl_eps;
        private System.Windows.Forms.Label lbl_b;
        private System.Windows.Forms.Label lbl_a;
        private System.Windows.Forms.TextBox txB_eps;
        private System.Windows.Forms.TextBox txB_b;
        private System.Windows.Forms.TextBox txB_a;
        private System.Windows.Forms.ComboBox cmB_Functions;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblInfoAboutCalculation;
        private System.Windows.Forms.RadioButton rdB_max;
        private System.Windows.Forms.RadioButton rdB_min;
        private System.Windows.Forms.DataGridView dGV_ResultCalculation;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNumIteration;
        private System.Windows.Forms.DataGridViewTextBoxColumn cln_a_k;
        private System.Windows.Forms.DataGridViewTextBoxColumn cln_b_k;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnLjambda_k;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnMju_k;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnFLjambda_k;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnFMju_k;
    }
}

