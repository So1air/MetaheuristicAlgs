using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using DelegateGenerator;

namespace MultiDimensionalOptimization
{
    public partial class frmMultiDimensionalOptimization : Form
    {
        int _n = 2,
            _m = 3,
            _beg_index_lvlLines = 4,
            _beg_index_conditionalLines,
            _countLvlLines = 15;
        double _a = 5d,
               _b = -2d,
               _c = 2d,
               _d = 2d,
               _e = 3d,
               _eps = 0.0001,
               _max_aljfa = 10d,
               _init_step = 10d,
               _coef_split = 0.5;
        Vector _initX = Vector.CreateVector(new double[2] { 10d, 10d });

        Matrix2D _A = Matrix2D.CreateMatrix(new double[3, 2] { { -1, -1 }, { 1, 4 }, { 11, -4 } });
        Vector _B = Vector.CreateVector(new double[3] { -4, 16, 44 });

        public frmMultiDimensionalOptimization()
        {
            InitializeComponent();
            nUD_Dimensionality.Value = 2;                      
            nUD_m.Value = 3;
            //f1
            cmB_OtherFunc.Items.Add(new MultiDimFuncC2("Math.Pow(x[0] - 2, 4) + Math.Pow(x[0] - 2*x[1], 2)",
                                                       new string[2] { "4*Math.Pow(x[0] - 2, 3) + 2*(x[0] - 2*x[1])", "-4*(x[0] - 2*x[1])" },
                                                       new string[2, 2] { {"12*Math.Pow(x[0] - 2, 2) + 2","-4"}, 
                                                                          {"-4","8"}},
                                                       2));
            //f2
            cmB_OtherFunc.Items.Add(new MultiDimFuncC2("100*Math.Pow(x[1]-x[0]*x[0], 2)+Math.Pow(1-x[0], 2)",
                                                       new string[2] { "-400*x[0]*(x[1]-x[0]*x[0])-2*(1-x[0])", "200*(x[1] - x[0]*x[0])" },
                                                       new string[2, 2] { {"-400*(x[1]-3*x[0]*x[0])+2","-400*x[0]"}, 
                                                                          {"-400*x[0]","200"}},
                                                       2));/*
            //f3
            cmB_OtherFunc.Items.Add(new MultiDimFuncC2("Math.Pow(x[1]-x[0]*x[0], 2)+100*Math.Pow(1-x[0], 2)",
                                                       new string[2] { "-4*x[0]*(x[1]-x[0]*x[0])-200*(1-x[0])", "2*(x[1] - x[0]*x[0])" },
                                                       new string[2, 2] { {"-4*(x[1]-3*x[0]*x[0])+200","-4*x[0]"}, 
                                                                          {"-4*x[0]","2"}},
                                                       2));
            //f4
            cmB_OtherFunc.Items.Add(new MultiDimFuncC2("100*Math.Pow(x[1]-Math.Pow(x[0], 3), 2) + Math.Pow(1-x[0], 2)",
                                                       new string[2] { "-600*x[0]*x[0]*(x[1]-Math.Pow(x[0], 3))-2*(1-x[0])", "200*(x[1] - x[0]*x[0]*x[0])" },
                                                       new string[2, 2] { {"-600*(2*x[0]*x[1]-5*Math.Pow(x[0],4))+2","-600*x[0]*x[0]"}, 
                                                                          {"-600*x[0]*x[0]","200"}},
                                                       2));
            //Func<Vector, double> f = (x) => 100*Math.Pow(x[0]*x[0] - x[1], 2) + Math.Pow(1 - x[0], 2) + 90*Math.Pow(x[2]*x[2] - x[3], 2) + Math.Pow(1 - x[2], 2) + 10.1*(Math.Pow(1 - x[1], 2) + Math.Pow(1 - x[3], 2)) + 19.8*(1 - x[1])*(1 - x[3]);
            //Func<Vector, double> gf1 = (x) => 400*x[0]*(x[0]*x[0] - x[1]) + 2*(x[0] - 1);
            //Func<Vector, double> gf2 = (x) => -200*(x[0]*x[0] - x[1]) + 20.2*(x[1] - 1) + 19.8*(x[3] - 1);
            //Func<Vector, double> gf3 = (x) => 360*x[2]*(x[2]*x[2] - x[3]) + 2*(x[2] - 1);
            //Func<Vector, double> gf4 = (x) => -180*(x[2]*x[2] - x[3]) + 20.2*(x[3] - 1) + 19.8*(x[1] - 1);
            //Func<Vector, double> hf11 = (x) => 400*(3*x[0]*x[0] - x[1]) + 2;
            //Func<Vector, double> hf12 = (x) => -400*x[0];
            //Func<Vector, double> hf13 = (x) => 0;
            //Func<Vector, double> hf14 = (x) => 0;
            //Func<Vector, double> hf21 = (x) => -400*x[0];
            //Func<Vector, double> hf22 = (x) => 220.2;
            //Func<Vector, double> hf23 = (x) => 0;
            //Func<Vector, double> hf24 = (x) => 19.8;
            //Func<Vector, double> hf31 = (x) => 0;
            //Func<Vector, double> hf32 = (x) => 0;
            //Func<Vector, double> hf33 = (x) => 720*x[2] + 2;
            //Func<Vector, double> hf34 = (x) => -360*x[2];
            //Func<Vector, double> hf41 = (x) => 0;
            //Func<Vector, double> hf42 = (x) => 19.8;
            //Func<Vector, double> hf43 = (x) => -360*x[2];
            //Func<Vector, double> hf44 = (x) => 200.2;
            //f6
            cmB_OtherFunc.Items.Add(new MultiDimFuncC2("Math.Pow(x[0] - 2, 4) + Math.Pow((x[0] - 2) * x[1], 2) + Math.Pow(x[1] + 1, 2)",
                                                       new string[2] { "4*Math.Pow(x[0] - 2, 3) + 2*(x[0] - 2)*x[1]*x[1]", "2*Math.Pow((x[0] - 2), 2)*x[1] + 2*(x[1] + 1)" },
                                                       new string[2, 2] { {"12*Math.Pow(x[0] - 2, 2) + 2*x[1]*x[1]","4*(x[0] - 2)*x[1]"}, 
                                                                          {"4*(x[0] - 2)*x[1]","2*Math.Pow((x[0] - 2), 2) + 2"}},
                                                       2));
            //f7
            cmB_OtherFunc.Items.Add(new MultiDimFuncC2("Math.Pow(x[0], 4) + Math.Pow(x[0] + x[1], 2) + Math.Pow(Math.Exp(x[1]) - 1, 2)",
                                                       new string[2] { "4*Math.Pow(x[0], 3) + 2*(x[0] + x[1])", "2*(x[0] + x[1]) + 2*(Math.Exp(x[1]) - 1)*Math.Exp(x[1])" },
                                                       new string[2, 2] { {"12*x[0]*x[0] + 2","2"}, 
                                                                          {"2","2 + 2*(2*Math.Exp(x[1]) - 1)*Math.Exp(x[1])"}},
                                                       2));
            //f12
            cmB_OtherFunc.Items.Add(new MultiDimFuncC2("100*Math.Pow(x[0]*x[0] - x[1], 2) + Math.Pow(1 - x[0], 2) + 90*Math.Pow(x[2]*x[2] - x[3], 2) + Math.Pow(1 - x[2], 2) + 10.1*(Math.Pow(1 - x[1], 2) + Math.Pow(1 - x[3], 2)) + 19.8*(1 - x[1])*(1 - x[3])",
                                                       new string[4] { "400*x[0]*(x[0]*x[0] - x[1]) + 2*(x[0] - 1)", 
                                                                       "-200*(x[0]*x[0] - x[1]) + 20.2*(x[1] - 1) + 19.8*(x[3] - 1)",
                                                                       "360*x[2]*(x[2]*x[2] - x[3]) + 2*(x[2] - 1)",                                                       
                                                                       "-180*(x[2]*x[2] - x[3]) + 20.2*(x[3] - 1) + 19.8*(x[1] - 1)" },
                                                       new string[4, 4] { {"400*(3*x[0]*x[0] - x[1]) + 2", "-400*x[0]", "0",            "0"}, 
                                                                          {"-400*x[0]",                    "220.2",     "0",            "19.8"},
                                                                          {"0",                            "0",         "720*x[2] + 2", "-360*x[2]"},
                                                                          {"0",                            "19.8",      "-360*x[2]",    "200.2"}},
                                                       4));
            */
            cmB_OtherFunc.SelectedIndex = 0;
        }         

