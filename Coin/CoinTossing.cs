using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OxyPlot;
using OxyPlot.Series;

namespace Coin
{
    internal class CoinTossing
    {
        
        private static bool FlipCoin()
        {
            Random rand = new Random((int)DateTime.Now.Ticks & 0x0000FFFF);
            return Convert.ToBoolean(rand.Next(0, 2));
        }

        private static decimal[] Experiment(int quantity)
        {
            decimal[] result = new decimal[quantity];
            int counter = 0;
            for (int i = 0; i < result.Length; i++)
            {
                if (FlipCoin())
                    counter++;
                result[i] = counter / (i + 1);
            }
            return result;
        }

        public static decimal[,] ExpSerial(int M, int N)
        {
            decimal[,] result = new decimal[M,N];
            for (int i = 0; i < M; i++)
            {
                decimal[] resultN = Experiment(N);
                for (int j = 0; j < N; j++)
                {
                    result[i, j] = resultN[j];
                }
            }
            return result;
        }
    }
}
