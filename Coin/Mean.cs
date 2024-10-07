using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coin
{
    static class Mean
    {
        public static double[] Get(double[,] data)
        {
            double[] means = new double[data.GetLength(1)];

            for (int col = 0; col < data.GetLength(1); col++)
            {
                double sum = 0;
                for (int row = 0; row < data.GetLength(0); row++)
                {
                    sum += data[row, col];
                }
                means[col] = sum / data.GetLength(0);
            }
            return means;
        }
    }
}
