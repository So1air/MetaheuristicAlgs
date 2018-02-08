using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class frmMain : Form
    {
        double last_find_point_minHI, last_find_point_minGS, last_find_point_minFb;
        int index_function = -1;

        public frmMain()
        {
            InitializeComponent();
            cmB_Functions.Items.Add(FuncWithText.CreateInstance("(x - 1) * Math.Exp(x)"));
            MethodsSearchPointMinOfFunction.A = -1;
            MethodsSearchPointMinOfFunction.B = 1;
            MethodsSearchPointMinOfFunction.Eps = 0.001;
            txB_a.Text = "-1";
            txB_b.Text = "1";
            txB_eps.Text = "0,001";
            cmB_Functions.SelectedIndex = 0;
        }

        private void txB_a_Validated(object sender, EventArgs e)
        {
            double a;
            if (double.TryParse(txB_a.Text, out a))
            {
                if (MethodsSearchPointMinOfFunction.A != a)
                {
                    MethodsSearchPointMinOfFunction.A = a;
                    if (cmB_Functions.SelectedIndex >= 0) ReDrawGraph();
                }
            }
            else txB_a.Text = MethodsSearchPointMinOfFunction.A.ToString();
        }

        private void txB_b_Validated(object sender, EventArgs e)
        {
            double b;
            if (double.TryParse(txB_b.Text, out b))
            {
                if (MethodsSearchPointMinOfFunction.B != b)
                {
                    MethodsSearchPointMinOfFunction.B = b;
                    if (cmB_Functions.SelectedIndex >= 0) ReDrawGraph();
                }
            }
            else txB_b.Text = MethodsSearchPointMinOfFunction.B.ToString();
        }

        private void txB_eps_Validated(object sender, EventArgs e)
        {
            double eps;
            if (double.TryParse(txB_eps.Text, out eps))
            {
                if (MethodsSearchPointMinOfFunction.Eps != eps)
                {
                    MethodsSearchPointMinOfFunction.Eps = eps;
                    //if (cmB_Functions.SelectedIndex >= 0) ReDrawGraph();
                }
            }
            else txB_eps.Text = MethodsSearchPointMinOfFunction.Eps.ToString();
        }

        private void btnAddFunction_Click(object sender, EventArgs e)
        {
            switch (cmB_Functions.DropDownStyle)
            {
                case ComboBoxStyle.Simple:
                    FuncWithText fwt = FuncWithText.CreateInstance(cmB_Functions.Text);
                    if (fwt != null)
                    {
                        cmB_Functions.Items.Add(fwt);
                        cmB_Functions.SelectedIndex = cmB_Functions.Items.Count - 1;
                        cmB_Functions.ForeColor = Color.Black;
                        btnCancelAddition.Visible = false;
                        
                        cmB_Functions.DropDownStyle = ComboBoxStyle.DropDownList;

                        grB_ViewOfResults.Enabled = true;
                        txB_a.Enabled = true;
                        txB_b.Enabled = true;
                        txB_eps.Enabled = true;
                        btnAddFunction.Text = "Додати";
                    }
                    else
                        cmB_Functions.ForeColor = Color.Red;
                    break;

                case ComboBoxStyle.DropDownList:
                    grB_ViewOfResults.Enabled = false;
                    txB_a.Enabled = false;
                    txB_b.Enabled = false;
                    txB_eps.Enabled = false;

                    cmB_Functions.DropDownStyle = ComboBoxStyle.Simple;
                    btnAddFunction.Visible = true;
                    btnCancelAddition.Visible = true;
                    btnAddFunction.Text = "Підтвердити";
                    break;

                default:
                    break;
            }
        }

        private void btnCancelAddition_Click(object sender, EventArgs e)
        {
            cmB_Functions.SelectedIndex = cmB_Functions.Items.Count - 1;
            cmB_Functions.ForeColor = Color.Black;
            btnCancelAddition.Visible = false;
            btnAddFunction.Visible = false;
            cmB_Functions.DropDownStyle = ComboBoxStyle.DropDownList;

            grB_ViewOfResults.Enabled = true;
            txB_a.Enabled = true;
            txB_b.Enabled = true;
            txB_eps.Enabled = true;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int accuracy = txB_eps.Text.Length - txB_eps.Text.IndexOf(',') - 1;
            FuncWithText currFunction = (FuncWithText)cmB_Functions.SelectedItem;
            List<MethodsSearchPointMinOfFunction.M_Info>[] results = new List<MethodsSearchPointMinOfFunction.M_Info>[3];
            last_find_point_minHI = MethodsSearchPointMinOfFunction.M_HalfInterval(rdB_min.Checked ? currFunction.F : (x) => -currFunction.F(x), out results[0]);
            last_find_point_minGS = MethodsSearchPointMinOfFunction.M_GoldenSection(rdB_min.Checked ? currFunction.F : (x) => -currFunction.F(x), out results[1]);
            last_find_point_minFb = MethodsSearchPointMinOfFunction.M_Fibonacci(rdB_min.Checked ? currFunction.F : (x) => -currFunction.F(x), out results[2]);
            dGV_ResultCalculation.Rows.Clear();
            dGV_ResultCalculation.RowCount = ((results[0].Count > results[1].Count) ? ((results[0].Count > results[2].Count) ? results[0].Count : results[2].Count) : ((results[1].Count > results[2].Count) ? results[1].Count : results[2].Count)) + 1;
            for (int i = 0, n = dGV_ResultCalculation.RowCount - 1; i < n; i++)
                dGV_ResultCalculation.Rows[i].Cells["clnNumIteration"].Value = i;
            dGV_ResultCalculation.Rows[dGV_ResultCalculation.RowCount - 1].Cells["clnNumIteration"].Value = "x" + (rdB_min.Checked ? "ₘᵢₙ" : "ₘₐₓ"); 
            for (int i = 0, n = results[0].Count; i < n; i++)
            {
                dGV_ResultCalculation.Rows[i].Cells["cln_a_k"].Value = "HI: " + Math.Round(results[0][i].a_k, accuracy, MidpointRounding.ToEven).ToString();
                dGV_ResultCalculation.Rows[i].Cells["cln_b_k"].Value = Math.Round(results[0][i].b_k, accuracy, MidpointRounding.ToEven).ToString();
                dGV_ResultCalculation.Rows[i].Cells["clnLjambda_k"].Value = Math.Round(results[0][i].ljambda_k, accuracy, MidpointRounding.ToEven).ToString();
                dGV_ResultCalculation.Rows[i].Cells["clnMju_k"].Value = Math.Round(results[0][i].mju_k, accuracy, MidpointRounding.ToEven).ToString();
                dGV_ResultCalculation.Rows[i].Cells["clnFLjambda_k"].Value = Math.Round(currFunction.F(results[0][i].ljambda_k), accuracy, MidpointRounding.ToEven).ToString();
                dGV_ResultCalculation.Rows[i].Cells["clnFMju_k"].Value = Math.Round(currFunction.F(results[0][i].mju_k), accuracy, MidpointRounding.ToEven).ToString();
            }
            dGV_ResultCalculation.Rows[dGV_ResultCalculation.RowCount - 1].Cells["cln_a_k"].Value = "HI: " + Math.Round(last_find_point_minHI, accuracy, MidpointRounding.ToEven);
            dGV_ResultCalculation.Rows[dGV_ResultCalculation.RowCount - 1].Cells["cln_b_k"].Value = "f(x" + (rdB_min.Checked ? "ₘᵢₙ" : "ₘₐₓ") + ") = " + Math.Round(currFunction.F(last_find_point_minHI), accuracy, MidpointRounding.ToEven).ToString();
            for (int i = 0, n = results[1].Count; i < n; i++)
            {
                dGV_ResultCalculation.Rows[i].Cells["cln_a_k"].Value += "\n" + "GS: " + Math.Round(results[1][i].a_k, accuracy, MidpointRounding.ToEven).ToString();
                dGV_ResultCalculation.Rows[i].Cells["cln_b_k"].Value += "\n" + Math.Round(results[1][i].b_k, accuracy, MidpointRounding.ToEven).ToString();
                dGV_ResultCalculation.Rows[i].Cells["clnLjambda_k"].Value += "\n" + Math.Round(results[1][i].ljambda_k, accuracy, MidpointRounding.ToEven).ToString();
                dGV_ResultCalculation.Rows[i].Cells["clnMju_k"].Value += "\n" + Math.Round(results[1][i].mju_k, accuracy, MidpointRounding.ToEven).ToString();
                dGV_ResultCalculation.Rows[i].Cells["clnFLjambda_k"].Value += "\n" + Math.Round(currFunction.F(results[1][i].ljambda_k), accuracy, MidpointRounding.ToEven).ToString();
                dGV_ResultCalculation.Rows[i].Cells["clnFMju_k"].Value += "\n" + Math.Round(currFunction.F(results[1][i].mju_k), accuracy, MidpointRounding.ToEven).ToString();
            }
            dGV_ResultCalculation.Rows[dGV_ResultCalculation.RowCount - 1].Cells["cln_a_k"].Value += "\n" + "GS: " + Math.Round(last_find_point_minGS, accuracy, MidpointRounding.ToEven);
            dGV_ResultCalculation.Rows[dGV_ResultCalculation.RowCount - 1].Cells["cln_b_k"].Value += "\n" + "f(x" + (rdB_min.Checked ? "ₘᵢₙ" : "ₘₐₓ") + ") = " + Math.Round(currFunction.F(last_find_point_minGS), accuracy, MidpointRounding.ToEven).ToString();
            for (int i = 0, n = results[2].Count; i < n; i++)
            {
                dGV_ResultCalculation.Rows[i].Cells["cln_a_k"].Value += "\n" + "Fb: " + Math.Round(results[2][i].a_k, accuracy, MidpointRounding.ToEven).ToString();
                dGV_ResultCalculation.Rows[i].Cells["cln_b_k"].Value += "\n" + Math.Round(results[2][i].b_k, accuracy, MidpointRounding.ToEven).ToString();
                dGV_ResultCalculation.Rows[i].Cells["clnLjambda_k"].Value += "\n" + Math.Round(results[2][i].ljambda_k, accuracy, MidpointRounding.ToEven).ToString();
                dGV_ResultCalculation.Rows[i].Cells["clnMju_k"].Value += "\n" + Math.Round(results[2][i].mju_k, accuracy, MidpointRounding.ToEven).ToString();
                dGV_ResultCalculation.Rows[i].Cells["clnFLjambda_k"].Value += "\n" + Math.Round(currFunction.F(results[2][i].ljambda_k), accuracy, MidpointRounding.ToEven).ToString();
                dGV_ResultCalculation.Rows[i].Cells["clnFMju_k"].Value += "\n" + Math.Round(currFunction.F(results[2][i].mju_k), accuracy, MidpointRounding.ToEven).ToString();
            }
            dGV_ResultCalculation.Rows[dGV_ResultCalculation.RowCount - 1].Cells["cln_a_k"].Value += "\n" + "Fb: " + Math.Round(last_find_point_minFb, accuracy, MidpointRounding.ToEven);
            dGV_ResultCalculation.Rows[dGV_ResultCalculation.RowCount - 1].Cells["cln_b_k"].Value += "\n" + "f(x" + (rdB_min.Checked ? "ₘᵢₙ" : "ₘₐₓ") + ") = " + Math.Round(currFunction.F(last_find_point_minFb), accuracy, MidpointRounding.ToEven).ToString();

            index_function = cmB_Functions.SelectedIndex;
            lblInfoAboutCalculation.Text = String.Format("Результати розрахунків {0} для функції f(x) = {1} на відрізку [{2}, {3}] з точністю {4}", (rdB_min.Checked) ? "min" : "max", currFunction.ToString(), txB_a.Text, txB_b.Text, txB_eps.Text);
            chtGraphOfFunction.Series[1].Points.Clear();
            chtGraphOfFunction.Series[2].Points.Clear();
            chtGraphOfFunction.Series[3].Points.Clear();
            chtGraphOfFunction.Series[1].Points.AddXY(last_find_point_minHI, currFunction.F(last_find_point_minHI));
            chtGraphOfFunction.Series[2].Points.AddXY(last_find_point_minGS, currFunction.F(last_find_point_minGS));
            chtGraphOfFunction.Series[3].Points.AddXY(last_find_point_minFb, currFunction.F(last_find_point_minFb));
        }        

        private void cmB_Functions_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReDrawGraph();
        }

        private void ReDrawGraph()
        {
            Func<double, double> f = ((FuncWithText)cmB_Functions.Items[cmB_Functions.SelectedIndex]).F;
            chtGraphOfFunction.Series[0].Points.Clear();
            chtGraphOfFunction.Series[1].Points.Clear();
            chtGraphOfFunction.Series[2].Points.Clear();
            chtGraphOfFunction.Series[3].Points.Clear();

            try
            {
                for (double x = MethodsSearchPointMinOfFunction.A, step = (MethodsSearchPointMinOfFunction.B - MethodsSearchPointMinOfFunction.A) / this.chtGraphOfFunction.Width; x <= MethodsSearchPointMinOfFunction.B; x += step/*MethodsSearchPointMinOfFunction.Eps*/)
                    chtGraphOfFunction.Series[0].Points.AddXY(x, f(x));

                if (cmB_Functions.SelectedIndex == index_function)
                {
                    chtGraphOfFunction.Series[1].Points.AddXY(last_find_point_minHI, f(last_find_point_minHI));
                    chtGraphOfFunction.Series[2].Points.AddXY(last_find_point_minGS, f(last_find_point_minGS));
                    chtGraphOfFunction.Series[3].Points.AddXY(last_find_point_minFb, f(last_find_point_minFb));
                }
            }
            finally
            {
            }
        }
    }
}