        private void rdB_QuadraticFunc_CheckedChanged(object sender, EventArgs e)
        {
            if (rdB_QuadraticFunc.Checked)
            {
                grB_CharacteristicOtherFunc.Visible = false;
                nUD_Dimensionality.Value = 2;
                lbl_e.Visible = txB_e.Visible = grB_Coefficients_abcde.Visible = true;
                for (int i = _beg_index_lvlLines; i < chtGraphics.Series.Count; i++)
                    chtGraphics.Series[i].Enabled = true;
                cmB_OtherFunc.Enabled = false;
                btnAddNewFunc.Enabled = false;
            }
            else
            {
                for (int i = _beg_index_lvlLines; i < chtGraphics.Series.Count; i++)
                    chtGraphics.Series[i].Enabled = false;
            }
        }

        private void rdB_NonLinearFunc_CheckedChanged(object sender, EventArgs e)
        {
            if (rdB_NonLinearFunc.Checked)
            {
                grB_CharacteristicOtherFunc.Visible = false;
                nUD_Dimensionality.Value = 2;
                lbl_e.Visible = txB_e.Visible = ! (grB_Coefficients_abcde.Visible = true);
                cmB_OtherFunc.Enabled = false;
                btnAddNewFunc.Enabled = false;
            }           
        }

        private void rdB_OtherFunc_CheckedChanged(object sender, EventArgs e)
        {
            if (rdB_OtherFunc.Checked)
            {
                grB_Coefficients_abcde.Visible = false;
                grB_CharacteristicOtherFunc.Visible = true;
                cmB_OtherFunc.Enabled = true;
                btnAddNewFunc.Enabled = true;
            }
        }

        private void txB_a_Validated(object sender, EventArgs e)
        {
            double a;
            if (double.TryParse(txB_a.Text, out a))
                if (rdB_QuadraticFunc.Checked)
                    if (_b * _b - 4 * a * _c != 0)/*перевірка на центральність*/
                        _a = a;
                    else
                    {
                        txB_a.Text = _a.ToString();
                        MessageBox.Show("Крива другого порядку, що відповідає даній квадратичній функції, не є центральною, оскільки інваріант І2 = 0. Тому зміни не внесено, оскільки в цьому випадку функція не має точок мінімуму або має безліч точок мінімуму.", "Крива другого порядку не є центральною");
                    }
                else
                    _a = a;
            else
                txB_a.Text = _a.ToString();
        }

        private void txB_b_Validated(object sender, EventArgs e)
        {
            double b;
            if (double.TryParse(txB_b.Text, out b))
                if (rdB_QuadraticFunc.Checked)
                    if (b * b - 4 * _a * _c != 0)/*перевірка на центральність*/
                        _b = b;
                    else
                    {
                        txB_b.Text = _b.ToString();
                        MessageBox.Show("Крива другого порядку, що відповідає даній квадратичній функції, не є центральною, оскільки інваріант І2 = 0. Зміни не внесено, оскільки в цьому випадку функція не має точок мінімуму або має безліч точок мінімуму.", "Крива другого порядку не є центральною");
                    }
                else
                    _b = b;
            else
                txB_b.Text = _b.ToString();
        }

        private void txB_c_Validated(object sender, EventArgs e)
        {
            double c;
            if (double.TryParse(txB_c.Text, out c))
                if (rdB_QuadraticFunc.Checked)
                    if (_b * _b - 4 * _a * c != 0)/*перевірка на центральність*/
                        _c = c;
                    else
                    {
                        txB_c.Text = _c.ToString();
                        MessageBox.Show("Крива другого порядку, що відповідає даній квадратичній функції, не є центральною, оскільки інваріант І2 = 0. Зміни не внесено, оскільки в цьому випадку функція не має точок мінімуму або має безліч точок мінімуму.", "Крива другого порядку не є центральною");
                    }
                else
                    _c = c;
            else
                txB_c.Text = _c.ToString();
        }

        private void txB_d_Validated(object sender, EventArgs e)
        {
            double d;
            if (double.TryParse(txB_d.Text, out d))
                _d = d;
            else
                txB_d.Text = _d.ToString();
        }

        private void txB_e_Validated(object sender, EventArgs e)
        {
            double v_e;
            if (double.TryParse(txB_e.Text, out v_e))
                _e = v_e;
            else
                txB_e.Text = _e.ToString();
        }

        private void dGV_InitX_Validated(object sender, EventArgs e)
        {
            int n = _initX.Length;
            double[] init = new double[n];
            int i = 0;
            for (; (i < n) && (dGV_InitX.Rows[0].Cells[i].Value != null) && (double.TryParse(dGV_InitX.Rows[0].Cells[i].Value.ToString(), out init[i])); i++)
                ;
            if (i == n)
                _initX = Vector.CreateVector(init);
            else
                for (i = 0; i < n; i++)
                    dGV_InitX.Rows[0].Cells[i].Value = _initX[i];
        }

        private void txB_Eps_Validated(object sender, EventArgs e)
        {
            double eps;
            if (double.TryParse(txB_Eps.Text, out eps))
                _eps = eps;
            else
                txB_Eps.Text = _eps.ToString();
        }

        private void txB_MaxAljfa_Validated(object sender, EventArgs e)
        {
            double max_aljfa;
            if (double.TryParse(txB_MaxAljfa.Text, out max_aljfa))
                _max_aljfa = max_aljfa;
            else
                txB_MaxAljfa.Text = _max_aljfa.ToString();
        }

        private void txB_InitStep_Validated(object sender, EventArgs e)
        {
            double init_step;
            if (double.TryParse(txB_InitStep.Text, out init_step))
                _init_step = init_step;
            else
                txB_InitStep.Text = _init_step.ToString();
        }

        private void txB_CoefSplit_Validated(object sender, EventArgs e)
        {
            double coef_split;
            if (double.TryParse(txB_CoefSplit.Text, out coef_split))
                _coef_split = coef_split;
            else
                txB_CoefSplit.Text = _coef_split.ToString();
        }

        private void chB_MSteepestDescent_CheckedChanged(object sender, EventArgs e)
        {
            dGV_Results.Columns["clnMSD"].Visible = dGV_Results.Columns["clnMSD_f"].Visible = lblMaxAljfa.Visible = txB_MaxAljfa.Visible = chtGraphics.Series["srsSteepestDescent"].Enabled = chB_MSteepestDescent.Checked;
        }

