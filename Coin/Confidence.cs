using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Coin
{
    internal class Confidence
    {
        static double[,] Sort2DArray(double[,] array)
        {
            int rowCount = array.GetLength(0);
            int colCount = array.GetLength(1);

            double[,] sortedArray = new double[rowCount, colCount];
            for (int i = 0; i < colCount; i++)
            {
                double[] columnValues = new double[rowCount];
                for (int j = 0; j < rowCount; j++)
                {
                    columnValues[j] = array[j, i];
                }
                Array.Sort(columnValues);
                for (int j = 0; j < rowCount; j++)
                {
                    sortedArray[j, i] = columnValues[j];
                }
            }
            return sortedArray;
        }
        public static double[,] ConfidenceInterval(double[,] data, double alpha)
        {
            int m = data.GetLength(0);
            double a = (1 - alpha) / 2;
            int m_down = (int)(m * a);
            int m_up = m - m_down - 1;

            var sortedData = Sort2DArray(data);

            double[,] result = new double[2, sortedData.GetLength(1)];
            for (int i = 0; i < sortedData.GetLength(1); i++)
            {
                result[0, i] = sortedData[m_down, i];
                result[1, i] = sortedData[m_up, i];
            }
            return result;
        }
    }
}
