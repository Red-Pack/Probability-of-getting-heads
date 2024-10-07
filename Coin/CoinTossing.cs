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
        static Random rand1 = new Random((int)DateTime.Now.Ticks & 0x0000FFFF);
        static Random rand2 = new Random((int)DateTime.Now.Ticks & 0x0000FFFF);


        private static bool FlipCoin(double time) //уже не coin и не flip
        {
            //Random rand = new Random((int)DateTime.Now.Ticks & 0x0000FFFF);
            //return Convert.ToBoolean(rand.Next(0, 2));

            double first = CalcFirst();
            double second = CalcSecond();
            if (Math.Abs(first - second) <= time)
            {
                return true;
            }
            return false;
        }



        private static double FirstStudent()
        {
            return rand1.NextDouble();
        }

        private static double SecondStudent()
        {
            return rand2.NextDouble();
        }

        private static double CalcFirst()
        {
            return 1 - Math.Sqrt(FirstStudent());
        }
        private static double CalcSecond()
        {
            return Math.Sqrt(SecondStudent());
        }

        private static double[] Experiment(int quantity, double time)
        {
            double[] result = new double[quantity];
            int counter = 0;
            for (int i = 0; i < result.Length; i++)
            {
                if (FlipCoin(time))
                    counter++;
                result[i] = (double)counter / (i + 1);
            }
            return result;
        }

        


        public static double[,] ExpSerial(int M, int N, double time)
        {
            double[,] result = new double[M,N];
            for (int i = 0; i < M; i++)
            {
                double[] resultN = Experiment(N, time);
                for (int j = 0; j < N; j++)
                {
                    result[i, j] = resultN[j];
                }
            }
            return result;
        }
    }
}