        private void chB_GradMSplitStep_CheckedChanged(object sender, EventArgs e)
        {
            dGV_Results.Columns["clnGMSS"].Visible = dGV_Results.Columns["clnGMSS_f"].Visible = lblInitStep.Visible = txB_InitStep.Visible = lblCoefSplit.Visible = txB_CoefSplit.Visible = chtGraphics.Series["srsSplitStep"].Enabled = chB_GradMSplitStep.Checked;
        }

        private void chB_MNewton_CheckedChanged(object sender, EventArgs e)
        {
            dGV_Results.Columns["clnMN"].Visible = dGV_Results.Columns["clnMN_f"].Visible = chtGraphics.Series["srsNewton"].Enabled = chB_MNewton.Checked;
        }

        private void chB_MConditionalGradient_CheckedChanged(object sender, EventArgs e)
        {
            dGV_Results.Columns["clnCG"].Visible = dGV_Results.Columns["clnCG_f"].Visible = chtGraphics.Series["srsConditionalGradient"].Enabled = chB_ConditionalOptimization.Checked;            
        }

        private void nUD_Dimensionality_ValueChanged(object sender, EventArgs e)
        {
            _n = (int)nUD_Dimensionality.Value;    
        
            dGV_Gradient.RowCount = _n;
            dGV_Hessian.ColumnCount = _n;
            dGV_Hessian.RowCount = _n;                       
            for (int i = 0; i < _n; i++)
            {
                dGV_Hessian.Rows[i].HeaderCell.Value = dGV_Gradient.Rows[i].Cells["clnDerivOnVariable"].Value = "∂f/∂x" + NumberToLowIndex(i + 1);
                dGV_Hessian.Columns[i].HeaderCell.Value = "∂/∂x" + NumberToLowIndex(i + 1);
            }

            dGV_MatrixA_and_Vector_b.ColumnCount = _n + 1;
 
            dGV_InitX.ColumnCount = _n;
            dGV_InitX.RowCount = 1;
            Vector initX = Vector.CreateVector(_n);
            for (int i = 0, min = (_n < _initX.Length) ? _n : _initX.Length; i < min; i++)            
                dGV_InitX.Rows[0].Cells[i].Value = initX[i] = _initX[i];           
            _initX = initX;
        }

