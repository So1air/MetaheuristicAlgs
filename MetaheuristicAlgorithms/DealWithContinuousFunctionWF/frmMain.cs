using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Metaheuristics;
using Metaheuristics.PopulationAlgs.BehavioralAlgs;
using MultiDimensionalOptimization;
using System.Windows.Forms.DataVisualization.Charting;

namespace DealWithContinuousFunctionWF
{
    public partial class frmMain : Form
    {
        private Random _accidentFactor = new Random();
        private double _cInertia = 1d / (2 * Math.Log(2)), //~0.72;
                      _cСognitive = 0.5 + Math.Log(2),    //~1.19;
                      _cSocial,
                      _cGlobal,
                      _stepSize = 0.5;
        private bool _min_or__ = true;
        private StepModification _stMod;
        private VectorPSO _currSolving;        

        public frmMain()
        {
            InitializeComponent();
            cmB_FitnessFunc.SelectedIndex = 0;
            nUD_Dimensionality.Value = 2;
            dGV_Restrictions.RowHeadersWidth = 50;
            nUD_Threshold.Maximum = decimal.MaxValue;
            nUD_MaxIterations.Maximum = decimal.MaxValue;
            txB_Inertia.Text = _cInertia.ToString();
            txB_Personal.Text = _cСognitive.ToString();
            txB_Social.Text = (_cSocial = _cСognitive).ToString();
            txB_Global.Text = (_cGlobal = _cСognitive).ToString();
            cmB_TypeTopology.Items.Add(TopologyLinkages.Star);
            cmB_TypeTopology.Items.Add(TopologyLinkages.Circle);
            cmB_TypeTopology.Items.Add(TopologyLinkages.RandomInformants);
            cmB_TypeTopology.SelectedIndex = 0;
            txB_StepSize.Text = _stepSize.ToString();
            cmB_StepModification.SelectedIndex = 0;
        }

        private void btnAddNewFitFunc_Click(object sender, EventArgs e)
        {
            //futureeeeeeeeeeeeeeeeeeeeeeeeeeeee
        }

        private void txB_Inertia_Validated(object sender, EventArgs e)
        {
            double w;
            if (double.TryParse(txB_Inertia.Text, out w) && (w > 0) && (w <= 1))
                _cInertia = w;
            else
                txB_Inertia.Text = _cInertia.ToString();
        }

        private void txB_Personal_Validated(object sender, EventArgs e)
        {
            double c1;
            if (double.TryParse(txB_Personal.Text, out c1) && (c1 > 0) && (c1 <= 2))
                _cСognitive = c1;
            else
                txB_Personal.Text = _cСognitive.ToString();
        }

        private void txB_Social_Validated(object sender, EventArgs e)
        {
            double c2;
            if (double.TryParse(txB_Social.Text, out c2) && (c2 > 0) && (c2 <= 2))
                _cSocial = c2;
            else
                txB_Social.Text = _cSocial.ToString();
        }

        private void txB_Global_Validated(object sender, EventArgs e)
        {
            double c3;
            if (double.TryParse(txB_Global.Text, out c3) && (c3 > 0) && (c3 <= 2))
                _cGlobal = c3;
            else
                txB_Global.Text = _cGlobal.ToString();
        }

        private void btnSwitchMinMax_Click(object sender, EventArgs e)
        {
            if (_min_or__ = !_min_or__)
                btnSwitchMinMax.Text = "min";
            else
                btnSwitchMinMax.Text = "max";
        }

        private void nUD_MinInformants_ValueChanged(object sender, EventArgs e)
        {
            nUD_MaxInformants.Minimum = nUD_MinInformants.Value;
        }

        private void nUD_MaxInformants_ValueChanged(object sender, EventArgs e)
        {
            nUD_MinInformants.Maximum = nUD_MaxInformants.Value;
        }

        private void nUD_SizeSwarm_ValueChanged(object sender, EventArgs e)
        {
            nUD_MaxInformants.Maximum = nUD_SizeSwarm.Value;
        }

