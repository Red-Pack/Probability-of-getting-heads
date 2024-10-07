using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coin
{
    internal class ExpError
    {
        public static double[] CalculateExpError(double[,] interval)
        {
            int colCount = interval.GetLength(1);

            double[] exp_error = new double[colCount];

            for (int j = 0; j < colCount; j++)
            {
                exp_error[j] = (interval[1, j] - interval[0, j]) / 2;
            }

            return exp_error;
        }
        public static double NormalQuantile(double p)
        {
            p = (1 + p) / 2;
            return 4.91 * (Math.Pow(p, 0.14) - Math.Pow(1 - p, 0.14));
        }
        public static double[] TheoryError(int N, double alpha)
        {
            double[] error = new double[N];
            double coef = NormalQuantile(alpha);
            for (int i = 0; i < N; i++)
            {
                error[i] = coef * Math.Sqrt(0.5 * 0.5 / (i + 1));
            }
            return error;
        }
    }
}