        public static string NumberToLowIndex(int number)
        {
            string result = "",
                   source = number.ToString();
            for (int i = 0; i < source.Length; i++)
                switch (source[i])
                {
                    case '1':
                        result += '₁';
                        break;
                    case '2':
                        result += '₂';
                        break;
                    case '3':
                        result += '₃';
                        break;
                    case '4':
                        result += '₄';
                        break;
                    case '5':
                        result += '₅';
                        break;
                    case '6':
                        result += '₆';
                        break;
                    case '7':
                        result += '₇';
                        break;
                    case '8':
                        result += '₈';
                        break;
                    case '9':
                        result += '₉';
                        break;
                    case '0':
                        result += '₀';
                        break;
                    case '-':
                        result += '₋';
                        break;
                    default:
                        break;
                }
            return result;
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {

            int accuracy = txB_Eps.Text.IndexOf(',');
            accuracy = (accuracy == -1) ? 0 : txB_Eps.Text.Length - accuracy - 1;
            Vector res = null;
            ///*
            //зошит
            res = MethodsConditionalOptimization.SimplexForInequalitys(Vector.CreateVector(new double[4] { 14, 10, 14, 11 }), 0, Matrix2D.CreateMatrix(new double[3, 4] { { 4, 2, 2, 3 }, { 1, 1, 2, 3 }, {3, 1, 2, 1} }), Vector.CreateVector(new double[3] { 35, 30, 40 }));
            //зошит
            res = MethodsConditionalOptimization.SimplexForInequalitys(Vector.CreateVector(new double[2] { 3, 2 }), 0, Matrix2D.CreateMatrix(new double[4, 2] { { 2, 3 }, { 2, -1 }, { -1, 0 }, { 0, -1 } }), Vector.CreateVector(new double[4] { 12, 4, 0, 0 }));
            //Лунгу п. 4.1
            res = MethodsConditionalOptimization.SimplexForInequalitys(Vector.CreateVector(new double[5] { 1, 1, -1, -3, -7 }), 0, Matrix2D.CreateMatrix(new double[3, 5] { { -1, 1, 1, 2, -3 }, { 0, -1, -1, 0, 4 }, { 1, 1, 4, 1, -8 } }), Vector.CreateVector(new double[3] { 4, 4, 3 }));
            //Лунгу п. 4.3
            res = MethodsConditionalOptimization.SimplexForInequalitys(Vector.CreateVector(new double[5] { 2, -1, 3, -2, -10 }), 0, Matrix2D.CreateMatrix(new double[3, 5] { { 1, -1, 2, -2, -6 }, { 1, 2, -1, 7, 3 }, { -1, 1, 1, 1, 0 } }), Vector.CreateVector(new double[3] { 20, 50, 40 }));

            //*/
            //Лунгу п. 4.1
            //res = MethodsConditionalOptimization.Simplex(Vector.CreateVector(new double[5] { 1, 1, -1, -3, -7 }), 0, Matrix2D.CreateMatrix(new double[3, 5] { { -1, 1, 1, 2, -3 }, { 0, -1, -1, 0, 4 }, { 1, 1, 4, 1, -8 } }), new bool[3] { true, true, true }, Vector.CreateVector(new double[3] { 4, 4, 3 }), new bool[5] { true, true, true, true, true }, true);
            //Ответ: (5; 0; 0; 6; 1)
 
            //Лунгу п. 4.2
            //res = MethodsConditionalOptimization.Simplex(Vector.CreateVector(new double[6] { -7, -8, -11, 1, 2, -1 }), 0, Matrix2D.CreateMatrix(new double[3, 6] { { 6, 11, 8, -1, -1, 0 }, { 4, 2, 7, 0, -1, 1 }, { 8, 8, 12, -1, -1, 1 } }), new bool[3] { true, true, true }, Vector.CreateVector(new double[3] { 36, 21, 42 }), new bool[6] { true, true, true, true, true, true }, false);
            //Ответ: (2,875; 2,25; 0; 0; 0; 9)

            //Лунгу п. 4.3
            //res = MethodsConditionalOptimization.Simplex(Vector.CreateVector(new double[5] { 2, -1, 3, -2, -10 }), 0, Matrix2D.CreateMatrix(new double[3, 5] { { 1, -1, 2, -2, -6 }, { 1, 2, -1, 7, 3 }, { -1, 1, 1, 1, 0 } }), new bool[3] { false, false, false }, Vector.CreateVector(new double[3] { 20, 50, 40 }), new bool[5] { true, true, true, true, true }, true);
            //Ответ: (10; 30; 20)

            //Лунгу п. 4.4
            //res = MethodsConditionalOptimization.Simplex(Vector.CreateVector(new double[5] { 1, -1, -1, 3, -2 }), 0, Matrix2D.CreateMatrix(new double[3, 5] { { 1, 1, 0, -3, 4 }, { 0, 1, 1, 3, 6 }, { -2, -2, 1, 10, -5 } }), new bool[3] { true, true, true }, Vector.CreateVector(new double[3] { 11, 33, 2 }), new bool[5] { true, true, true, true, true }, true);
            //Ответ: (14; 15; 0; 6; 0)
            //res = MethodsConditionalOptimization.Simplex(Vector.CreateVector(new double[5] { 1, -1, -1, 3, -2 }), 0, Matrix2D.CreateMatrix(new double[3, 5] { { 1, 1, 0, -3, 4 }, { 0, 1, 1, 3, 6 }, { -2, -2, 1, 10, -5 } }), new bool[3] { true, true, true }, Vector.CreateVector(new double[3] { 11, 33, 2 }), new bool[5] { true, true, true, true, true }, false);
            //Ответ: (2; 9; 24; 0; 0)

            //Лунгу п. 4.5
            //res = MethodsConditionalOptimization.Simplex(Vector.CreateVector(new double[3] { 2, 2, -1 }), 0, Matrix2D.CreateMatrix(new double[3, 3] { { 1, -1, 1 }, { 0, 2, 1 }, { -2, 3, 1 } }), new bool[3] { true, false, false }, Vector.CreateVector(new double[3] { 5, 12, -4 }), new bool[3] { true, true, false }, false);
            //Ответ: (3; 0; 2)

            //Лунгу y. 4.23
            res = MethodsConditionalOptimization.Simplex(Vector.CreateVector(new double[4] { 1, 0, -1, -3 }), 0, Matrix2D.CreateMatrix(new double[5, 4] { { 3, 1, 0, -5 }, { -1, -1, -2, -1 }, { 2, 1, 1, -2 }, {0, -2, -6, -3}, {-3, -3, -3, 1} }), new bool[5] { false, false, false, false, false }, Vector.CreateVector(new double[5] { 0, -2, -1, -3, -4 }), new bool[4] { false, false, false, false }, true);
            //Ответ: (4; 0; -1,4; 3,8)
            return;
            List<Vector> res_s;
            int countIter;
            if (rdB_QuadraticFunc.Checked)
            {
                Func<Vector, double> f = (x) => (_a * x[0] * x[0] + _b * x[0] * x[1] + _c * x[1] * x[1] + _d * x[0] + _e * x[1]);
                Func<Vector, double>[] grad_f = new Func<Vector, double>[2] { (x) => (2 * _a * x[0] + _b * x[1] + _d),
                                                                                  (x) => (_b * x[0] + 2 * _c * x[1] + _e) };
                dGV_Results.RowCount = 0;
                if (chB_ConditionalOptimization.Checked)
                {
                    res = MethodsConditionalOptimization.ConditionalGradientForLinearCondition(f, grad_f, _A, _B, _initX, _eps, out res_s);
                    MessageBox.Show("fₘᵢₙ(" + res + ") = " + f(res) + "\nКількість ітерацій: " + ((countIter = res_s.Count) - 1), "Метод умовного градієнта");
                    if (dGV_Results.RowCount < countIter)
                        dGV_Results.RowCount = countIter;
                    chtGraphics.Series["srsConditionalGradient"].Points.Clear();
                    for (int i = 0; i < countIter; i++)
                    {
                        dGV_Results.Rows[i].Cells["clnCG"].Value = Math.Round(res_s[i][0], accuracy) + "; " + Math.Round(res_s[i][1], accuracy);
                        dGV_Results.Rows[i].Cells["clnCG_f"].Value = Math.Round(f(res_s[i]), accuracy);
                        if (chB_LabelDraw.Checked)
                            chtGraphics.Series["srsConditionalGradient"].Points.Add(new DataPoint(res_s[i][0], res_s[i][1]) { Label = Math.Round(f(res_s[i]), accuracy).ToString() });
                        else
                            chtGraphics.Series["srsConditionalGradient"].Points.AddXY(res_s[i][0], res_s[i][1]);
                    }
                    /*
                    for (int i = countIter; i < dGV_Results.RowCount; i++)
                        dGV_Results.Rows[i].Cells["clnCG"].Value = dGV_Results.Rows[i].Cells["clnCG_f"].Value = "";*/                    
                }

                if (_b * _b - 4 * _a * _c == 0)
                {
                    MessageBox.Show("Крива другого порядку, що відповідає даній квадратичній функції, не є центральною, оскільки інваріант І2 = 0. В цьому випадку функція не має точок мінімуму або має безліч точок мінімуму.", "Умови застосовності методів порушені");
                    return;
                }

                res = Vector.CreateVector(2);
                if (_b != 0)
                    res[1] = -(2 * _a * (res[0] = (2 * _c * _d - _e * _b) / (_b * _b - 4 * _a * _c)) + _d) / _b;
                else
                {
                    res[0] = -_d / (2d * _a);
                    res[1] = -_e / (2d * _c);
                }

                if (_b * _b - 4 * _a * _c > 0)
                {
                    MessageBox.Show("Вказана квадратична функція задає гіперболічний параболоїд, тобто fₘᵢₙ = NegativeInfinity.\nСідлова точка x = (" + res + ")\nЗначення функції у цій точці f = " + f(res), "Гіперболічний параболоїд");
                    return;
                }
                else
                    MessageBox.Show("fₘᵢₙ(" + res + ") = " + f(res), "Класичний метод");

                if (chB_MSteepestDescent.Checked)
                {
                    res = MethodsUnConditionalOptimization.MethodOfSteepestDescent(f, grad_f, _initX, _eps, _max_aljfa, out res_s);
                    MessageBox.Show("fₘᵢₙ(" + res + ") = " + f(res) + "\nКількість ітерацій: " + ((countIter = res_s.Count) - 1), "Метод найшвидшого спуску");
                    if (dGV_Results.RowCount < countIter)
                        dGV_Results.RowCount = countIter;
                    chtGraphics.Series["srsSteepestDescent"].Points.Clear();
                    for (int i = 0; i < countIter; i++)
                    {
                        dGV_Results.Rows[i].Cells["clnMSD"].Value = Math.Round(res_s[i][0], accuracy) + "; " + Math.Round(res_s[i][1], accuracy);
                        dGV_Results.Rows[i].Cells["clnMSD_f"].Value = Math.Round(f(res_s[i]), accuracy);
                        if (chB_LabelDraw.Checked)
                            chtGraphics.Series["srsSteepestDescent"].Points.Add(new DataPoint(res_s[i][0], res_s[i][1]) { Label = Math.Round(f(res_s[i]), accuracy).ToString() });
                        else
                            chtGraphics.Series["srsSteepestDescent"].Points.AddXY(res_s[i][0], res_s[i][1]);
                    }
                    /*
                    for (int i = countIter; i < dGV_Results.RowCount; i++)
                        dGV_Results.Rows[i].Cells["clnMSD"].Value = dGV_Results.Rows[i].Cells["clnMSD_f"].Value = "";*/
                }

                if (chB_GradMSplitStep.Checked)
                {
                    res = MethodsUnConditionalOptimization.GradientMethodWithSplitStep(f, grad_f, _initX, _eps, _init_step, _coef_split, out res_s);
                    MessageBox.Show("fₘᵢₙ(" + res + ") = " + f(res) + "\nКількість ітерацій: " + ((countIter = res_s.Count) - 1), "Метод з дробленням кроку");
                    if (dGV_Results.RowCount < countIter)
                        dGV_Results.RowCount = countIter;
                    chtGraphics.Series["srsSplitStep"].Points.Clear();
                    for (int i = 0; i < countIter; i++)
                    {
                        dGV_Results.Rows[i].Cells["clnGMSS"].Value = Math.Round(res_s[i][0], accuracy) + "; " + Math.Round(res_s[i][1], accuracy);
                        dGV_Results.Rows[i].Cells["clnGMSS_f"].Value = Math.Round(f(res_s[i]), accuracy);
                        if (chB_LabelDraw.Checked)
                            chtGraphics.Series["srsSplitStep"].Points.Add(new DataPoint(res_s[i][0], res_s[i][1]) { Label = Math.Round(f(res_s[i]), accuracy).ToString() });
                        else
                            chtGraphics.Series["srsSplitStep"].Points.AddXY(res_s[i][0], res_s[i][1]);
                    }
                    /*
                    for (int i = countIter; i < dGV_Results.RowCount; i++)
                        dGV_Results.Rows[i].Cells["clnGMSS"].Value = dGV_Results.Rows[i].Cells["clnGMSS_f"].Value = "";*/
                }

                if (chB_MNewton.Checked)
                {
                    res = MethodsUnConditionalOptimization.NewtonsMethod(f, grad_f, new Func<Vector, double>[2, 2] { { (x) => (2 * _a), (x) => (_b) }, { (x) => (_b), (x) => (2 * _c) } }, _initX, _eps, out res_s);
                    MessageBox.Show("fₘᵢₙ(" + res + ") = " + f(res) + "\nКількість ітерацій: " + ((countIter = res_s.Count) - 1), "Метод Ньютона");
                    if (dGV_Results.RowCount < countIter)
                        dGV_Results.RowCount = countIter;
                    chtGraphics.Series["srsNewton"].Points.Clear();
                    for (int i = 0; i < countIter; i++)
                    {
                        dGV_Results.Rows[i].Cells["clnMN"].Value = Math.Round(res_s[i][0], accuracy) + "; " + Math.Round(res_s[i][1], accuracy);
                        dGV_Results.Rows[i].Cells["clnMN_f"].Value = Math.Round(f(res_s[i]), accuracy);
                        if (chB_LabelDraw.Checked)
                            chtGraphics.Series["srsNewton"].Points.Add(new DataPoint(res_s[i][0], res_s[i][1]) { Label = Math.Round(f(res_s[i]), accuracy).ToString() });
                        else
                            chtGraphics.Series["srsNewton"].Points.AddXY(res_s[i][0], res_s[i][1]);
                    }
                    /*
                    for (int i = countIter; i < dGV_Results.RowCount; i++)
                        dGV_Results.Rows[i].Cells["clnMN"].Value = dGV_Results.Rows[i].Cells["clnMN_f"].Value = "";*/
                }

                if (chB_MSteepestDescent.Checked || chB_GradMSplitStep.Checked || chB_MNewton.Checked || chB_ConditionalOptimization.Checked)
                {
                    lbl_InfoLastCalcFunc.Text = String.Format("для f(x) = {0} x₁² + {1} x₁x₂ + {2} x₂² + {3} x₁ + {4} x₂", _a, _b, _c, _d, _e);
                    lbl_InfoInit_and_Accuracy.Text = "з точністю " + _eps;
                    for (int i = 0; i < dGV_Results.RowCount; i++)
                        dGV_Results.Rows[i].HeaderCell.Value = i.ToString();

                    while (chtGraphics.Series.Count != _beg_index_lvlLines)
                        chtGraphics.Series.RemoveAt(_beg_index_lvlLines);
                    Series srs;
                    CurveOfSecondOrder curve = new CurveOfSecondOrder(_a, _b / 2d, _c, _d / 2d, _e / 2d, 0);
                    Func<double, double[]> polar;
                    double[] point = null;
                    double increase,
                           min = f(res),
                           high = f(_initX);
                    increase = (high - min) / _countLvlLines;
                    high = -high - increase;
                    for (curve.A33 = -min - increase, polar = curve.PolarFunctional; curve.A33 > high; curve.A33 -= increase, polar = curve.PolarFunctional)
                    {
                        srs = new Series()
                        {
                            Color = Color.Brown,
                            ChartType = SeriesChartType.Spline,
                        };
                        for (double teta = 0, circle_end = 2 * Math.PI, step = Math.PI / 45d; teta <= circle_end; teta += step)
                        {
                            point = polar(teta);
                            srs.Points.AddXY(point[0], point[1]);
                            //srs.Points.Add(new DataPoint(point[0], point[1]) { Label = f(Vector.CreateVector(point)).ToString() });
                        }
                        point = polar(0);
                        //srs.Points.AddXY(point[0], point[1]);
                        srs.Points.Add(new DataPoint(point[0], point[1]) { Label = Math.Round(f(Vector.CreateVector(point)), accuracy).ToString() } );
                        chtGraphics.Series.Add(srs);
                    }

                    
                    if (chB_ConditionalOptimization.Checked)
                        for (int i = 0; i < _A.RowCount; i++)
                        {           
                            srs = new Series()
                            {
                                Color = Color.Green,
                                ChartType = SeriesChartType.FastLine,
                            };                 
                            srs.Points.AddXY(chtGraphics.ChartAreas[0].AxisX.Minimum, (_B[i] - _A.GetElement(i, 0) * chtGraphics.ChartAreas[0].AxisX.Minimum) / _A.GetElement(i, 1));
                            srs.Points.AddXY(chtGraphics.ChartAreas[0].AxisX.Maximum, (_B[i] - _A.GetElement(i, 0) * chtGraphics.ChartAreas[0].AxisX.Maximum) / _A.GetElement(i, 1));
                            chtGraphics.Series.Insert(_beg_index_lvlLines, srs);
                        }
                }
            }
            else
                if (rdB_NonLinearFunc.Checked)
                {
                    Func<Vector, double> g = (x) => (_a * x[0] + _b * x[1] + Math.Exp(_c * x[0] * x[0] + _d * x[1] * x[1]));
                    Func<Vector, double>[] grad_g = new Func<Vector, double>[2] { (x) => (_a + 2 * _c * x[0] * Math.Exp(_c * x[0] * x[0] + _d * x[1] * x[1])),
                                                                                  (x) => (_b + 2 * _d * x[1] * Math.Exp(_c * x[0] * x[0] + _d * x[1] * x[1])) };
                    dGV_Results.RowCount = 0;
                    if (chB_ConditionalOptimization.Checked)
                    {                        
                        res = MethodsConditionalOptimization.ConditionalGradientForLinearCondition(g, grad_g, _A, _B, _initX, _eps, out res_s);
                        MessageBox.Show("fₘᵢₙ(" + res + ") = " + g(res) + "\nКількість ітерацій: " + ((countIter = res_s.Count) - 1), "Метод умовного градієнта");
                        if (dGV_Results.RowCount < countIter)
                            dGV_Results.RowCount = countIter;
                        chtGraphics.Series["srsConditionalGradient"].Points.Clear();
                        for (int i = 0; i < countIter; i++)
                        {
                            dGV_Results.Rows[i].Cells["clnCG"].Value = Math.Round(res_s[i][0], accuracy) + "; " + Math.Round(res_s[i][1], accuracy);
                            dGV_Results.Rows[i].Cells["clnCG_f"].Value = Math.Round(g(res_s[i]), accuracy);
                            if (chB_LabelDraw.Checked)
                                chtGraphics.Series["srsConditionalGradient"].Points.Add(new DataPoint(res_s[i][0], res_s[i][1]) { Label = Math.Round(g(res_s[i]), accuracy).ToString() });
                            else
                                chtGraphics.Series["srsConditionalGradient"].Points.AddXY(res_s[i][0], res_s[i][1]);
                        }
                        /*
                        for (int i = countIter; i < dGV_Results.RowCount; i++)
                            dGV_Results.Rows[i].Cells["clnCG"].Value = dGV_Results.Rows[i].Cells["clnCG_f"].Value = "";*/
                    }

                    if (chB_MSteepestDescent.Checked)
                    {
                        res = MethodsUnConditionalOptimization.MethodOfSteepestDescent(g, grad_g, _initX, _eps, _max_aljfa, out res_s);
                        MessageBox.Show("fₘᵢₙ(" + res + ") = " + g(res) + "\nКількість ітерацій: " + ((countIter = res_s.Count) - 1), "Метод найшвидшого спуску");
                        if (dGV_Results.RowCount < countIter)
                            dGV_Results.RowCount = countIter;
                        chtGraphics.Series["srsSteepestDescent"].Points.Clear();
                        for (int i = 0; i < countIter; i++)
                        {
                            dGV_Results.Rows[i].Cells["clnMSD"].Value = Math.Round(res_s[i][0], accuracy) + "; " + Math.Round(res_s[i][1], accuracy);
                            dGV_Results.Rows[i].Cells["clnMSD_f"].Value = Math.Round(g(res_s[i]), accuracy);
                            if (chB_LabelDraw.Checked)
                                chtGraphics.Series["srsSteepestDescent"].Points.Add(new DataPoint(res_s[i][0], res_s[i][1]) { Label = Math.Round(g(res_s[i]), accuracy).ToString() });
                            else
                                chtGraphics.Series["srsSteepestDescent"].Points.AddXY(res_s[i][0], res_s[i][1]);
                        }
                        /*
                        for (int i = countIter; i < dGV_Results.RowCount; i++)
                            dGV_Results.Rows[i].Cells["clnMSD"].Value = dGV_Results.Rows[i].Cells["clnMSD_f"].Value = "";*/
                    }

                    if (chB_GradMSplitStep.Checked)
                    {
                        res = MethodsUnConditionalOptimization.GradientMethodWithSplitStep(g, grad_g, _initX, _eps, _init_step, _coef_split, out res_s);
                        MessageBox.Show("fₘᵢₙ(" + res + ") = " + g(res) + "\nКількість ітерацій: " + ((countIter = res_s.Count) - 1), "Метод з дробленням кроку");
                        if (dGV_Results.RowCount < countIter)
                            dGV_Results.RowCount = countIter;
                        chtGraphics.Series["srsSplitStep"].Points.Clear();
                        for (int i = 0; i < countIter; i++)
                        {
                            dGV_Results.Rows[i].Cells["clnGMSS"].Value = Math.Round(res_s[i][0], accuracy) + "; " + Math.Round(res_s[i][1], accuracy);
                            dGV_Results.Rows[i].Cells["clnGMSS_f"].Value = Math.Round(g(res_s[i]), accuracy);
                            if (chB_LabelDraw.Checked)
                                chtGraphics.Series["srsSplitStep"].Points.Add(new DataPoint(res_s[i][0], res_s[i][1]) { Label = Math.Round(g(res_s[i]), accuracy).ToString() });
                            else
                                chtGraphics.Series["srsSplitStep"].Points.AddXY(res_s[i][0], res_s[i][1]);
                        }
                        /*
                        for (int i = countIter; i < dGV_Results.RowCount; i++)
                            dGV_Results.Rows[i].Cells["clnGMSS"].Value = dGV_Results.Rows[i].Cells["clnGMSS_f"].Value = "";*/
                    }

                    if (chB_MNewton.Checked)
                    {
                        Func<Vector, double>[,] hessian_g = new Func<Vector, double>[2, 2]  { {(x) => ((Math.Pow(2 * _c * x[0], 2) + 2 * _c) * Math.Exp(_c * x[0] * x[0] + _d * x[1] * x[1])), 
                                                                                                (x) => (4 * _c * _d * x[0] * x[1] * Math.Exp(_c * x[0] * x[0] + _d * x[1] * x[1]))},
                                                                                              {(x) => (4 * _c * _d * x[0] * x[1] * Math.Exp(_c * x[0] * x[0] + _d * x[1] * x[1])),             
                                                                                                (x) => ((Math.Pow(2 * _d * x[1], 2) + 2 * _d) * Math.Exp(_c * x[0] * x[0] + _d * x[1] * x[1]))} };
                        res = MethodsUnConditionalOptimization.NewtonsMethod(g, grad_g, hessian_g, _initX, _eps, out res_s);
                        MessageBox.Show("fₘᵢₙ(" + res + ") = " + g(res) + "\nКількість ітерацій: " + ((countIter = res_s.Count) - 1), "Метод Ньютона");
                        if (dGV_Results.RowCount < countIter)
                            dGV_Results.RowCount = countIter;
                        chtGraphics.Series["srsNewton"].Points.Clear();
                        for (int i = 0; i < countIter; i++)
                        {
                            dGV_Results.Rows[i].Cells["clnMN"].Value = Math.Round(res_s[i][0], accuracy) + "; " + Math.Round(res_s[i][1], accuracy);
                            dGV_Results.Rows[i].Cells["clnMN_f"].Value = Math.Round(g(res_s[i]), accuracy);
                            if (chB_LabelDraw.Checked)
                                chtGraphics.Series["srsNewton"].Points.Add(new DataPoint(res_s[i][0], res_s[i][1]) { Label = Math.Round(g(res_s[i]), accuracy).ToString() });
                            else
                                chtGraphics.Series["srsNewton"].Points.Add(res_s[i][0], res_s[i][1]);
                        }
                        /*
                        for (int i = countIter; i < dGV_Results.RowCount; i++)
                            dGV_Results.Rows[i].Cells["clnMN"].Value = dGV_Results.Rows[i].Cells["clnMN_f"].Value = "";*/
                    }

                    if (chB_MSteepestDescent.Checked || chB_GradMSplitStep.Checked || chB_MNewton.Checked)
                    {
                        lbl_InfoLastCalcFunc.Text = String.Format("для f(x) = {0} x₁ + {1} x₂ + exp({2} x₁² + {3} x₂²)", _a, _b, _c, _d);
                        lbl_InfoInit_and_Accuracy.Text = "з точністю " + _eps;
                        for (int i = 0; i < dGV_Results.RowCount; i++)
                            dGV_Results.Rows[i].HeaderCell.Value = i.ToString();

                        Series srs;
                        if (chB_ConditionalOptimization.Checked)
                            for (int i = 0; i < _A.RowCount; i++)
                            {
                                srs = new Series()
                                {
                                    Color = Color.Green,
                                    ChartType = SeriesChartType.FastLine,
                                };
                                srs.Points.AddXY(chtGraphics.ChartAreas[0].AxisX.Minimum, (_B[i] - _A.GetElement(i, 0) * chtGraphics.ChartAreas[0].AxisX.Minimum) / _A.GetElement(i, 1));
                                srs.Points.AddXY(chtGraphics.ChartAreas[0].AxisX.Maximum, (_B[i] - _A.GetElement(i, 0) * chtGraphics.ChartAreas[0].AxisX.Maximum) / _A.GetElement(i, 1));
                                chtGraphics.Series.Insert(_beg_index_lvlLines, srs);
                            }
                    }
                }
                else
                {
                    MultiDimFuncC2 currFunc = cmB_OtherFunc.SelectedItem as MultiDimFuncC2;
                    Func<Vector, double> f = currFunc.F.F;
                    Func<Vector, double>[] grad_f = currFunc.GradF;
                    Func<Vector, double>[,] hessian_f = currFunc.HessianF;
                    dGV_Results.RowCount = 0;
                    if (chB_ConditionalOptimization.Checked)
                    {
                        res = MethodsConditionalOptimization.ConditionalGradientForLinearCondition(f, grad_f, _A, _B, _initX, _eps, out res_s);
                        MessageBox.Show("fₘᵢₙ(" + res + ") = " + f(res) + "\nКількість ітерацій: " + ((countIter = res_s.Count) - 1), "Метод умовного градієнта");
                        if (dGV_Results.RowCount < countIter)
                            dGV_Results.RowCount = countIter;
                        chtGraphics.Series["srsConditionalGradient"].Points.Clear();
                        for (int i = 0; i < countIter; i++)
                        {
                            dGV_Results.Rows[i].Cells["clnCG"].Value = string.Join("; ", res_s[i].ToArray().Select<double, string>((x) => (Math.Round(x, accuracy).ToString())));
                            dGV_Results.Rows[i].Cells["clnCG_f"].Value = Math.Round(f(res_s[i]), accuracy);
                            if (_n == 2)    
                                if (chB_LabelDraw.Checked)
                                    chtGraphics.Series["srsConditionalGradient"].Points.Add(new DataPoint(res_s[i][0], res_s[i][1]) { Label = dGV_Results.Rows[i].Cells["clnCG_f"].Value.ToString() });
                                else
                                    chtGraphics.Series["srsConditionalGradient"].Points.AddXY(res_s[i][0], res_s[i][1]);
                        }                       
                    }                    

                    if (chB_MSteepestDescent.Checked)
                    {
                        res = MethodsUnConditionalOptimization.MethodOfSteepestDescent(f, grad_f, _initX, _eps, _max_aljfa, out res_s);
                        MessageBox.Show("fₘᵢₙ(" + res + ") = " + f(res) + "\nКількість ітерацій: " + ((countIter = res_s.Count) - 1), "Метод найшвидшого спуску");
                        if (dGV_Results.RowCount < countIter)
                            dGV_Results.RowCount = countIter;
                        chtGraphics.Series["srsSteepestDescent"].Points.Clear();
                        for (int i = 0; i < countIter; i++)
                        {
                            dGV_Results.Rows[i].Cells["clnMSD"].Value = string.Join("; ", res_s[i].ToArray().Select<double, string>((x) => (Math.Round(x, accuracy).ToString())));
                            dGV_Results.Rows[i].Cells["clnMSD_f"].Value = Math.Round(f(res_s[i]), accuracy);
                            if (_n == 2)
                                if (chB_LabelDraw.Checked)
                                    chtGraphics.Series["srsSteepestDescent"].Points.Add(new DataPoint(res_s[i][0], res_s[i][1]) { Label = dGV_Results.Rows[i].Cells["clnMSD_f"].Value.ToString() });
                                else
                                    chtGraphics.Series["srsSteepestDescent"].Points.AddXY(res_s[i][0], res_s[i][1]);
                        }                        
                    }

                    if (chB_GradMSplitStep.Checked)
                    {
                        res = MethodsUnConditionalOptimization.GradientMethodWithSplitStep(f, grad_f, _initX, _eps, _init_step, _coef_split, out res_s);
                        MessageBox.Show("fₘᵢₙ(" + res + ") = " + f(res) + "\nКількість ітерацій: " + ((countIter = res_s.Count) - 1), "Метод з дробленням кроку");
                        if (dGV_Results.RowCount < countIter)
                            dGV_Results.RowCount = countIter;
                        chtGraphics.Series["srsSplitStep"].Points.Clear();
                        for (int i = 0; i < countIter; i++)
                        {
                            dGV_Results.Rows[i].Cells["clnGMSS"].Value = Math.Round(res_s[i][0], accuracy) + "; " + Math.Round(res_s[i][1], accuracy);
                            dGV_Results.Rows[i].Cells["clnGMSS_f"].Value = Math.Round(f(res_s[i]), accuracy);
                            if (_n == 2)
                                if (chB_LabelDraw.Checked)
                                    chtGraphics.Series["srsSplitStep"].Points.Add(new DataPoint(res_s[i][0], res_s[i][1]) { Label = dGV_Results.Rows[i].Cells["clnGMSS_f"].Value.ToString() });
                                else
                                    chtGraphics.Series["srsSplitStep"].Points.AddXY(res_s[i][0], res_s[i][1]);                            
                        }                        
                    }
                    
                    if (chB_MNewton.Checked)
                    {
                        res = MethodsUnConditionalOptimization.NewtonsMethod(f, grad_f, hessian_f, _initX, _eps, out res_s);
                        MessageBox.Show("fₘᵢₙ(" + res + ") = " + f(res) + "\nКількість ітерацій: " + ((countIter = res_s.Count) - 1), "Метод Ньютона");
                        if (dGV_Results.RowCount < countIter)
                            dGV_Results.RowCount = countIter;
                        chtGraphics.Series["srsNewton"].Points.Clear();
                        for (int i = 0; i < countIter; i++)
                        {
                            dGV_Results.Rows[i].Cells["clnMN"].Value = Math.Round(res_s[i][0], accuracy) + "; " + Math.Round(res_s[i][1], accuracy);
                            dGV_Results.Rows[i].Cells["clnMN_f"].Value = Math.Round(f(res_s[i]), accuracy);
                            if (_n == 2)
                                if (chB_LabelDraw.Checked)
                                    chtGraphics.Series["srsNewton"].Points.Add(new DataPoint(res_s[i][0], res_s[i][1]) { Label = dGV_Results.Rows[i].Cells["clnMN_f"].Value.ToString() });
                                else
                                    chtGraphics.Series["srsNewton"].Points.AddXY(res_s[i][0], res_s[i][1]);
                        }                        
                    }

                    if (chB_MSteepestDescent.Checked || chB_GradMSplitStep.Checked || chB_MNewton.Checked || chB_ConditionalOptimization.Checked)
                    {
                        lbl_InfoLastCalcFunc.Text = "для f(x) = " + currFunc.ToString();
                        lbl_InfoInit_and_Accuracy.Text = "з точністю " + _eps;
                        for (int i = 0; i < dGV_Results.RowCount; i++)
                            dGV_Results.Rows[i].HeaderCell.Value = i.ToString();
                        if (_n == 2 && chB_ConditionalOptimization.Checked)
                        {
                            Series srs;                            
                            for (int i = 0; i < _A.RowCount; i++)
                            {
                                srs = new Series()
                                {
                                    Color = Color.Green,
                                    ChartType = SeriesChartType.FastLine,
                                };
                                srs.Points.AddXY(chtGraphics.ChartAreas[0].AxisX.Minimum, (_B[i] - _A.GetElement(i, 0) * chtGraphics.ChartAreas[0].AxisX.Minimum) / _A.GetElement(i, 1));
                                srs.Points.AddXY(chtGraphics.ChartAreas[0].AxisX.Maximum, (_B[i] - _A.GetElement(i, 0) * chtGraphics.ChartAreas[0].AxisX.Maximum) / _A.GetElement(i, 1));
                                chtGraphics.Series.Insert(_beg_index_lvlLines, srs);
                            }
                        }
                    }
                }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            try
            {
                string[] grad = new string[_n];
                string[,] hessian = new string[_n, _n];
                for (int i = 0; i < _n; i++)
                {
                    grad[i] = dGV_Gradient.Rows[i].Cells["clnDerFunc"].Value.ToString();
                    for (int j = 0; j < _n; j++)
                        hessian[i, j] = dGV_Hessian.Rows[i].Cells[j].Value.ToString();
                }
                cmB_OtherFunc.Items.Add(new MultiDimFuncC2(cmB_OtherFunc.Text, grad, hessian, _n));
                btnCancel_Click(btnAccept, new EventArgs());
                cmB_OtherFunc.SelectedIndex = cmB_OtherFunc.Items.Count - 1;
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Введіть коректні вирази для функції, її градієнта та гессіана.", "Некоректні дані");
            }
            catch (Exception)
            {
                MessageBox.Show("Заповніть поле введення для функції, таблиці градієнта та гессіана, якщо вони є пустими. Перевірте коректність виразів введених функцій.", "Помилка");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            nUD_Dimensionality.Enabled = false;
            dGV_Hessian.ReadOnly = true;
            dGV_Gradient.ReadOnly = true;
            cmB_OtherFunc.DropDownStyle = ComboBoxStyle.DropDownList;
            grB_SettingsOptimization.Dock = DockStyle.None;           
            rdB_QuadraticFunc.Enabled = true;
            rdB_NonLinearFunc.Enabled = true;
            rdB_OtherFunc.Enabled = true;
            btnAccept.Visible = false;
            btnCancel.Visible = false;
            btnAddNewFunc.Visible = true;
        }

        private void btnAddNewFunc_Click(object sender, EventArgs e)
        {
            rdB_QuadraticFunc.Enabled = false;
            rdB_NonLinearFunc.Enabled = false;
            rdB_OtherFunc.Enabled = false;
            grB_SettingsOptimization.Dock = DockStyle.Fill;
            cmB_OtherFunc.DropDownStyle = ComboBoxStyle.Simple;
            dGV_Gradient.ReadOnly = false;
            dGV_Hessian.ReadOnly = false;
            nUD_Dimensionality.Enabled = true;
            btnAddNewFunc.Visible = false;
            btnCancel.Visible = true;
            btnAccept.Visible = true;
        }

        private void chB_ConditionalOptimization_CheckedChanged(object sender, EventArgs e)
        {
            grB_LinearConditions.Visible = chB_ConditionalOptimization.Checked;
        }

        private void frmMultiDimensionalOptimization_Load(object sender, EventArgs e)
        {

        }

        private void nUD_m_ValueChanged(object sender, EventArgs e)
        {
            Matrix2D newA = Matrix2D.CreateMatrix(_m = (int)nUD_m.Value, _n);
            Vector newB = Vector.CreateVector(_m);
            for (int i = 0, min = (_m > _A.RowCount) ? _A.RowCount : _m; i < min; i++)
            {
                newB[i] = _B[i];
                for (int j = 0; j < _n; j++)
                    newA.SetElement(_A.GetElement(i, j), i, j);
            }
            _A = newA;
            _B = newB;
            dGV_MatrixA_and_Vector_b.RowCount = _m;
            for (int i = 0; i < _m; i++)
            {
                for (int j = 0; j < _n; j++)
                    dGV_MatrixA_and_Vector_b.Rows[i].Cells[j].Value = _A.GetElement(i, j).ToString();                
                dGV_MatrixA_and_Vector_b.Rows[i].Cells[_n].Value = _B[i].ToString();
            }
        }

        private void dGV_MatrixA_and_Vector_b_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            double new_value;
            if (e.ColumnIndex == _n)
                if (double.TryParse(dGV_MatrixA_and_Vector_b.Rows[e.RowIndex].Cells[_n].Value.ToString(), out new_value))
                    _B[e.RowIndex] = new_value;
                else
                    dGV_MatrixA_and_Vector_b.Rows[e.RowIndex].Cells[_n].Value = _B[e.RowIndex];
            else
                if (double.TryParse(dGV_MatrixA_and_Vector_b.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(), out new_value))
                    _A.SetElement(new_value, e.RowIndex, e.ColumnIndex);
                else
                    dGV_MatrixA_and_Vector_b.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = _A.GetElement(e.RowIndex, e.ColumnIndex);
        }

        private void dGV_MatrixA_and_Vector_b_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.Enter:
                    if (dGV_MatrixA_and_Vector_b.CurrentCell.ColumnIndex == _n)
                        if (dGV_MatrixA_and_Vector_b.CurrentCell.RowIndex == _m - 1)
                            dGV_MatrixA_and_Vector_b.Rows[0].Cells[0].Selected = true;
                        else
                            dGV_MatrixA_and_Vector_b.Rows[dGV_MatrixA_and_Vector_b.CurrentCell.RowIndex + 1].Cells[0].Selected = true;
                    else
                        dGV_MatrixA_and_Vector_b.Rows[dGV_MatrixA_and_Vector_b.CurrentCell.RowIndex].Cells[dGV_MatrixA_and_Vector_b.CurrentCell.ColumnIndex + 1].Selected = true;
                    break;
                case Keys.Down:
                    if (dGV_MatrixA_and_Vector_b.CurrentCell.RowIndex != _m - 1)                    
                        dGV_MatrixA_and_Vector_b.Rows[dGV_MatrixA_and_Vector_b.CurrentCell.RowIndex + 1].Cells[dGV_MatrixA_and_Vector_b.CurrentCell.ColumnIndex].Selected = true;
                    break;
                case Keys.Up:
                    if (dGV_MatrixA_and_Vector_b.CurrentCell.RowIndex != 0)                    
                        dGV_MatrixA_and_Vector_b.Rows[dGV_MatrixA_and_Vector_b.CurrentCell.RowIndex - 1].Cells[dGV_MatrixA_and_Vector_b.CurrentCell.ColumnIndex].Selected = true;
                    break;
                case Keys.Right:
                    if (dGV_MatrixA_and_Vector_b.CurrentCell.ColumnIndex != 0)                    
                        dGV_MatrixA_and_Vector_b.Rows[dGV_MatrixA_and_Vector_b.CurrentCell.RowIndex].Cells[dGV_MatrixA_and_Vector_b.CurrentCell.ColumnIndex - 1].Selected = true;
                    break;
                case Keys.Left:
                    if (dGV_MatrixA_and_Vector_b.CurrentCell.ColumnIndex != _n)                    
                        dGV_MatrixA_and_Vector_b.Rows[dGV_MatrixA_and_Vector_b.CurrentCell.RowIndex].Cells[dGV_MatrixA_and_Vector_b.CurrentCell.ColumnIndex + 1].Selected = true;
                    break;
                default:
                    break;
            }
        }

        private void cmB_OtherFunc_SelectedValueChanged(object sender, EventArgs e)
        {
            MultiDimFuncC2 currFunc = cmB_OtherFunc.SelectedItem as MultiDimFuncC2;
            nUD_Dimensionality.Value = currFunc.Dimension;
            for (int i = 0; i < _n; i++)
            {
                dGV_Gradient.Rows[i].Cells["clnDerFunc"].Value = currFunc[i];
                for (int j = 0; j < _n; j++)
                    dGV_Hessian.Rows[i].Cells[j].Value = currFunc[i, j];
            }
        }
    }
}
