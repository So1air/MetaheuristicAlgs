using System;
using System.Collections.Generic;
using OneDimensionalOptimization;

namespace MultiDimensionalOptimization
{
    static class MethodsUnConditionalOptimization
    {        
        public static Vector MethodOfSteepestDescent(Func<Vector, double> f, Func<Vector, double>[] grad_f, Vector x0, double eps, double max_aljfa, out List<Vector> minimizeSequence)
        {
            int n = grad_f.Length;
            if ((eps <= 0) || (max_aljfa <= 0) || (x0.Length != n))
                throw new ArgumentException();
            Vector agrad_f_x_k = Vector.CreateVector(n);
            minimizeSequence = new List<Vector>();
            double aljfa_k;
            Func<double, double> g_k;
            Vector x_k = x0.Copy();
            do 
            {
                minimizeSequence.Add(x_k);
                for (int i = 0; i < n; i++)
                    agrad_f_x_k[i] = - grad_f[i](x_k);
                g_k = (aljfa) => (f(x_k + aljfa * agrad_f_x_k));
                aljfa_k = MethodsSearchPointMinOfFunction.M_GoldenSection(g_k, 0, max_aljfa, eps);
            }
            while ((x_k - (x_k = x_k + aljfa_k * agrad_f_x_k)).Norm >= eps);
            minimizeSequence.Add(x_k);
            return x_k;            
        }

        public static Vector GradientMethodWithSplitStep(Func<Vector, double> f, Func<Vector, double>[] grad_f, Vector x0, double eps, double init_aljfa, double coefSplit, out List<Vector> minimizeSequence)
        {
            int n = grad_f.Length;
            if ((eps <= 0) || (init_aljfa <= 0) || (x0.Length != n) || (coefSplit <= 0) || (coefSplit >= 1))
                throw new ArgumentException();
            Vector agrad_f_x_k = Vector.CreateVector(n);
            minimizeSequence = new List<Vector>();
            double aljfa_k, f_x_k;
            Vector x_k = x0.Copy();
            do
            {
                minimizeSequence.Add(x_k);
                for (int i = 0; i < n; i++)
                    agrad_f_x_k[i] = -grad_f[i](x_k);
                aljfa_k = init_aljfa;
                f_x_k = f(x_k);
                while (f(x_k + aljfa_k * agrad_f_x_k) > f_x_k)
                    aljfa_k *= coefSplit;
            }
            while ((x_k - (x_k = x_k + aljfa_k * agrad_f_x_k)).Norm >= eps);
            minimizeSequence.Add(x_k);
            return x_k;      
        }

        public static Vector NewtonsMethod(Func<Vector, double> f, Func<Vector, double>[] grad_f, Func<Vector, double>[,] hessian_f, Vector x0, double eps, out List<Vector> minimizeSequence)
        {
            int n = grad_f.Length;
            if ((eps <= 0) || (hessian_f.GetLength(0) != hessian_f.GetLength(1)) || (hessian_f.GetLength(0) != n) || (x0.Length != n))
                throw new ArgumentException();

            Vector agrad_f_x_k = Vector.CreateVector(n);
            Matrix2D hessian_f_x_k = Matrix2D.CreateMatrix(n, n);
            minimizeSequence = new List<Vector>();
            Vector x_k = x0.Copy();
            do
            {
                /*hessian_f_x_k = hessian_f_x_k * hessian_f_x_k.InverseMatrix;*/
                minimizeSequence.Add(x_k);
                for (int i = 0; i < n; i++)
                {
                    agrad_f_x_k[i] = -grad_f[i](x_k);
                    for (int j = 0; j < n; j++)
                        hessian_f_x_k.SetElement(hessian_f[i, j](x_k), i, j);
                }
            }
            while ((x_k - (x_k = x_k + hessian_f_x_k.InverseMatrix * agrad_f_x_k)).Norm >= eps);
            minimizeSequence.Add(x_k);
            
            return x_k;      
        }        
    }
}
