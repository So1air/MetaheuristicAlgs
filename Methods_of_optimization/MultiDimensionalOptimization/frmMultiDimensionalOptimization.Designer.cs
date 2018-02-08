namespace MultiDimensionalOptimization
{
    partial class frmMultiDimensionalOptimization
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
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tbC_Main = new System.Windows.Forms.TabControl();
            this.tbP_First = new System.Windows.Forms.TabPage();
            this.grB_SettingsOptimization = new System.Windows.Forms.GroupBox();
            this.grB_CharacteristicOtherFunc = new System.Windows.Forms.GroupBox();
            this.dGV_Hessian = new System.Windows.Forms.DataGridView();
            this.dGV_Gradient = new System.Windows.Forms.DataGridView();
            this.clnDerivOnVariable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDerFunc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblHessian = new System.Windows.Forms.Label();
            this.lblGradient = new System.Windows.Forms.Label();
            this.grB_LinearConditions = new System.Windows.Forms.GroupBox();
            this.lbl_m = new System.Windows.Forms.Label();
            this.nUD_m = new System.Windows.Forms.NumericUpDown();
            this.lblConditionalType = new System.Windows.Forms.Label();
            this.dGV_MatrixA_and_Vector_b = new System.Windows.Forms.DataGridView();
            this.nUD_Dimensionality = new System.Windows.Forms.NumericUpDown();
            this.dGV_InitX = new System.Windows.Forms.DataGridView();
            this.txB_Eps = new System.Windows.Forms.TextBox();
            this.lbl_Eps = new System.Windows.Forms.Label();
            this.lbl_InitX = new System.Windows.Forms.Label();
            this.lbl_xDim = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnAddNewFunc = new System.Windows.Forms.Button();
            this.cmB_OtherFunc = new System.Windows.Forms.ComboBox();
            this.chB_ConditionalOptimization = new System.Windows.Forms.CheckBox();
            this.rdB_OtherFunc = new System.Windows.Forms.RadioButton();
            this.rdB_QuadraticFunc = new System.Windows.Forms.RadioButton();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.rdB_NonLinearFunc = new System.Windows.Forms.RadioButton();
            this.grB_Coefficients_abcde = new System.Windows.Forms.GroupBox();
            this.txB_b = new System.Windows.Forms.TextBox();
            this.txB_c = new System.Windows.Forms.TextBox();
            this.txB_d = new System.Windows.Forms.TextBox();
            this.txB_a = new System.Windows.Forms.TextBox();
            this.txB_e = new System.Windows.Forms.TextBox();
            this.lbl_e = new System.Windows.Forms.Label();
            this.lbl_d = new System.Windows.Forms.Label();
            this.lbl_c = new System.Windows.Forms.Label();
            this.lbl_b = new System.Windows.Forms.Label();
            this.lbl_a = new System.Windows.Forms.Label();
            this.chB_LabelDraw = new System.Windows.Forms.CheckBox();
            this.lblCoefSplit = new System.Windows.Forms.Label();
            this.txB_CoefSplit = new System.Windows.Forms.TextBox();
            this.txB_MaxAljfa = new System.Windows.Forms.TextBox();
            this.txB_InitStep = new System.Windows.Forms.TextBox();
            this.chB_MNewton = new System.Windows.Forms.CheckBox();
            this.chB_MConditionalGradient = new System.Windows.Forms.CheckBox();
            this.chB_GradMSplitStep = new System.Windows.Forms.CheckBox();
            this.chB_MSteepestDescent = new System.Windows.Forms.CheckBox();
            this.grB_Results = new System.Windows.Forms.GroupBox();
            this.lbl_InfoInit_and_Accuracy = new System.Windows.Forms.Label();
            this.dGV_Results = new System.Windows.Forms.DataGridView();
            this.clnMSD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnMSD_f = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnGMSS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnGMSS_f = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnMN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnMN_f = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCG_f = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_InfoLastCalcFunc = new System.Windows.Forms.Label();
            this.chtGraphics = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblMaxAljfa = new System.Windows.Forms.Label();
            this.lblInitStep = new System.Windows.Forms.Label();
            this.tbC_Main.SuspendLayout();
            this.tbP_First.SuspendLayout();
            this.grB_SettingsOptimization.SuspendLayout();
            this.grB_CharacteristicOtherFunc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Hessian)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Gradient)).BeginInit();
            this.grB_LinearConditions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_m)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_MatrixA_and_Vector_b)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_Dimensionality)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_InitX)).BeginInit();
            this.grB_Coefficients_abcde.SuspendLayout();
            this.grB_Results.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Results)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtGraphics)).BeginInit();
            this.SuspendLayout();
            // 
            // tbC_Main
            // 
            this.tbC_Main.Controls.Add(this.tbP_First);
            this.tbC_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbC_Main.Location = new System.Drawing.Point(0, 0);
            this.tbC_Main.Name = "tbC_Main";
            this.tbC_Main.SelectedIndex = 0;
            this.tbC_Main.Size = new System.Drawing.Size(1092, 631);
            this.tbC_Main.TabIndex = 0;
            // 
            // tbP_First
            // 
            this.tbP_First.Controls.Add(this.grB_SettingsOptimization);
            this.tbP_First.Controls.Add(this.chB_LabelDraw);
            this.tbP_First.Controls.Add(this.lblCoefSplit);
            this.tbP_First.Controls.Add(this.txB_CoefSplit);
            this.tbP_First.Controls.Add(this.txB_MaxAljfa);
            this.tbP_First.Controls.Add(this.txB_InitStep);
            this.tbP_First.Controls.Add(this.chB_MNewton);
            this.tbP_First.Controls.Add(this.chB_MConditionalGradient);
            this.tbP_First.Controls.Add(this.chB_GradMSplitStep);
            this.tbP_First.Controls.Add(this.chB_MSteepestDescent);
            this.tbP_First.Controls.Add(this.grB_Results);
            this.tbP_First.Controls.Add(this.chtGraphics);
            this.tbP_First.Controls.Add(this.lblMaxAljfa);
            this.tbP_First.Controls.Add(this.lblInitStep);
            this.tbP_First.Location = new System.Drawing.Point(4, 22);
            this.tbP_First.Name = "tbP_First";
            this.tbP_First.Padding = new System.Windows.Forms.Padding(3);
            this.tbP_First.Size = new System.Drawing.Size(1084, 605);
            this.tbP_First.TabIndex = 0;
            this.tbP_First.UseVisualStyleBackColor = true;
            // 
            // grB_SettingsOptimization
            // 
            this.grB_SettingsOptimization.Controls.Add(this.grB_CharacteristicOtherFunc);
            this.grB_SettingsOptimization.Controls.Add(this.grB_LinearConditions);
            this.grB_SettingsOptimization.Controls.Add(this.nUD_Dimensionality);
            this.grB_SettingsOptimization.Controls.Add(this.dGV_InitX);
            this.grB_SettingsOptimization.Controls.Add(this.txB_Eps);
            this.grB_SettingsOptimization.Controls.Add(this.lbl_Eps);
            this.grB_SettingsOptimization.Controls.Add(this.lbl_InitX);
            this.grB_SettingsOptimization.Controls.Add(this.lbl_xDim);
            this.grB_SettingsOptimization.Controls.Add(this.btnCalc);
            this.grB_SettingsOptimization.Controls.Add(this.btnAddNewFunc);
            this.grB_SettingsOptimization.Controls.Add(this.cmB_OtherFunc);
            this.grB_SettingsOptimization.Controls.Add(this.chB_ConditionalOptimization);
            this.grB_SettingsOptimization.Controls.Add(this.rdB_OtherFunc);
            this.grB_SettingsOptimization.Controls.Add(this.rdB_QuadraticFunc);
            this.grB_SettingsOptimization.Controls.Add(this.btnAccept);
            this.grB_SettingsOptimization.Controls.Add(this.btnCancel);
            this.grB_SettingsOptimization.Controls.Add(this.rdB_NonLinearFunc);
            this.grB_SettingsOptimization.Controls.Add(this.grB_Coefficients_abcde);
            this.grB_SettingsOptimization.Location = new System.Drawing.Point(8, 6);
            this.grB_SettingsOptimization.Name = "grB_SettingsOptimization";
            this.grB_SettingsOptimization.Size = new System.Drawing.Size(389, 369);
            this.grB_SettingsOptimization.TabIndex = 2;
            this.grB_SettingsOptimization.TabStop = false;
            this.grB_SettingsOptimization.Text = "Налаштування";
            // 
            // grB_CharacteristicOtherFunc
            // 
            this.grB_CharacteristicOtherFunc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grB_CharacteristicOtherFunc.Controls.Add(this.dGV_Hessian);
            this.grB_CharacteristicOtherFunc.Controls.Add(this.dGV_Gradient);
            this.grB_CharacteristicOtherFunc.Controls.Add(this.lblHessian);
            this.grB_CharacteristicOtherFunc.Controls.Add(this.lblGradient);
            this.grB_CharacteristicOtherFunc.Location = new System.Drawing.Point(6, 109);
            this.grB_CharacteristicOtherFunc.Name = "grB_CharacteristicOtherFunc";
            this.grB_CharacteristicOtherFunc.Size = new System.Drawing.Size(377, 124);
            this.grB_CharacteristicOtherFunc.TabIndex = 13;
            this.grB_CharacteristicOtherFunc.TabStop = false;
            this.grB_CharacteristicOtherFunc.Text = "Характеристика функції";
            this.grB_CharacteristicOtherFunc.Visible = false;
            // 
            // dGV_Hessian
            // 
            this.dGV_Hessian.AllowUserToAddRows = false;
            this.dGV_Hessian.AllowUserToDeleteRows = false;
            this.dGV_Hessian.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGV_Hessian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Hessian.Location = new System.Drawing.Point(154, 44);
            this.dGV_Hessian.Name = "dGV_Hessian";
            this.dGV_Hessian.ReadOnly = true;
            this.dGV_Hessian.Size = new System.Drawing.Size(217, 80);
            this.dGV_Hessian.TabIndex = 4;
            // 
            // dGV_Gradient
            // 
            this.dGV_Gradient.AllowUserToAddRows = false;
            this.dGV_Gradient.AllowUserToDeleteRows = false;
            this.dGV_Gradient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dGV_Gradient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dGV_Gradient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Gradient.ColumnHeadersVisible = false;
            this.dGV_Gradient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnDerivOnVariable,
            this.clnDerFunc});
            this.dGV_Gradient.Location = new System.Drawing.Point(0, 44);
            this.dGV_Gradient.Name = "dGV_Gradient";
            this.dGV_Gradient.ReadOnly = true;
            this.dGV_Gradient.RowHeadersVisible = false;
            this.dGV_Gradient.Size = new System.Drawing.Size(119, 80);
            this.dGV_Gradient.TabIndex = 3;
            // 
            // clnDerivOnVariable
            // 
            this.clnDerivOnVariable.HeaderText = "";
            this.clnDerivOnVariable.Name = "clnDerivOnVariable";
            this.clnDerivOnVariable.ReadOnly = true;
            this.clnDerivOnVariable.Width = 5;
            // 
            // clnDerFunc
            // 
            this.clnDerFunc.HeaderText = "";
            this.clnDerFunc.Name = "clnDerFunc";
            this.clnDerFunc.ReadOnly = true;
            this.clnDerFunc.Width = 5;
            // 
            // lblHessian
            // 
            this.lblHessian.AutoSize = true;
            this.lblHessian.Location = new System.Drawing.Point(151, 25);
            this.lblHessian.Name = "lblHessian";
            this.lblHessian.Size = new System.Drawing.Size(48, 13);
            this.lblHessian.TabIndex = 2;
            this.lblHessian.Text = "Гессіан:";
            // 
            // lblGradient
            // 
            this.lblGradient.AutoSize = true;
            this.lblGradient.Location = new System.Drawing.Point(0, 25);
            this.lblGradient.Name = "lblGradient";
            this.lblGradient.Size = new System.Drawing.Size(53, 13);
            this.lblGradient.TabIndex = 1;
            this.lblGradient.Text = "Градієнт:";
            // 
            // grB_LinearConditions
            // 
            this.grB_LinearConditions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grB_LinearConditions.Controls.Add(this.lbl_m);
            this.grB_LinearConditions.Controls.Add(this.nUD_m);
            this.grB_LinearConditions.Controls.Add(this.lblConditionalType);
            this.grB_LinearConditions.Controls.Add(this.dGV_MatrixA_and_Vector_b);
            this.grB_LinearConditions.Location = new System.Drawing.Point(5, 233);
            this.grB_LinearConditions.Name = "grB_LinearConditions";
            this.grB_LinearConditions.Size = new System.Drawing.Size(378, 71);
            this.grB_LinearConditions.TabIndex = 18;
            this.grB_LinearConditions.TabStop = false;
            this.grB_LinearConditions.Text = "Лінійні умови";
            this.grB_LinearConditions.Visible = false;
            // 
            // lbl_m
            // 
            this.lbl_m.AutoSize = true;
            this.lbl_m.Location = new System.Drawing.Point(7, 47);
            this.lbl_m.Name = "lbl_m";
            this.lbl_m.Size = new System.Drawing.Size(27, 13);
            this.lbl_m.TabIndex = 3;
            this.lbl_m.Text = "m = ";
            // 
            // nUD_m
            // 
            this.nUD_m.Location = new System.Drawing.Point(38, 45);
            this.nUD_m.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nUD_m.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nUD_m.Name = "nUD_m";
            this.nUD_m.Size = new System.Drawing.Size(39, 20);
            this.nUD_m.TabIndex = 2;
            this.nUD_m.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nUD_m.ValueChanged += new System.EventHandler(this.nUD_m_ValueChanged);
            // 
            // lblConditionalType
            // 
            this.lblConditionalType.AutoSize = true;
            this.lblConditionalType.Location = new System.Drawing.Point(11, 16);
            this.lblConditionalType.Name = "lblConditionalType";
            this.lblConditionalType.Size = new System.Drawing.Size(43, 13);
            this.lblConditionalType.TabIndex = 1;
            this.lblConditionalType.Text = "Ax <= b";
            // 
            // dGV_MatrixA_and_Vector_b
            // 
            this.dGV_MatrixA_and_Vector_b.AllowUserToAddRows = false;
            this.dGV_MatrixA_and_Vector_b.AllowUserToDeleteRows = false;
            this.dGV_MatrixA_and_Vector_b.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGV_MatrixA_and_Vector_b.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dGV_MatrixA_and_Vector_b.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_MatrixA_and_Vector_b.ColumnHeadersVisible = false;
            this.dGV_MatrixA_and_Vector_b.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dGV_MatrixA_and_Vector_b.Location = new System.Drawing.Point(91, 6);
            this.dGV_MatrixA_and_Vector_b.MultiSelect = false;
            this.dGV_MatrixA_and_Vector_b.Name = "dGV_MatrixA_and_Vector_b";
            this.dGV_MatrixA_and_Vector_b.RowHeadersVisible = false;
            this.dGV_MatrixA_and_Vector_b.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dGV_MatrixA_and_Vector_b.Size = new System.Drawing.Size(287, 65);
            this.dGV_MatrixA_and_Vector_b.TabIndex = 0;
            this.dGV_MatrixA_and_Vector_b.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_MatrixA_and_Vector_b_CellValidated);
            this.dGV_MatrixA_and_Vector_b.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dGV_MatrixA_and_Vector_b_KeyUp);
            // 
            // nUD_Dimensionality
            // 
            this.nUD_Dimensionality.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nUD_Dimensionality.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nUD_Dimensionality.Enabled = false;
            this.nUD_Dimensionality.Location = new System.Drawing.Point(324, 58);
            this.nUD_Dimensionality.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nUD_Dimensionality.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nUD_Dimensionality.Name = "nUD_Dimensionality";
            this.nUD_Dimensionality.Size = new System.Drawing.Size(40, 16);
            this.nUD_Dimensionality.TabIndex = 17;
            this.nUD_Dimensionality.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nUD_Dimensionality.ValueChanged += new System.EventHandler(this.nUD_Dimensionality_ValueChanged);
            // 
            // dGV_InitX
            // 
            this.dGV_InitX.AllowUserToAddRows = false;
            this.dGV_InitX.AllowUserToDeleteRows = false;
            this.dGV_InitX.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGV_InitX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_InitX.ColumnHeadersVisible = false;
            this.dGV_InitX.Location = new System.Drawing.Point(128, 304);
            this.dGV_InitX.Name = "dGV_InitX";
            this.dGV_InitX.RowHeadersVisible = false;
            this.dGV_InitX.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dGV_InitX.Size = new System.Drawing.Size(255, 37);
            this.dGV_InitX.TabIndex = 16;
            this.dGV_InitX.Validated += new System.EventHandler(this.dGV_InitX_Validated);
            // 
            // txB_Eps
            // 
            this.txB_Eps.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txB_Eps.Location = new System.Drawing.Point(76, 349);
            this.txB_Eps.Name = "txB_Eps";
            this.txB_Eps.Size = new System.Drawing.Size(100, 20);
            this.txB_Eps.TabIndex = 15;
            this.txB_Eps.Text = "0,0001";
            this.txB_Eps.Validated += new System.EventHandler(this.txB_Eps_Validated);
            // 
            // lbl_Eps
            // 
            this.lbl_Eps.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_Eps.AutoSize = true;
            this.lbl_Eps.Location = new System.Drawing.Point(6, 352);
            this.lbl_Eps.Name = "lbl_Eps";
            this.lbl_Eps.Size = new System.Drawing.Size(53, 13);
            this.lbl_Eps.TabIndex = 11;
            this.lbl_Eps.Text = "Точність:";
            // 
            // lbl_InitX
            // 
            this.lbl_InitX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_InitX.AutoSize = true;
            this.lbl_InitX.Location = new System.Drawing.Point(6, 310);
            this.lbl_InitX.Name = "lbl_InitX";
            this.lbl_InitX.Size = new System.Drawing.Size(116, 13);
            this.lbl_InitX.TabIndex = 10;
            this.lbl_InitX.Text = "Початковий вектор x:";
            // 
            // lbl_xDim
            // 
            this.lbl_xDim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_xDim.AutoSize = true;
            this.lbl_xDim.Font = new System.Drawing.Font("Gabriola", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_xDim.Location = new System.Drawing.Point(262, 60);
            this.lbl_xDim.Name = "lbl_xDim";
            this.lbl_xDim.Size = new System.Drawing.Size(74, 33);
            this.lbl_xDim.TabIndex = 9;
            this.lbl_xDim.Text = ",      x ∊  E ";
            // 
            // btnCalc
            // 
            this.btnCalc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCalc.Location = new System.Drawing.Point(204, 347);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(179, 23);
            this.btnCalc.TabIndex = 8;
            this.btnCalc.Text = "Провести обчислення";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnAddNewFunc
            // 
            this.btnAddNewFunc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNewFunc.Enabled = false;
            this.btnAddNewFunc.Location = new System.Drawing.Point(224, 67);
            this.btnAddNewFunc.Name = "btnAddNewFunc";
            this.btnAddNewFunc.Size = new System.Drawing.Size(34, 23);
            this.btnAddNewFunc.TabIndex = 5;
            this.btnAddNewFunc.Text = "+";
            this.btnAddNewFunc.UseVisualStyleBackColor = true;
            this.btnAddNewFunc.Click += new System.EventHandler(this.btnAddNewFunc_Click);
            // 
            // cmB_OtherFunc
            // 
            this.cmB_OtherFunc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmB_OtherFunc.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cmB_OtherFunc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmB_OtherFunc.Enabled = false;
            this.cmB_OtherFunc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmB_OtherFunc.FormattingEnabled = true;
            this.cmB_OtherFunc.Location = new System.Drawing.Point(58, 67);
            this.cmB_OtherFunc.Name = "cmB_OtherFunc";
            this.cmB_OtherFunc.Size = new System.Drawing.Size(160, 21);
            this.cmB_OtherFunc.TabIndex = 4;
            this.cmB_OtherFunc.SelectedValueChanged += new System.EventHandler(this.cmB_OtherFunc_SelectedValueChanged);
            // 
            // chB_ConditionalOptimization
            // 
            this.chB_ConditionalOptimization.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chB_ConditionalOptimization.AutoSize = true;
            this.chB_ConditionalOptimization.Location = new System.Drawing.Point(251, 20);
            this.chB_ConditionalOptimization.Name = "chB_ConditionalOptimization";
            this.chB_ConditionalOptimization.Size = new System.Drawing.Size(125, 17);
            this.chB_ConditionalOptimization.TabIndex = 3;
            this.chB_ConditionalOptimization.Text = "умовна оптимізація";
            this.chB_ConditionalOptimization.UseVisualStyleBackColor = true;
            this.chB_ConditionalOptimization.CheckedChanged += new System.EventHandler(this.chB_ConditionalOptimization_CheckedChanged);
            // 
            // rdB_OtherFunc
            // 
            this.rdB_OtherFunc.AutoSize = true;
            this.rdB_OtherFunc.Font = new System.Drawing.Font("Gabriola", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rdB_OtherFunc.Location = new System.Drawing.Point(6, 58);
            this.rdB_OtherFunc.Name = "rdB_OtherFunc";
            this.rdB_OtherFunc.Size = new System.Drawing.Size(65, 37);
            this.rdB_OtherFunc.TabIndex = 2;
            this.rdB_OtherFunc.Text = "f(x) = ";
            this.rdB_OtherFunc.UseVisualStyleBackColor = true;
            this.rdB_OtherFunc.CheckedChanged += new System.EventHandler(this.rdB_OtherFunc_CheckedChanged);
            // 
            // rdB_QuadraticFunc
            // 
            this.rdB_QuadraticFunc.AutoSize = true;
            this.rdB_QuadraticFunc.Checked = true;
            this.rdB_QuadraticFunc.Font = new System.Drawing.Font("Gabriola", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rdB_QuadraticFunc.Location = new System.Drawing.Point(6, 8);
            this.rdB_QuadraticFunc.Name = "rdB_QuadraticFunc";
            this.rdB_QuadraticFunc.Size = new System.Drawing.Size(244, 37);
            this.rdB_QuadraticFunc.TabIndex = 0;
            this.rdB_QuadraticFunc.TabStop = true;
            this.rdB_QuadraticFunc.Text = "f(x) = a x₁² + b x₁x₂ + c x₂² + d x₁ + e x₂";
            this.rdB_QuadraticFunc.UseVisualStyleBackColor = true;
            this.rdB_QuadraticFunc.CheckedChanged += new System.EventHandler(this.rdB_QuadraticFunc_CheckedChanged);
            // 
            // btnAccept
            // 
            this.btnAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAccept.Image = global::MultiDimensionalOptimization.Properties.Resources._480px_Yes_check_svg;
            this.btnAccept.Location = new System.Drawing.Point(224, 59);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(34, 23);
            this.btnAccept.TabIndex = 6;
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Visible = false;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Image = global::MultiDimensionalOptimization.Properties.Resources.incorrect_294245_960_720;
            this.btnCancel.Location = new System.Drawing.Point(224, 77);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(34, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // rdB_NonLinearFunc
            // 
            this.rdB_NonLinearFunc.AutoSize = true;
            this.rdB_NonLinearFunc.Font = new System.Drawing.Font("Gabriola", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rdB_NonLinearFunc.Location = new System.Drawing.Point(6, 33);
            this.rdB_NonLinearFunc.Name = "rdB_NonLinearFunc";
            this.rdB_NonLinearFunc.Size = new System.Drawing.Size(227, 37);
            this.rdB_NonLinearFunc.TabIndex = 1;
            this.rdB_NonLinearFunc.Text = "f(x) = a x₁ + b x₂ + exp(c x₁² + d x₂²)";
            this.rdB_NonLinearFunc.UseVisualStyleBackColor = true;
            this.rdB_NonLinearFunc.CheckedChanged += new System.EventHandler(this.rdB_NonLinearFunc_CheckedChanged);
            // 
            // grB_Coefficients_abcde
            // 
            this.grB_Coefficients_abcde.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grB_Coefficients_abcde.Controls.Add(this.txB_b);
            this.grB_Coefficients_abcde.Controls.Add(this.txB_c);
            this.grB_Coefficients_abcde.Controls.Add(this.txB_d);
            this.grB_Coefficients_abcde.Controls.Add(this.txB_a);
            this.grB_Coefficients_abcde.Controls.Add(this.txB_e);
            this.grB_Coefficients_abcde.Controls.Add(this.lbl_e);
            this.grB_Coefficients_abcde.Controls.Add(this.lbl_d);
            this.grB_Coefficients_abcde.Controls.Add(this.lbl_c);
            this.grB_Coefficients_abcde.Controls.Add(this.lbl_b);
            this.grB_Coefficients_abcde.Controls.Add(this.lbl_a);
            this.grB_Coefficients_abcde.Location = new System.Drawing.Point(6, 109);
            this.grB_Coefficients_abcde.Name = "grB_Coefficients_abcde";
            this.grB_Coefficients_abcde.Size = new System.Drawing.Size(377, 75);
            this.grB_Coefficients_abcde.TabIndex = 12;
            this.grB_Coefficients_abcde.TabStop = false;
            this.grB_Coefficients_abcde.Text = "Коефіцієнти";
            // 
            // txB_b
            // 
            this.txB_b.Location = new System.Drawing.Point(162, 22);
            this.txB_b.Name = "txB_b";
            this.txB_b.Size = new System.Drawing.Size(75, 20);
            this.txB_b.TabIndex = 18;
            this.txB_b.Text = "-2";
            this.txB_b.Validated += new System.EventHandler(this.txB_b_Validated);
            // 
            // txB_c
            // 
            this.txB_c.Location = new System.Drawing.Point(283, 22);
            this.txB_c.Name = "txB_c";
            this.txB_c.Size = new System.Drawing.Size(75, 20);
            this.txB_c.TabIndex = 17;
            this.txB_c.Text = "2";
            this.txB_c.Validated += new System.EventHandler(this.txB_c_Validated);
            // 
            // txB_d
            // 
            this.txB_d.Location = new System.Drawing.Point(84, 49);
            this.txB_d.Name = "txB_d";
            this.txB_d.Size = new System.Drawing.Size(75, 20);
            this.txB_d.TabIndex = 16;
            this.txB_d.Text = "2";
            this.txB_d.Validated += new System.EventHandler(this.txB_d_Validated);
            // 
            // txB_a
            // 
            this.txB_a.Location = new System.Drawing.Point(42, 22);
            this.txB_a.Name = "txB_a";
            this.txB_a.Size = new System.Drawing.Size(75, 20);
            this.txB_a.TabIndex = 15;
            this.txB_a.Text = "5";
            this.txB_a.Validated += new System.EventHandler(this.txB_a_Validated);
            // 
            // txB_e
            // 
            this.txB_e.Location = new System.Drawing.Point(210, 49);
            this.txB_e.Name = "txB_e";
            this.txB_e.Size = new System.Drawing.Size(75, 20);
            this.txB_e.TabIndex = 14;
            this.txB_e.Text = "3";
            this.txB_e.Validated += new System.EventHandler(this.txB_e_Validated);
            // 
            // lbl_e
            // 
            this.lbl_e.AutoSize = true;
            this.lbl_e.Font = new System.Drawing.Font("Gabriola", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_e.Location = new System.Drawing.Point(184, 43);
            this.lbl_e.Name = "lbl_e";
            this.lbl_e.Size = new System.Drawing.Size(34, 33);
            this.lbl_e.TabIndex = 4;
            this.lbl_e.Text = "e = ";
            // 
            // lbl_d
            // 
            this.lbl_d.AutoSize = true;
            this.lbl_d.Font = new System.Drawing.Font("Gabriola", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_d.Location = new System.Drawing.Point(57, 43);
            this.lbl_d.Name = "lbl_d";
            this.lbl_d.Size = new System.Drawing.Size(36, 33);
            this.lbl_d.TabIndex = 3;
            this.lbl_d.Text = "d = ";
            // 
            // lbl_c
            // 
            this.lbl_c.AutoSize = true;
            this.lbl_c.Font = new System.Drawing.Font("Gabriola", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_c.Location = new System.Drawing.Point(258, 16);
            this.lbl_c.Name = "lbl_c";
            this.lbl_c.Size = new System.Drawing.Size(34, 33);
            this.lbl_c.TabIndex = 2;
            this.lbl_c.Text = "c = ";
            // 
            // lbl_b
            // 
            this.lbl_b.AutoSize = true;
            this.lbl_b.Font = new System.Drawing.Font("Gabriola", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_b.Location = new System.Drawing.Point(135, 16);
            this.lbl_b.Name = "lbl_b";
            this.lbl_b.Size = new System.Drawing.Size(35, 33);
            this.lbl_b.TabIndex = 1;
            this.lbl_b.Text = "b = ";
            // 
            // lbl_a
            // 
            this.lbl_a.AutoSize = true;
            this.lbl_a.Font = new System.Drawing.Font("Gabriola", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_a.Location = new System.Drawing.Point(16, 16);
            this.lbl_a.Name = "lbl_a";
            this.lbl_a.Size = new System.Drawing.Size(31, 33);
            this.lbl_a.TabIndex = 0;
            this.lbl_a.Text = "a =";
            // 
            // chB_LabelDraw
            // 
            this.chB_LabelDraw.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chB_LabelDraw.AutoSize = true;
            this.chB_LabelDraw.Checked = true;
            this.chB_LabelDraw.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chB_LabelDraw.Location = new System.Drawing.Point(977, 559);
            this.chB_LabelDraw.Name = "chB_LabelDraw";
            this.chB_LabelDraw.Size = new System.Drawing.Size(64, 17);
            this.chB_LabelDraw.TabIndex = 22;
            this.chB_LabelDraw.Text = "підписи";
            this.chB_LabelDraw.UseVisualStyleBackColor = true;
            // 
            // lblCoefSplit
            // 
            this.lblCoefSplit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCoefSplit.AutoSize = true;
            this.lblCoefSplit.Location = new System.Drawing.Point(711, 580);
            this.lblCoefSplit.Name = "lblCoefSplit";
            this.lblCoefSplit.Size = new System.Drawing.Size(24, 13);
            this.lblCoefSplit.TabIndex = 21;
            this.lblCoefSplit.Text = "λ = ";
            // 
            // txB_CoefSplit
            // 
            this.txB_CoefSplit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txB_CoefSplit.Location = new System.Drawing.Point(735, 577);
            this.txB_CoefSplit.Name = "txB_CoefSplit";
            this.txB_CoefSplit.Size = new System.Drawing.Size(75, 20);
            this.txB_CoefSplit.TabIndex = 18;
            this.txB_CoefSplit.Text = "0,5";
            this.txB_CoefSplit.Validated += new System.EventHandler(this.txB_CoefSplit_Validated);
            // 
            // txB_MaxAljfa
            // 
            this.txB_MaxAljfa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txB_MaxAljfa.Location = new System.Drawing.Point(453, 577);
            this.txB_MaxAljfa.Name = "txB_MaxAljfa";
            this.txB_MaxAljfa.Size = new System.Drawing.Size(75, 20);
            this.txB_MaxAljfa.TabIndex = 17;
            this.txB_MaxAljfa.Text = "10";
            this.txB_MaxAljfa.Validated += new System.EventHandler(this.txB_MaxAljfa_Validated);
            // 
            // txB_InitStep
            // 
            this.txB_InitStep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txB_InitStep.Location = new System.Drawing.Point(600, 577);
            this.txB_InitStep.Name = "txB_InitStep";
            this.txB_InitStep.Size = new System.Drawing.Size(75, 20);
            this.txB_InitStep.TabIndex = 16;
            this.txB_InitStep.Text = "10";
            this.txB_InitStep.Validated += new System.EventHandler(this.txB_InitStep_Validated);
            // 
            // chB_MNewton
            // 
            this.chB_MNewton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chB_MNewton.AutoSize = true;
            this.chB_MNewton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.chB_MNewton.Checked = true;
            this.chB_MNewton.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chB_MNewton.Location = new System.Drawing.Point(823, 559);
            this.chB_MNewton.Name = "chB_MNewton";
            this.chB_MNewton.Size = new System.Drawing.Size(85, 17);
            this.chB_MNewton.TabIndex = 7;
            this.chB_MNewton.Text = "м. Ньютона";
            this.chB_MNewton.UseVisualStyleBackColor = false;
            this.chB_MNewton.CheckedChanged += new System.EventHandler(this.chB_MNewton_CheckedChanged);
            // 
            // chB_MConditionalGradient
            // 
            this.chB_MConditionalGradient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chB_MConditionalGradient.AutoSize = true;
            this.chB_MConditionalGradient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.chB_MConditionalGradient.Checked = true;
            this.chB_MConditionalGradient.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chB_MConditionalGradient.Location = new System.Drawing.Point(837, 578);
            this.chB_MConditionalGradient.Name = "chB_MConditionalGradient";
            this.chB_MConditionalGradient.Size = new System.Drawing.Size(139, 17);
            this.chB_MConditionalGradient.TabIndex = 6;
            this.chB_MConditionalGradient.Text = "м. умовного градієнта";
            this.chB_MConditionalGradient.UseVisualStyleBackColor = false;
            this.chB_MConditionalGradient.CheckedChanged += new System.EventHandler(this.chB_MConditionalGradient_CheckedChanged);
            // 
            // chB_GradMSplitStep
            // 
            this.chB_GradMSplitStep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chB_GradMSplitStep.AutoSize = true;
            this.chB_GradMSplitStep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.chB_GradMSplitStep.Checked = true;
            this.chB_GradMSplitStep.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chB_GradMSplitStep.Location = new System.Drawing.Point(560, 559);
            this.chB_GradMSplitStep.Name = "chB_GradMSplitStep";
            this.chB_GradMSplitStep.Size = new System.Drawing.Size(203, 17);
            this.chB_GradMSplitStep.TabIndex = 5;
            this.chB_GradMSplitStep.Text = "градієтний м. з дробленням кроку ";
            this.chB_GradMSplitStep.UseVisualStyleBackColor = false;
            this.chB_GradMSplitStep.CheckedChanged += new System.EventHandler(this.chB_GradMSplitStep_CheckedChanged);
            // 
            // chB_MSteepestDescent
            // 
            this.chB_MSteepestDescent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chB_MSteepestDescent.AutoSize = true;
            this.chB_MSteepestDescent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chB_MSteepestDescent.Checked = true;
            this.chB_MSteepestDescent.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chB_MSteepestDescent.Location = new System.Drawing.Point(403, 559);
            this.chB_MSteepestDescent.Name = "chB_MSteepestDescent";
            this.chB_MSteepestDescent.Size = new System.Drawing.Size(146, 17);
            this.chB_MSteepestDescent.TabIndex = 4;
            this.chB_MSteepestDescent.Text = "м. найшвидшого спуску";
            this.chB_MSteepestDescent.UseVisualStyleBackColor = false;
            this.chB_MSteepestDescent.CheckedChanged += new System.EventHandler(this.chB_MSteepestDescent_CheckedChanged);
            // 
            // grB_Results
            // 
            this.grB_Results.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grB_Results.Controls.Add(this.lbl_InfoInit_and_Accuracy);
            this.grB_Results.Controls.Add(this.dGV_Results);
            this.grB_Results.Controls.Add(this.lbl_InfoLastCalcFunc);
            this.grB_Results.Location = new System.Drawing.Point(8, 381);
            this.grB_Results.Name = "grB_Results";
            this.grB_Results.Size = new System.Drawing.Size(389, 216);
            this.grB_Results.TabIndex = 3;
            this.grB_Results.TabStop = false;
            this.grB_Results.Text = "Результати останніх обчислень";
            // 
            // lbl_InfoInit_and_Accuracy
            // 
            this.lbl_InfoInit_and_Accuracy.AutoSize = true;
            this.lbl_InfoInit_and_Accuracy.Location = new System.Drawing.Point(6, 38);
            this.lbl_InfoInit_and_Accuracy.MaximumSize = new System.Drawing.Size(380, 13);
            this.lbl_InfoInit_and_Accuracy.Name = "lbl_InfoInit_and_Accuracy";
            this.lbl_InfoInit_and_Accuracy.Size = new System.Drawing.Size(9, 13);
            this.lbl_InfoInit_and_Accuracy.TabIndex = 5;
            this.lbl_InfoInit_and_Accuracy.Text = "l";
            // 
            // dGV_Results
            // 
            this.dGV_Results.AllowUserToAddRows = false;
            this.dGV_Results.AllowUserToDeleteRows = false;
            this.dGV_Results.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGV_Results.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dGV_Results.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dGV_Results.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Results.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnMSD,
            this.clnMSD_f,
            this.clnGMSS,
            this.clnGMSS_f,
            this.clnMN,
            this.clnMN_f,
            this.clnCG,
            this.clnCG_f});
            this.dGV_Results.Location = new System.Drawing.Point(9, 54);
            this.dGV_Results.Name = "dGV_Results";
            this.dGV_Results.ReadOnly = true;
            this.dGV_Results.Size = new System.Drawing.Size(374, 156);
            this.dGV_Results.TabIndex = 4;
            // 
            // clnMSD
            // 
            this.clnMSD.HeaderText = "MHC";
            this.clnMSD.Name = "clnMSD";
            this.clnMSD.ReadOnly = true;
            this.clnMSD.Width = 56;
            // 
            // clnMSD_f
            // 
            this.clnMSD_f.HeaderText = "f";
            this.clnMSD_f.Name = "clnMSD_f";
            this.clnMSD_f.ReadOnly = true;
            this.clnMSD_f.Width = 35;
            // 
            // clnGMSS
            // 
            this.clnGMSS.HeaderText = "ГМДК";
            this.clnGMSS.Name = "clnGMSS";
            this.clnGMSS.ReadOnly = true;
            this.clnGMSS.Width = 63;
            // 
            // clnGMSS_f
            // 
            this.clnGMSS_f.HeaderText = "f";
            this.clnGMSS_f.Name = "clnGMSS_f";
            this.clnGMSS_f.ReadOnly = true;
            this.clnGMSS_f.Width = 35;
            // 
            // clnMN
            // 
            this.clnMN.HeaderText = "М. Ньютона";
            this.clnMN.Name = "clnMN";
            this.clnMN.ReadOnly = true;
            this.clnMN.Width = 92;
            // 
            // clnMN_f
            // 
            this.clnMN_f.HeaderText = "f";
            this.clnMN_f.Name = "clnMN_f";
            this.clnMN_f.ReadOnly = true;
            this.clnMN_f.Width = 35;
            // 
            // clnCG
            // 
            this.clnCG.HeaderText = "М. у. гр.";
            this.clnCG.Name = "clnCG";
            this.clnCG.ReadOnly = true;
            this.clnCG.Width = 72;
            // 
            // clnCG_f
            // 
            this.clnCG_f.HeaderText = "f";
            this.clnCG_f.Name = "clnCG_f";
            this.clnCG_f.ReadOnly = true;
            this.clnCG_f.Width = 35;
            // 
            // lbl_InfoLastCalcFunc
            // 
            this.lbl_InfoLastCalcFunc.AutoSize = true;
            this.lbl_InfoLastCalcFunc.Location = new System.Drawing.Point(6, 20);
            this.lbl_InfoLastCalcFunc.MaximumSize = new System.Drawing.Size(380, 13);
            this.lbl_InfoLastCalcFunc.Name = "lbl_InfoLastCalcFunc";
            this.lbl_InfoLastCalcFunc.Size = new System.Drawing.Size(9, 13);
            this.lbl_InfoLastCalcFunc.TabIndex = 1;
            this.lbl_InfoLastCalcFunc.Text = "l";
            // 
            // chtGraphics
            // 
            this.chtGraphics.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.AlignmentOrientation = ((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations)((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Vertical | System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal)));
            chartArea1.AxisX.MajorGrid.Interval = 0D;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.DarkGray;
            chartArea1.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.AxisX.MajorTickMark.Interval = 0D;
            chartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.Color.DimGray;
            chartArea1.AxisX.MajorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.AcrossAxis;
            chartArea1.AxisX.MinorGrid.Enabled = true;
            chartArea1.AxisX.MinorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea1.AxisX.MinorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.AxisX.MinorTickMark.Enabled = true;
            chartArea1.AxisX.MinorTickMark.LineColor = System.Drawing.Color.DarkGray;
            chartArea1.AxisX.MinorTickMark.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.AxisX.MinorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.AcrossAxis;
            chartArea1.AxisX.Title = "x1";
            chartArea1.AxisY.MajorGrid.Interval = 0D;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.DarkGray;
            chartArea1.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.AxisY.MajorTickMark.Interval = 0D;
            chartArea1.AxisY.MajorTickMark.LineColor = System.Drawing.Color.DimGray;
            chartArea1.AxisY.MajorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.AcrossAxis;
            chartArea1.AxisY.MinorGrid.Enabled = true;
            chartArea1.AxisY.MinorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea1.AxisY.MinorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.AxisY.MinorTickMark.Enabled = true;
            chartArea1.AxisY.MinorTickMark.LineColor = System.Drawing.Color.DarkGray;
            chartArea1.AxisY.MinorTickMark.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.AxisY.MinorTickMark.TickMarkStyle = System.Windows.Forms.DataVisualization.Charting.TickMarkStyle.AcrossAxis;
            chartArea1.AxisY.Title = "x2";
            chartArea1.CursorX.Interval = 0.0001D;
            chartArea1.CursorX.IsUserEnabled = true;
            chartArea1.CursorX.IsUserSelectionEnabled = true;
            chartArea1.CursorX.LineColor = System.Drawing.Color.LightCyan;
            chartArea1.CursorX.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.CursorX.SelectionColor = System.Drawing.Color.WhiteSmoke;
            chartArea1.CursorY.Interval = 0.0001D;
            chartArea1.CursorY.IsUserEnabled = true;
            chartArea1.CursorY.IsUserSelectionEnabled = true;
            chartArea1.CursorY.LineColor = System.Drawing.Color.LightCyan;
            chartArea1.CursorY.SelectionColor = System.Drawing.Color.WhiteSmoke;
            chartArea1.Name = "ChartArea1";
            this.chtGraphics.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chtGraphics.Legends.Add(legend1);
            this.chtGraphics.Location = new System.Drawing.Point(403, 3);
            this.chtGraphics.Name = "chtGraphics";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            series1.Legend = "Legend1";
            series1.Name = "srsSteepestDescent";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series2.Legend = "Legend1";
            series2.Name = "srsSplitStep";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            series3.Legend = "Legend1";
            series3.Name = "srsNewton";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            series4.Legend = "Legend1";
            series4.Name = "srsConditionalGradient";
            this.chtGraphics.Series.Add(series1);
            this.chtGraphics.Series.Add(series2);
            this.chtGraphics.Series.Add(series3);
            this.chtGraphics.Series.Add(series4);
            this.chtGraphics.Size = new System.Drawing.Size(678, 573);
            this.chtGraphics.TabIndex = 0;
            // 
            // lblMaxAljfa
            // 
            this.lblMaxAljfa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMaxAljfa.AutoSize = true;
            this.lblMaxAljfa.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMaxAljfa.Location = new System.Drawing.Point(404, 575);
            this.lblMaxAljfa.Name = "lblMaxAljfa";
            this.lblMaxAljfa.Size = new System.Drawing.Size(56, 22);
            this.lblMaxAljfa.TabIndex = 19;
            this.lblMaxAljfa.Text = "αₘₐₓ = ";
            // 
            // lblInitStep
            // 
            this.lblInitStep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInitStep.AutoSize = true;
            this.lblInitStep.Location = new System.Drawing.Point(576, 580);
            this.lblInitStep.Name = "lblInitStep";
            this.lblInitStep.Size = new System.Drawing.Size(25, 13);
            this.lblInitStep.TabIndex = 20;
            this.lblInitStep.Text = "β = ";
            // 
            // frmMultiDimensionalOptimization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 631);
            this.Controls.Add(this.tbC_Main);
            this.Name = "frmMultiDimensionalOptimization";
            this.Text = "Багатовимірна оптимізація";
            this.Load += new System.EventHandler(this.frmMultiDimensionalOptimization_Load);
            this.tbC_Main.ResumeLayout(false);
            this.tbP_First.ResumeLayout(false);
            this.tbP_First.PerformLayout();
            this.grB_SettingsOptimization.ResumeLayout(false);
            this.grB_SettingsOptimization.PerformLayout();
            this.grB_CharacteristicOtherFunc.ResumeLayout(false);
            this.grB_CharacteristicOtherFunc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Hessian)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Gradient)).EndInit();
            this.grB_LinearConditions.ResumeLayout(false);
            this.grB_LinearConditions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_m)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_MatrixA_and_Vector_b)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_Dimensionality)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_InitX)).EndInit();
            this.grB_Coefficients_abcde.ResumeLayout(false);
            this.grB_Coefficients_abcde.PerformLayout();
            this.grB_Results.ResumeLayout(false);
            this.grB_Results.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Results)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtGraphics)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbC_Main;
        private System.Windows.Forms.TabPage tbP_First;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtGraphics;
        private System.Windows.Forms.GroupBox grB_Results;
        private System.Windows.Forms.GroupBox grB_SettingsOptimization;
        private System.Windows.Forms.GroupBox grB_CharacteristicOtherFunc;
        private System.Windows.Forms.DataGridView dGV_Hessian;
        private System.Windows.Forms.DataGridView dGV_Gradient;
        private System.Windows.Forms.Label lblHessian;
        private System.Windows.Forms.Label lblGradient;
        private System.Windows.Forms.GroupBox grB_Coefficients_abcde;
        private System.Windows.Forms.Label lbl_e;
        private System.Windows.Forms.Label lbl_d;
        private System.Windows.Forms.Label lbl_c;
        private System.Windows.Forms.Label lbl_b;
        private System.Windows.Forms.Label lbl_a;
        private System.Windows.Forms.Label lbl_Eps;
        private System.Windows.Forms.Label lbl_InitX;
        private System.Windows.Forms.Label lbl_xDim;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnAddNewFunc;
        private System.Windows.Forms.ComboBox cmB_OtherFunc;
        private System.Windows.Forms.CheckBox chB_ConditionalOptimization;
        private System.Windows.Forms.RadioButton rdB_OtherFunc;
        private System.Windows.Forms.RadioButton rdB_NonLinearFunc;
        private System.Windows.Forms.RadioButton rdB_QuadraticFunc;
        private System.Windows.Forms.CheckBox chB_MNewton;
        private System.Windows.Forms.CheckBox chB_MConditionalGradient;
        private System.Windows.Forms.CheckBox chB_GradMSplitStep;
        private System.Windows.Forms.CheckBox chB_MSteepestDescent;
        private System.Windows.Forms.Label lbl_InfoInit_and_Accuracy;
        private System.Windows.Forms.DataGridView dGV_Results;
        private System.Windows.Forms.Label lbl_InfoLastCalcFunc;
        private System.Windows.Forms.DataGridView dGV_InitX;
        private System.Windows.Forms.TextBox txB_Eps;
        private System.Windows.Forms.TextBox txB_b;
        private System.Windows.Forms.TextBox txB_c;
        private System.Windows.Forms.TextBox txB_d;
        private System.Windows.Forms.TextBox txB_a;
        private System.Windows.Forms.TextBox txB_e;
        private System.Windows.Forms.Label lblCoefSplit;
        private System.Windows.Forms.Label lblInitStep;
        private System.Windows.Forms.Label lblMaxAljfa;
        private System.Windows.Forms.TextBox txB_CoefSplit;
        private System.Windows.Forms.TextBox txB_MaxAljfa;
        private System.Windows.Forms.TextBox txB_InitStep;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnMSD;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnMSD_f;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnGMSS;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnGMSS_f;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnMN;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnMN_f;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCG;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCG_f;
        private System.Windows.Forms.NumericUpDown nUD_Dimensionality;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDerivOnVariable;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDerFunc;
        private System.Windows.Forms.GroupBox grB_LinearConditions;
        private System.Windows.Forms.Label lblConditionalType;
        private System.Windows.Forms.DataGridView dGV_MatrixA_and_Vector_b;
        private System.Windows.Forms.CheckBox chB_LabelDraw;
        private System.Windows.Forms.Label lbl_m;
        private System.Windows.Forms.NumericUpDown nUD_m;
    }
}

