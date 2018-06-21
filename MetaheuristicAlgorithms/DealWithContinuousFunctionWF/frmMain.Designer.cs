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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.grB_SettingsStart = new System.Windows.Forms.GroupBox();
            this.lblRestrictions = new System.Windows.Forms.Label();
            this.dGV_Restrictions = new System.Windows.Forms.DataGridView();
            this.clnMinX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnMaxX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSwitchMinMax = new System.Windows.Forms.Button();
            this.lblSwitchMinMax = new System.Windows.Forms.Label();
            this.grB_SetParamsAlg = new System.Windows.Forms.GroupBox();
            this.lblCountStepsLocalSearch = new System.Windows.Forms.Label();
            this.nUD_CountStepsLocalSearch = new System.Windows.Forms.NumericUpDown();
            this.lblThreshold = new System.Windows.Forms.Label();
            this.lblMaxIterations = new System.Windows.Forms.Label();
            this.nUD_Threshold = new System.Windows.Forms.NumericUpDown();
            this.nUD_MaxIterations = new System.Windows.Forms.NumericUpDown();
            this.lblStepModification = new System.Windows.Forms.Label();
            this.cmB_StepModification = new System.Windows.Forms.ComboBox();
            this.lblGlobal = new System.Windows.Forms.Label();
            this.lblMinInformants = new System.Windows.Forms.Label();
            this.lblMaxInformants = new System.Windows.Forms.Label();
            this.lblInformants = new System.Windows.Forms.Label();
            this.nUD_MinInformants = new System.Windows.Forms.NumericUpDown();
            this.nUD_MaxInformants = new System.Windows.Forms.NumericUpDown();
            this.txB_Global = new System.Windows.Forms.TextBox();
            this.cmB_TypeTopology = new System.Windows.Forms.ComboBox();
            this.lblTypeTopology = new System.Windows.Forms.Label();
            this.lblSizeSwarm = new System.Windows.Forms.Label();
            this.lblInertia = new System.Windows.Forms.Label();
            this.nUD_SizeSwarm = new System.Windows.Forms.NumericUpDown();
            this.lblStepSize = new System.Windows.Forms.Label();
            this.lblSocial = new System.Windows.Forms.Label();
            this.lblPersonal = new System.Windows.Forms.Label();
            this.txB_StepSize = new System.Windows.Forms.TextBox();
            this.txB_Inertia = new System.Windows.Forms.TextBox();
            this.txB_Personal = new System.Windows.Forms.TextBox();
            this.txB_Social = new System.Windows.Forms.TextBox();
            this.lblFitnessFunc = new System.Windows.Forms.Label();
            this.lblDimension = new System.Windows.Forms.Label();
            this.nUD_Dimensionality = new System.Windows.Forms.NumericUpDown();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnAddNewFitFunc = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.cmB_FitnessFunc = new System.Windows.Forms.ComboBox();
            this.chtDemoState = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblCurrSolution = new System.Windows.Forms.Label();
            this.lblValueCurrSolution = new System.Windows.Forms.Label();
            this.btnNextIteration = new System.Windows.Forms.Button();
            this.btnToFinish = new System.Windows.Forms.Button();
            this.tbC_Main = new System.Windows.Forms.TabControl();
            this.tbP_SolvingOtimizationProblem = new System.Windows.Forms.TabPage();
            this.grB_DemoSolving = new System.Windows.Forms.GroupBox();
            this.lblCurrSettingsAlgorithm = new System.Windows.Forms.Label();
            this.lblCurrFitFunc = new System.Windows.Forms.Label();
            this.tbC_Visualization = new System.Windows.Forms.TabControl();
            this.tbP_VisualizationStateSolving = new System.Windows.Forms.TabPage();
            this.tbP_ = new System.Windows.Forms.TabPage();
            this.tbP__ = new System.Windows.Forms.TabPage();
            this.grB_SettingsStart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Restrictions)).BeginInit();
            this.grB_SetParamsAlg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_CountStepsLocalSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_Threshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_MaxIterations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_MinInformants)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_MaxInformants)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_SizeSwarm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_Dimensionality)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtDemoState)).BeginInit();
            this.tbC_Main.SuspendLayout();
            this.tbP_SolvingOtimizationProblem.SuspendLayout();
            this.grB_DemoSolving.SuspendLayout();
            this.tbC_Visualization.SuspendLayout();
            this.tbP_VisualizationStateSolving.SuspendLayout();
            this.SuspendLayout();
            // 
            // grB_SettingsStart
            // 
            this.grB_SettingsStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grB_SettingsStart.Controls.Add(this.lblRestrictions);
            this.grB_SettingsStart.Controls.Add(this.dGV_Restrictions);
            this.grB_SettingsStart.Controls.Add(this.btnSwitchMinMax);
            this.grB_SettingsStart.Controls.Add(this.lblSwitchMinMax);
            this.grB_SettingsStart.Controls.Add(this.grB_SetParamsAlg);
            this.grB_SettingsStart.Controls.Add(this.lblFitnessFunc);
            this.grB_SettingsStart.Controls.Add(this.lblDimension);
            this.grB_SettingsStart.Controls.Add(this.nUD_Dimensionality);
            this.grB_SettingsStart.Controls.Add(this.lblStatus);
            this.grB_SettingsStart.Controls.Add(this.btnAddNewFitFunc);
            this.grB_SettingsStart.Controls.Add(this.btnRun);
            this.grB_SettingsStart.Controls.Add(this.cmB_FitnessFunc);
            this.grB_SettingsStart.Location = new System.Drawing.Point(8, 6);
            this.grB_SettingsStart.Name = "grB_SettingsStart";
            this.grB_SettingsStart.Size = new System.Drawing.Size(353, 561);
            this.grB_SettingsStart.TabIndex = 0;
            this.grB_SettingsStart.TabStop = false;
            this.grB_SettingsStart.Text = "Налаштування запуску";
            // 
            // lblRestrictions
            // 
            this.lblRestrictions.AutoSize = true;
            this.lblRestrictions.Location = new System.Drawing.Point(6, 121);
            this.lblRestrictions.Name = "lblRestrictions";
            this.lblRestrictions.Size = new System.Drawing.Size(147, 13);
            this.lblRestrictions.TabIndex = 28;
            this.lblRestrictions.Text = "Обмеження на координати:";
            // 
            // dGV_Restrictions
            // 
            this.dGV_Restrictions.AllowUserToAddRows = false;
            this.dGV_Restrictions.AllowUserToDeleteRows = false;
            this.dGV_Restrictions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dGV_Restrictions.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dGV_Restrictions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Restrictions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnMinX,
            this.clnMaxX});
            this.dGV_Restrictions.Location = new System.Drawing.Point(6, 137);
            this.dGV_Restrictions.Name = "dGV_Restrictions";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGV_Restrictions.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dGV_Restrictions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dGV_Restrictions.Size = new System.Drawing.Size(338, 100);
            this.dGV_Restrictions.TabIndex = 27;
            this.dGV_Restrictions.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_Restrictions_CellValidated);
            // 
            // clnMinX
            // 
            this.clnMinX.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clnMinX.HeaderText = "min";
            this.clnMinX.Name = "clnMinX";
            this.clnMinX.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clnMaxX
            // 
            this.clnMaxX.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clnMaxX.HeaderText = "max";
            this.clnMaxX.Name = "clnMaxX";
            this.clnMaxX.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // btnSwitchMinMax
            // 
            this.btnSwitchMinMax.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSwitchMinMax.Location = new System.Drawing.Point(228, 68);
            this.btnSwitchMinMax.Name = "btnSwitchMinMax";
            this.btnSwitchMinMax.Size = new System.Drawing.Size(41, 20);
            this.btnSwitchMinMax.TabIndex = 26;
            this.btnSwitchMinMax.Text = "min";
            this.btnSwitchMinMax.UseVisualStyleBackColor = true;
            this.btnSwitchMinMax.Click += new System.EventHandler(this.btnSwitchMinMax_Click);
            // 
            // lblSwitchMinMax
            // 
            this.lblSwitchMinMax.AutoSize = true;
            this.lblSwitchMinMax.Location = new System.Drawing.Point(166, 72);
            this.lblSwitchMinMax.Name = "lblSwitchMinMax";
            this.lblSwitchMinMax.Size = new System.Drawing.Size(61, 13);
            this.lblSwitchMinMax.TabIndex = 25;
            this.lblSwitchMinMax.Text = "Задача на ";
            // 
            // grB_SetParamsAlg
            // 
            this.grB_SetParamsAlg.Controls.Add(this.lblCountStepsLocalSearch);
            this.grB_SetParamsAlg.Controls.Add(this.nUD_CountStepsLocalSearch);
            this.grB_SetParamsAlg.Controls.Add(this.lblThreshold);
            this.grB_SetParamsAlg.Controls.Add(this.lblMaxIterations);
            this.grB_SetParamsAlg.Controls.Add(this.nUD_Threshold);
            this.grB_SetParamsAlg.Controls.Add(this.nUD_MaxIterations);
            this.grB_SetParamsAlg.Controls.Add(this.lblStepModification);
            this.grB_SetParamsAlg.Controls.Add(this.cmB_StepModification);
            this.grB_SetParamsAlg.Controls.Add(this.lblGlobal);
            this.grB_SetParamsAlg.Controls.Add(this.lblMinInformants);
            this.grB_SetParamsAlg.Controls.Add(this.lblMaxInformants);
            this.grB_SetParamsAlg.Controls.Add(this.lblInformants);
            this.grB_SetParamsAlg.Controls.Add(this.nUD_MinInformants);
            this.grB_SetParamsAlg.Controls.Add(this.nUD_MaxInformants);
            this.grB_SetParamsAlg.Controls.Add(this.txB_Global);
            this.grB_SetParamsAlg.Controls.Add(this.cmB_TypeTopology);
            this.grB_SetParamsAlg.Controls.Add(this.lblTypeTopology);
            this.grB_SetParamsAlg.Controls.Add(this.lblSizeSwarm);
            this.grB_SetParamsAlg.Controls.Add(this.lblInertia);
            this.grB_SetParamsAlg.Controls.Add(this.nUD_SizeSwarm);
            this.grB_SetParamsAlg.Controls.Add(this.lblStepSize);
            this.grB_SetParamsAlg.Controls.Add(this.lblSocial);
            this.grB_SetParamsAlg.Controls.Add(this.lblPersonal);
            this.grB_SetParamsAlg.Controls.Add(this.txB_StepSize);
            this.grB_SetParamsAlg.Controls.Add(this.txB_Inertia);
            this.grB_SetParamsAlg.Controls.Add(this.txB_Personal);
            this.grB_SetParamsAlg.Controls.Add(this.txB_Social);
            this.grB_SetParamsAlg.Location = new System.Drawing.Point(6, 253);
            this.grB_SetParamsAlg.Name = "grB_SetParamsAlg";
            this.grB_SetParamsAlg.Size = new System.Drawing.Size(341, 247);
            this.grB_SetParamsAlg.TabIndex = 24;
            this.grB_SetParamsAlg.TabStop = false;
            this.grB_SetParamsAlg.Text = "Параметри алгоритму";
            // 
            // lblCountStepsLocalSearch
            // 
            this.lblCountStepsLocalSearch.AutoSize = true;
            this.lblCountStepsLocalSearch.Location = new System.Drawing.Point(24, 120);
            this.lblCountStepsLocalSearch.Name = "lblCountStepsLocalSearch";
            this.lblCountStepsLocalSearch.Size = new System.Drawing.Size(45, 13);
            this.lblCountStepsLocalSearch.TabIndex = 37;
            this.lblCountStepsLocalSearch.Text = "nstep = ";
            // 
            // nUD_CountStepsLocalSearch
            // 
            this.nUD_CountStepsLocalSearch.Location = new System.Drawing.Point(68, 118);
            this.nUD_CountStepsLocalSearch.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nUD_CountStepsLocalSearch.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nUD_CountStepsLocalSearch.Name = "nUD_CountStepsLocalSearch";
            this.nUD_CountStepsLocalSearch.Size = new System.Drawing.Size(79, 20);
            this.nUD_CountStepsLocalSearch.TabIndex = 36;
            this.nUD_CountStepsLocalSearch.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // lblThreshold
            // 
            this.lblThreshold.AutoSize = true;
            this.lblThreshold.Location = new System.Drawing.Point(31, 165);
            this.lblThreshold.Name = "lblThreshold";
            this.lblThreshold.Size = new System.Drawing.Size(62, 13);
            this.lblThreshold.TabIndex = 31;
            this.lblThreshold.Text = "threshold = ";
            // 
            // lblMaxIterations
            // 
            this.lblMaxIterations.AutoSize = true;
            this.lblMaxIterations.Location = new System.Drawing.Point(40, 210);
            this.lblMaxIterations.Name = "lblMaxIterations";
            this.lblMaxIterations.Size = new System.Drawing.Size(53, 13);
            this.lblMaxIterations.TabIndex = 16;
            this.lblMaxIterations.Text = "maxIter = ";
            this.lblMaxIterations.Visible = false;
            // 
            // nUD_Threshold
            // 
            this.nUD_Threshold.Location = new System.Drawing.Point(92, 164);
            this.nUD_Threshold.Name = "nUD_Threshold";
            this.nUD_Threshold.Size = new System.Drawing.Size(59, 20);
            this.nUD_Threshold.TabIndex = 35;
            // 
            // nUD_MaxIterations
            // 
            this.nUD_MaxIterations.Location = new System.Drawing.Point(92, 209);
            this.nUD_MaxIterations.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUD_MaxIterations.Name = "nUD_MaxIterations";
            this.nUD_MaxIterations.Size = new System.Drawing.Size(60, 20);
            this.nUD_MaxIterations.TabIndex = 34;
            this.nUD_MaxIterations.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUD_MaxIterations.Visible = false;
            // 
            // lblStepModification
            // 
            this.lblStepModification.AutoSize = true;
            this.lblStepModification.Location = new System.Drawing.Point(10, 73);
            this.lblStepModification.Name = "lblStepModification";
            this.lblStepModification.Size = new System.Drawing.Size(102, 13);
            this.lblStepModification.TabIndex = 33;
            this.lblStepModification.Text = "Модифікації кроку:";
            // 
            // cmB_StepModification
            // 
            this.cmB_StepModification.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmB_StepModification.FormattingEnabled = true;
            this.cmB_StepModification.Items.AddRange(new object[] {
            "<без модифікацій>",
            "Фіксоване дроблення (0; 1]",
            "Випадкове дроблення [-0,5; 0,5]",
            "Локальний пошук "});
            this.cmB_StepModification.Location = new System.Drawing.Point(12, 89);
            this.cmB_StepModification.Name = "cmB_StepModification";
            this.cmB_StepModification.Size = new System.Drawing.Size(198, 21);
            this.cmB_StepModification.TabIndex = 32;
            this.cmB_StepModification.SelectedIndexChanged += new System.EventHandler(this.cmB_StepModification_SelectedIndexChanged);
            // 
            // lblGlobal
            // 
            this.lblGlobal.AutoSize = true;
            this.lblGlobal.Location = new System.Drawing.Point(194, 223);
            this.lblGlobal.Name = "lblGlobal";
            this.lblGlobal.Size = new System.Drawing.Size(47, 13);
            this.lblGlobal.TabIndex = 18;
            this.lblGlobal.Text = "cGlob = ";
            // 
            // lblMinInformants
            // 
            this.lblMinInformants.AutoSize = true;
            this.lblMinInformants.Location = new System.Drawing.Point(242, 55);
            this.lblMinInformants.Name = "lblMinInformants";
            this.lblMinInformants.Size = new System.Drawing.Size(21, 13);
            this.lblMinInformants.TabIndex = 29;
            this.lblMinInformants.Text = "від";
            // 
            // lblMaxInformants
            // 
            this.lblMaxInformants.AutoSize = true;
            this.lblMaxInformants.Location = new System.Drawing.Point(244, 81);
            this.lblMaxInformants.Name = "lblMaxInformants";
            this.lblMaxInformants.Size = new System.Drawing.Size(19, 13);
            this.lblMaxInformants.TabIndex = 28;
            this.lblMaxInformants.Text = "до";
            // 
            // lblInformants
            // 
            this.lblInformants.AutoSize = true;
            this.lblInformants.Location = new System.Drawing.Point(246, 37);
            this.lblInformants.Name = "lblInformants";
            this.lblInformants.Size = new System.Drawing.Size(75, 13);
            this.lblInformants.TabIndex = 27;
            this.lblInformants.Text = "Інформаторів";
            // 
            // nUD_MinInformants
            // 
            this.nUD_MinInformants.Location = new System.Drawing.Point(269, 53);
            this.nUD_MinInformants.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nUD_MinInformants.Name = "nUD_MinInformants";
            this.nUD_MinInformants.Size = new System.Drawing.Size(66, 20);
            this.nUD_MinInformants.TabIndex = 26;
            this.nUD_MinInformants.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nUD_MinInformants.ValueChanged += new System.EventHandler(this.nUD_MinInformants_ValueChanged);
            // 
            // nUD_MaxInformants
            // 
            this.nUD_MaxInformants.Location = new System.Drawing.Point(269, 79);
            this.nUD_MaxInformants.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nUD_MaxInformants.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nUD_MaxInformants.Name = "nUD_MaxInformants";
            this.nUD_MaxInformants.Size = new System.Drawing.Size(66, 20);
            this.nUD_MaxInformants.TabIndex = 25;
            this.nUD_MaxInformants.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nUD_MaxInformants.ValueChanged += new System.EventHandler(this.nUD_MaxInformants_ValueChanged);
            // 
            // txB_Global
            // 
            this.txB_Global.Location = new System.Drawing.Point(239, 220);
            this.txB_Global.Name = "txB_Global";
            this.txB_Global.Size = new System.Drawing.Size(96, 20);
            this.txB_Global.TabIndex = 13;
            this.txB_Global.Validated += new System.EventHandler(this.txB_Global_Validated);
            // 
            // cmB_TypeTopology
            // 
            this.cmB_TypeTopology.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmB_TypeTopology.FormattingEnabled = true;
            this.cmB_TypeTopology.Location = new System.Drawing.Point(89, 47);
            this.cmB_TypeTopology.Name = "cmB_TypeTopology";
            this.cmB_TypeTopology.Size = new System.Drawing.Size(121, 21);
            this.cmB_TypeTopology.TabIndex = 24;
            this.cmB_TypeTopology.SelectedIndexChanged += new System.EventHandler(this.cmB_TypeTopology_SelectedIndexChanged);
            // 
            // lblTypeTopology
            // 
            this.lblTypeTopology.AutoSize = true;
            this.lblTypeTopology.Location = new System.Drawing.Point(6, 51);
            this.lblTypeTopology.Name = "lblTypeTopology";
            this.lblTypeTopology.Size = new System.Drawing.Size(77, 13);
            this.lblTypeTopology.TabIndex = 23;
            this.lblTypeTopology.Text = "Тип топології:";
            // 
            // lblSizeSwarm
            // 
            this.lblSizeSwarm.AutoSize = true;
            this.lblSizeSwarm.Location = new System.Drawing.Point(6, 19);
            this.lblSizeSwarm.Name = "lblSizeSwarm";
            this.lblSizeSwarm.Size = new System.Drawing.Size(93, 13);
            this.lblSizeSwarm.TabIndex = 21;
            this.lblSizeSwarm.Text = "Кількість часток:";
            // 
            // lblInertia
            // 
            this.lblInertia.AutoSize = true;
            this.lblInertia.Location = new System.Drawing.Point(198, 144);
            this.lblInertia.Name = "lblInertia";
            this.lblInertia.Size = new System.Drawing.Size(43, 13);
            this.lblInertia.TabIndex = 12;
            this.lblInertia.Text = "cIner = ";
            // 
            // nUD_SizeSwarm
            // 
            this.nUD_SizeSwarm.Location = new System.Drawing.Point(105, 17);
            this.nUD_SizeSwarm.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUD_SizeSwarm.Name = "nUD_SizeSwarm";
            this.nUD_SizeSwarm.Size = new System.Drawing.Size(105, 20);
            this.nUD_SizeSwarm.TabIndex = 22;
            this.nUD_SizeSwarm.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nUD_SizeSwarm.ValueChanged += new System.EventHandler(this.nUD_SizeSwarm_ValueChanged);
            // 
            // lblStepSize
            // 
            this.lblStepSize.AutoSize = true;
            this.lblStepSize.Location = new System.Drawing.Point(10, 116);
            this.lblStepSize.Name = "lblStepSize";
            this.lblStepSize.Size = new System.Drawing.Size(61, 13);
            this.lblStepSize.TabIndex = 17;
            this.lblStepSize.Text = "StepSize = ";
            // 
            // lblSocial
            // 
            this.lblSocial.AutoSize = true;
            this.lblSocial.Location = new System.Drawing.Point(197, 198);
            this.lblSocial.Name = "lblSocial";
            this.lblSocial.Size = new System.Drawing.Size(44, 13);
            this.lblSocial.TabIndex = 10;
            this.lblSocial.Text = "cSoc = ";
            // 
            // lblPersonal
            // 
            this.lblPersonal.AutoSize = true;
            this.lblPersonal.Location = new System.Drawing.Point(195, 171);
            this.lblPersonal.Name = "lblPersonal";
            this.lblPersonal.Size = new System.Drawing.Size(46, 13);
            this.lblPersonal.TabIndex = 11;
            this.lblPersonal.Text = "cPers = ";
            // 
            // txB_StepSize
            // 
            this.txB_StepSize.Location = new System.Drawing.Point(68, 113);
            this.txB_StepSize.Name = "txB_StepSize";
            this.txB_StepSize.Size = new System.Drawing.Size(79, 20);
            this.txB_StepSize.TabIndex = 14;
            this.txB_StepSize.Validated += new System.EventHandler(this.txB_StepSize_Validated);
            // 
            // txB_Inertia
            // 
            this.txB_Inertia.Location = new System.Drawing.Point(239, 141);
            this.txB_Inertia.Name = "txB_Inertia";
            this.txB_Inertia.Size = new System.Drawing.Size(96, 20);
            this.txB_Inertia.TabIndex = 6;
            this.txB_Inertia.Validated += new System.EventHandler(this.txB_Inertia_Validated);
            // 
            // txB_Personal
            // 
            this.txB_Personal.Location = new System.Drawing.Point(239, 167);
            this.txB_Personal.Name = "txB_Personal";
            this.txB_Personal.Size = new System.Drawing.Size(96, 20);
            this.txB_Personal.TabIndex = 7;
            this.txB_Personal.Validated += new System.EventHandler(this.txB_Personal_Validated);
            // 
            // txB_Social
            // 
            this.txB_Social.Location = new System.Drawing.Point(239, 195);
            this.txB_Social.Name = "txB_Social";
            this.txB_Social.Size = new System.Drawing.Size(96, 20);
            this.txB_Social.TabIndex = 8;
            this.txB_Social.Validated += new System.EventHandler(this.txB_Social_Validated);
            // 
            // lblFitnessFunc
            // 
            this.lblFitnessFunc.AutoSize = true;
            this.lblFitnessFunc.Location = new System.Drawing.Point(6, 22);
            this.lblFitnessFunc.Name = "lblFitnessFunc";
            this.lblFitnessFunc.Size = new System.Drawing.Size(92, 13);
            this.lblFitnessFunc.TabIndex = 23;
            this.lblFitnessFunc.Text = "Цільова функція:";
            // 
            // lblDimension
            // 
            this.lblDimension.AutoSize = true;
            this.lblDimension.Location = new System.Drawing.Point(6, 69);
            this.lblDimension.Name = "lblDimension";
            this.lblDimension.Size = new System.Drawing.Size(70, 13);
            this.lblDimension.TabIndex = 20;
            this.lblDimension.Text = "Розмірність:";
            // 
            // nUD_Dimensionality
            // 
            this.nUD_Dimensionality.Location = new System.Drawing.Point(82, 67);
            this.nUD_Dimensionality.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUD_Dimensionality.Name = "nUD_Dimensionality";
            this.nUD_Dimensionality.Size = new System.Drawing.Size(61, 20);
            this.nUD_Dimensionality.TabIndex = 19;
            this.nUD_Dimensionality.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUD_Dimensionality.ValueChanged += new System.EventHandler(this.nUD_Dimensionality_ValueChanged);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(6, 511);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(9, 13);
            this.lblStatus.TabIndex = 9;
            this.lblStatus.Text = "l";
            // 
            // btnAddNewFitFunc
            // 
            this.btnAddNewFitFunc.Location = new System.Drawing.Point(275, 37);
            this.btnAddNewFitFunc.Name = "btnAddNewFitFunc";
            this.btnAddNewFitFunc.Size = new System.Drawing.Size(69, 23);
            this.btnAddNewFitFunc.TabIndex = 5;
            this.btnAddNewFitFunc.Text = "+";
            this.btnAddNewFitFunc.UseVisualStyleBackColor = true;
            this.btnAddNewFitFunc.Click += new System.EventHandler(this.btnAddNewFitFunc_Click);
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(228, 508);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(119, 23);
            this.btnRun.TabIndex = 1;
            this.btnRun.Text = "Старт";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // cmB_FitnessFunc
            // 
            this.cmB_FitnessFunc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmB_FitnessFunc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmB_FitnessFunc.FormattingEnabled = true;
            this.cmB_FitnessFunc.Items.AddRange(new object[] {
            "Сферична",
            "Еліптична",
            "Швефела 1.2",
            "Розенброка",
            "Растрігіна",
            "Гривонка ",
            "Алпайна",
            "Швефела",
            "Аклея ",
            "Вейєрштраса"});
            this.cmB_FitnessFunc.Location = new System.Drawing.Point(6, 38);
            this.cmB_FitnessFunc.Name = "cmB_FitnessFunc";
            this.cmB_FitnessFunc.Size = new System.Drawing.Size(263, 21);
            this.cmB_FitnessFunc.TabIndex = 0;
            // 
            // chtDemoState
            // 
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
            this.chtDemoState.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chtDemoState.Location = new System.Drawing.Point(3, 3);
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
            this.chtDemoState.Size = new System.Drawing.Size(726, 347);
            this.chtDemoState.TabIndex = 1;
            // 
            // lblCurrSolution
            // 
            this.lblCurrSolution.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCurrSolution.AutoSize = true;
            this.lblCurrSolution.Location = new System.Drawing.Point(187, 518);
            this.lblCurrSolution.Name = "lblCurrSolution";
            this.lblCurrSolution.Size = new System.Drawing.Size(95, 13);
            this.lblCurrSolution.TabIndex = 2;
            this.lblCurrSolution.Text = "Поточне рішення:";
            // 
            // lblValueCurrSolution
            // 
            this.lblValueCurrSolution.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblValueCurrSolution.AutoSize = true;
            this.lblValueCurrSolution.Location = new System.Drawing.Point(299, 518);
            this.lblValueCurrSolution.Name = "lblValueCurrSolution";
            this.lblValueCurrSolution.Size = new System.Drawing.Size(9, 13);
            this.lblValueCurrSolution.TabIndex = 3;
            this.lblValueCurrSolution.Text = "l";
            // 
            // btnNextIteration
            // 
            this.btnNextIteration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNextIteration.Location = new System.Drawing.Point(6, 513);
            this.btnNextIteration.Name = "btnNextIteration";
            this.btnNextIteration.Size = new System.Drawing.Size(75, 42);
            this.btnNextIteration.TabIndex = 4;
            this.btnNextIteration.Text = "Наступна ітерація";
            this.btnNextIteration.UseVisualStyleBackColor = true;
            this.btnNextIteration.Click += new System.EventHandler(this.btnNextIteration_Click);
            // 
            // btnToFinish
            // 
            this.btnToFinish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnToFinish.Location = new System.Drawing.Point(95, 513);
            this.btnToFinish.Name = "btnToFinish";
            this.btnToFinish.Size = new System.Drawing.Size(75, 42);
            this.btnToFinish.TabIndex = 8;
            this.btnToFinish.Text = "Завершити";
            this.btnToFinish.UseVisualStyleBackColor = true;
            // 
            // tbC_Main
            // 
            this.tbC_Main.Controls.Add(this.tbP_SolvingOtimizationProblem);
            this.tbC_Main.Controls.Add(this.tbP__);
            this.tbC_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbC_Main.Location = new System.Drawing.Point(0, 0);
            this.tbC_Main.Name = "tbC_Main";
            this.tbC_Main.SelectedIndex = 0;
            this.tbC_Main.Size = new System.Drawing.Size(1124, 596);
            this.tbC_Main.TabIndex = 9;
            // 
            // tbP_SolvingOtimizationProblem
            // 
            this.tbP_SolvingOtimizationProblem.Controls.Add(this.grB_DemoSolving);
            this.tbP_SolvingOtimizationProblem.Controls.Add(this.grB_SettingsStart);
            this.tbP_SolvingOtimizationProblem.Location = new System.Drawing.Point(4, 22);
            this.tbP_SolvingOtimizationProblem.Name = "tbP_SolvingOtimizationProblem";
            this.tbP_SolvingOtimizationProblem.Padding = new System.Windows.Forms.Padding(3);
            this.tbP_SolvingOtimizationProblem.Size = new System.Drawing.Size(1116, 570);
            this.tbP_SolvingOtimizationProblem.TabIndex = 0;
            this.tbP_SolvingOtimizationProblem.Text = "Розв\'язання оптимізаційної задачі";
            this.tbP_SolvingOtimizationProblem.UseVisualStyleBackColor = true;
            // 
            // grB_DemoSolving
            // 
            this.grB_DemoSolving.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grB_DemoSolving.Controls.Add(this.lblCurrSettingsAlgorithm);
            this.grB_DemoSolving.Controls.Add(this.lblCurrFitFunc);
            this.grB_DemoSolving.Controls.Add(this.tbC_Visualization);
            this.grB_DemoSolving.Controls.Add(this.btnNextIteration);
            this.grB_DemoSolving.Controls.Add(this.btnToFinish);
            this.grB_DemoSolving.Controls.Add(this.lblValueCurrSolution);
            this.grB_DemoSolving.Controls.Add(this.lblCurrSolution);
            this.grB_DemoSolving.Location = new System.Drawing.Point(367, 6);
            this.grB_DemoSolving.Name = "grB_DemoSolving";
            this.grB_DemoSolving.Size = new System.Drawing.Size(746, 561);
            this.grB_DemoSolving.TabIndex = 9;
            this.grB_DemoSolving.TabStop = false;
            this.grB_DemoSolving.Text = "Демонстрація процесу розв\'язання";
            // 
            // lblCurrSettingsAlgorithm
            // 
            this.lblCurrSettingsAlgorithm.AutoSize = true;
            this.lblCurrSettingsAlgorithm.Location = new System.Drawing.Point(10, 46);
            this.lblCurrSettingsAlgorithm.Name = "lblCurrSettingsAlgorithm";
            this.lblCurrSettingsAlgorithm.Size = new System.Drawing.Size(9, 13);
            this.lblCurrSettingsAlgorithm.TabIndex = 11;
            this.lblCurrSettingsAlgorithm.Text = "l";
            // 
            // lblCurrFitFunc
            // 
            this.lblCurrFitFunc.AutoSize = true;
            this.lblCurrFitFunc.Location = new System.Drawing.Point(10, 26);
            this.lblCurrFitFunc.Name = "lblCurrFitFunc";
            this.lblCurrFitFunc.Size = new System.Drawing.Size(9, 13);
            this.lblCurrFitFunc.TabIndex = 10;
            this.lblCurrFitFunc.Text = "l";
            // 
            // tbC_Visualization
            // 
            this.tbC_Visualization.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbC_Visualization.Controls.Add(this.tbP_VisualizationStateSolving);
            this.tbC_Visualization.Controls.Add(this.tbP_);
            this.tbC_Visualization.Location = new System.Drawing.Point(6, 121);
            this.tbC_Visualization.Name = "tbC_Visualization";
            this.tbC_Visualization.SelectedIndex = 0;
            this.tbC_Visualization.Size = new System.Drawing.Size(740, 379);
            this.tbC_Visualization.TabIndex = 9;
            // 
            // tbP_VisualizationStateSolving
            // 
            this.tbP_VisualizationStateSolving.Controls.Add(this.chtDemoState);
            this.tbP_VisualizationStateSolving.Location = new System.Drawing.Point(4, 22);
            this.tbP_VisualizationStateSolving.Name = "tbP_VisualizationStateSolving";
            this.tbP_VisualizationStateSolving.Padding = new System.Windows.Forms.Padding(3);
            this.tbP_VisualizationStateSolving.Size = new System.Drawing.Size(732, 353);
            this.tbP_VisualizationStateSolving.TabIndex = 0;
            this.tbP_VisualizationStateSolving.Text = "Візуалізація поточного стану розв\'язанння задачі ";
            this.tbP_VisualizationStateSolving.UseVisualStyleBackColor = true;
            // 
            // tbP_
            // 
            this.tbP_.Location = new System.Drawing.Point(4, 22);
            this.tbP_.Name = "tbP_";
            this.tbP_.Padding = new System.Windows.Forms.Padding(3);
            this.tbP_.Size = new System.Drawing.Size(726, 283);
            this.tbP_.TabIndex = 1;
            this.tbP_.UseVisualStyleBackColor = true;
            // 
            // tbP__
            // 
            this.tbP__.Location = new System.Drawing.Point(4, 22);
            this.tbP__.Name = "tbP__";
            this.tbP__.Padding = new System.Windows.Forms.Padding(3);
            this.tbP__.Size = new System.Drawing.Size(1116, 570);
            this.tbP__.TabIndex = 1;
            this.tbP__.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1124, 596);
            this.Controls.Add(this.tbC_Main);
            this.Name = "frmMain";
            this.Text = "Демонстрація алгоритму рою часток для випадку багатовимірної неперервної цільової" +
    " функції";
            this.grB_SettingsStart.ResumeLayout(false);
            this.grB_SettingsStart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Restrictions)).EndInit();
            this.grB_SetParamsAlg.ResumeLayout(false);
            this.grB_SetParamsAlg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_CountStepsLocalSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_Threshold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_MaxIterations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_MinInformants)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_MaxInformants)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_SizeSwarm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_Dimensionality)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtDemoState)).EndInit();
            this.tbC_Main.ResumeLayout(false);
            this.tbP_SolvingOtimizationProblem.ResumeLayout(false);
            this.grB_DemoSolving.ResumeLayout(false);
            this.grB_DemoSolving.PerformLayout();
            this.tbC_Visualization.ResumeLayout(false);
            this.tbP_VisualizationStateSolving.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grB_SettingsStart;
        private System.Windows.Forms.Label lblGlobal;
        private System.Windows.Forms.Label lblStepSize;
        private System.Windows.Forms.Label lblMaxIterations;
        private System.Windows.Forms.TextBox txB_StepSize;
        private System.Windows.Forms.TextBox txB_Global;
        private System.Windows.Forms.Label lblInertia;
        private System.Windows.Forms.Label lblPersonal;
        private System.Windows.Forms.Label lblSocial;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txB_Social;
        private System.Windows.Forms.TextBox txB_Personal;
        private System.Windows.Forms.TextBox txB_Inertia;
        private System.Windows.Forms.Button btnAddNewFitFunc;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.ComboBox cmB_FitnessFunc;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtDemoState;
        private System.Windows.Forms.Label lblCurrSolution;
        private System.Windows.Forms.Label lblValueCurrSolution;
        private System.Windows.Forms.Button btnNextIteration;
        private System.Windows.Forms.Button btnToFinish;
        private System.Windows.Forms.NumericUpDown nUD_SizeSwarm;
        private System.Windows.Forms.Label lblSizeSwarm;
        private System.Windows.Forms.Label lblDimension;
        private System.Windows.Forms.NumericUpDown nUD_Dimensionality;
        private System.Windows.Forms.TabControl tbC_Main;
        private System.Windows.Forms.TabPage tbP_SolvingOtimizationProblem;
        private System.Windows.Forms.GroupBox grB_DemoSolving;
        private System.Windows.Forms.Label lblCurrSettingsAlgorithm;
        private System.Windows.Forms.Label lblCurrFitFunc;
        private System.Windows.Forms.TabControl tbC_Visualization;
        private System.Windows.Forms.TabPage tbP_VisualizationStateSolving;
        private System.Windows.Forms.TabPage tbP_;
        private System.Windows.Forms.TabPage tbP__;
        private System.Windows.Forms.Button btnSwitchMinMax;
        private System.Windows.Forms.Label lblSwitchMinMax;
        private System.Windows.Forms.GroupBox grB_SetParamsAlg;
        private System.Windows.Forms.Label lblFitnessFunc;
        private System.Windows.Forms.Label lblRestrictions;
        private System.Windows.Forms.DataGridView dGV_Restrictions;
        private System.Windows.Forms.ComboBox cmB_TypeTopology;
        private System.Windows.Forms.Label lblTypeTopology;
        private System.Windows.Forms.Label lblThreshold;
        private System.Windows.Forms.Label lblMinInformants;
        private System.Windows.Forms.Label lblMaxInformants;
        private System.Windows.Forms.Label lblInformants;
        private System.Windows.Forms.NumericUpDown nUD_MinInformants;
        private System.Windows.Forms.NumericUpDown nUD_MaxInformants;
        private System.Windows.Forms.Label lblStepModification;
        private System.Windows.Forms.ComboBox cmB_StepModification;
        private System.Windows.Forms.NumericUpDown nUD_Threshold;
        private System.Windows.Forms.NumericUpDown nUD_MaxIterations;
        private System.Windows.Forms.Label lblCountStepsLocalSearch;
        private System.Windows.Forms.NumericUpDown nUD_CountStepsLocalSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnMinX;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnMaxX;
    }
}