        private void cmB_TypeTopology_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((TopologyLinkages)cmB_TypeTopology.SelectedItem == TopologyLinkages.RandomInformants)
                lblThreshold.Visible = nUD_Threshold.Visible = lblInformants.Visible = lblMinInformants.Visible =
                    lblMaxInformants.Visible = nUD_MinInformants.Visible = nUD_MaxInformants.Visible = true;
            else
                lblThreshold.Visible = nUD_Threshold.Visible = lblInformants.Visible = lblMinInformants.Visible = 
                    lblMaxInformants.Visible = nUD_MinInformants.Visible = nUD_MaxInformants.Visible = false;
        }

        private void txB_StepSize_Validated(object sender, EventArgs e)
        {
            double ss;
            if (double.TryParse(txB_StepSize.Text, out ss) && (ss > 0) && (ss <= 1))
                _stepSize = ss;
            else
                txB_StepSize.Text = _stepSize.ToString();
        }

        private void cmB_StepModification_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmB_StepModification.SelectedIndex)
            {
                case 0:
                    lblStepSize.Visible = false;
                    txB_StepSize.Visible = false;
                    lblCountStepsLocalSearch.Visible = false;
                    nUD_CountStepsLocalSearch.Visible = false; 
                    break;
                case 1:
                    lblCountStepsLocalSearch.Visible = false;
                    nUD_CountStepsLocalSearch.Visible = false;
                    lblStepSize.Visible = true;
                    txB_StepSize.Visible = true;
                    break;
                case 2:
                    lblStepSize.Visible = false;
                    txB_StepSize.Visible = false;
                    lblCountStepsLocalSearch.Visible = false;
                    nUD_CountStepsLocalSearch.Visible = false; 
                    break;
                case 3:
                    lblStepSize.Visible = false;
                    txB_StepSize.Visible = false;
                    lblCountStepsLocalSearch.Visible = true;
                    nUD_CountStepsLocalSearch.Visible = true;                    
                    break;
                default:
                    throw new NotImplementedException();
            }
        }

        private void nUD_Dimensionality_ValueChanged(object sender, EventArgs e)
        {
            if (nUD_Dimensionality.Value > dGV_Restrictions.RowCount)
                while (nUD_Dimensionality.Value != dGV_Restrictions.RowCount)
                {
                    dGV_Restrictions.Rows.Add();
                    dGV_Restrictions.Rows[dGV_Restrictions.RowCount - 1].HeaderCell.Value = "x" + NumberToLowIndex(dGV_Restrictions.RowCount);
                    dGV_Restrictions.Rows[dGV_Restrictions.RowCount - 1].Cells["clnMinX"].Value = -1;
                    dGV_Restrictions.Rows[dGV_Restrictions.RowCount - 1].Cells["clnMaxX"].Value = 1;
                }
            else
                dGV_Restrictions.RowCount = (int)nUD_Dimensionality.Value;
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

        private void dGV_Restrictions_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            double valueCell;
            switch (e.ColumnIndex)
            {
                case 0:
                    if (! (double.TryParse(dGV_Restrictions.Rows[e.RowIndex].Cells[0].Value.ToString(), out valueCell) 
                          && 
                          (valueCell <= Convert.ToDouble(dGV_Restrictions.Rows[e.RowIndex].Cells[1].Value))))
                        dGV_Restrictions.Rows[e.RowIndex].Cells[0].Value = dGV_Restrictions.Rows[e.RowIndex].Cells[1].Value;
                    break;
                case 1:
                    if (! (double.TryParse(dGV_Restrictions.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString(), out valueCell) 
                          && 
                          (valueCell >=  Convert.ToDouble(dGV_Restrictions.Rows[e.RowIndex].Cells[0].Value))))
                        dGV_Restrictions.Rows[e.RowIndex].Cells[1].Value = dGV_Restrictions.Rows[e.RowIndex].Cells[0].Value;
                    break;
                default:
                    break;
            }
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            ushort dimensionality = (ushort)nUD_Dimensionality.Value;
            Func<Vector, double> ff;
            switch(cmB_FitnessFunc.SelectedIndex)
            {
                case 0:
                    ff = new SphericalFuncGenerator().GetFunc(dimensionality);
                    break;
                case 1:
                    ff = new EllipticalFuncGenerator().GetFunc(dimensionality);
                    break;
                case 2:
                    ff = new Schwefel1_2FuncGenerator().GetFunc(dimensionality);
                    break;
                case 3:
                    ff = new RosenbrockFuncGenerator().GetFunc(dimensionality);
                    break;
                case 4:
                    ff = new RastriginFuncGenerator().GetFunc(dimensionality);
                    break;
                case 5:
                    ff = new GriewankFuncGenerator().GetFunc(dimensionality);
                    break;
                case 6:
                    ff = new AlpineFuncGenerator().GetFunc(dimensionality);
                    break;
                case 7:
                    ff = new SchwefelFuncGenerator().GetFunc(dimensionality);
                    break;
                case 8:
                    ff = new AckleyFuncGenerator().GetFunc(dimensionality);
                    break;
                case 9:
                    ff = new WeierstrassFuncGenerator().GetFunc(dimensionality);
                    break;
                default:
                    ff = ((FitnessFunc<Vector>)cmB_FitnessFunc.SelectedItem).F;
                    break;
            }
            Vector leftBottomPoint = Vector.CreateVector(dimensionality);
            double[] sides = new double[dimensionality];
            for (int i = 0; i < dimensionality; i++)
            {
			    leftBottomPoint[i] = Convert.ToDouble(dGV_Restrictions["clnMinX", i].Value);
                sides[i] = Convert.ToDouble(dGV_Restrictions["clnMaxX", i].Value) - leftBottomPoint[i];
            }
            object[] paramsTopology;
            switch ((TopologyLinkages)cmB_TypeTopology.SelectedItem)
            {
                case TopologyLinkages.Star:
                    paramsTopology = new object[] { };
                    break;
                case TopologyLinkages.Circle:
                    paramsTopology = new object[] { };
                    break;
                case TopologyLinkages.RandomInformants:
                    paramsTopology = new object[] { nUD_MinInformants.Value, nUD_MaxInformants.Value };
                    break;
                default:
                    throw new NotImplementedException();
            }
            Swarm<Vector, Vector> sw = new Swarm<Vector, Vector>(ff,
                                                                new RectangularHyperParallelogram(leftBottomPoint, sides),
                                                                _accidentFactor,
                                                                (ushort)nUD_SizeSwarm.Value,
                                                                !_min_or__,
                                                                (TopologyLinkages)cmB_TypeTopology.SelectedItem,
                                                                paramsTopology);
            _currSolving = new VectorPSO(sw) 
                           { 
                               CInertiа = _cInertia,
                               CСognitive = _cСognitive,
                               CSocial = _cSocial,
                               CGlobal = _cGlobal,
                               StepModification = _stMod,
                               SizeStep = _stepSize,
                               CountStepLocalSearch = (byte)nUD_CountStepsLocalSearch.Value,
                               Threshold = (byte)nUD_Threshold.Value
                           };

            if (dimensionality == 2)
            {
                chtDemoState.Series["srsParticles"].Points.Clear();
                chtDemoState.Series["srsDirections"].Points.Clear();
                DataPoint d1, d2;
                Series srs;
                for (int i = 0; i < sw.Size; i++)
			    {

			        chtDemoState.Series["srsParticles"].Points.Add(d1 = new DataPoint(sw[i].CurrPosition[0], sw[i].CurrPosition[1]) 
                                                                   { 
                                                                        Label = Math.Round(sw[i].ValueFitness, 3).ToString() 
                                                                   });
                    chtDemoState.Series["srsDirections"].Points.Add(d2 = new DataPoint(sw[i].CurrPosition[0] + sw[i].CurrSpeed[0], sw[i].CurrPosition[1] + sw[i].CurrSpeed[1]));
                    srs = new Series() { Color = Color.Blue, ChartType = SeriesChartType.Line };
                    srs.Points.AddXY(d1.XValue, d1.YValues[0]);
                    srs.Points.AddXY(d2.XValue, d2.YValues[0]);
                    chtDemoState.Series.Add(srs); 
                }
                chtDemoState.ChartAreas[0].AxisX.Minimum = Convert.ToDouble(dGV_Restrictions["clnMinX", 0].Value);
                chtDemoState.ChartAreas[0].AxisX.Maximum = Convert.ToDouble(dGV_Restrictions["clnMaxX", 0].Value);
                chtDemoState.ChartAreas[0].AxisY.Minimum = Convert.ToDouble(dGV_Restrictions["clnMinX", 1].Value);
                chtDemoState.ChartAreas[0].AxisY.Maximum = Convert.ToDouble(dGV_Restrictions["clnMaxX", 1].Value); 
            }
        }           
    }
}
