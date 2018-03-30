using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MultiDimensionalOptimization
{    
    class WeierstrassFuncGenerator : IMultiDimFuncGenerator
    {
        private readonly static double[] PI_3_k, powers_half;
        private static double spec_summ;

        static WeierstrassFuncGenerator()
        {
            PI_3_k = new double[21];
            powers_half = new double[21];
            long powers_three = 1;
            double pow_half = 1;
            powers_half[0] = 1d;
            PI_3_k[0] = Math.PI;
            spec_summ = -1d;
            for (int i = 1; i <= 20; i++)
                spec_summ += (powers_half[i] = (pow_half *= 0.5)) * Math.Cos(PI_3_k[i] = Math.PI * (powers_three *= 3));
        }

        public Func<Vector, double> GetFunc(ushort d = 2)
        {
            if (d == 0)
                throw new ArgumentException("d");

            return (x) =>
            {
                double res = 0, x_i_plus_half;
                for (int i = 0; i < d; i++)
                {
                    x_i_plus_half = x[i] + 0.5;
                    for (int j = 0; j <= 20; j++)
                        res += powers_half[j] * Math.Cos(2d * PI_3_k[j] * x_i_plus_half);
                }
                return res / d - spec_summ;
            };
        }
    }
}
