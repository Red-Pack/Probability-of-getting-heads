using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using OxyPlot.WindowsForms;
using System.Reflection;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Coin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            PlotInit();
        }

        void PlotInit()
        {
            Controls.Add(plotView1);
            var plotModel = new PlotModel()
            {
                Title = "График",
                Axes =
                {
                    new LogarithmicAxis { Position = AxisPosition.Bottom, Title = "Количество подбрасываний"},
                    new LinearAxis
                    {
                    Position = AxisPosition.Left,
                    Minimum = 0, // Минимальное значение по оси y
                    Maximum = 1  // Максимальное значение по оси y
                    }
                }
            };
            plotView1.Model = plotModel;
        }

        void DrawPlot(int N, int M, double alpha, double time)
        {
            double[,] vs = CoinTossing.ExpSerial(M, N, time);
            double[] mean = Mean.Get(vs);
            double[,] confidence = Confidence.ConfidenceInterval(vs, alpha);
            double[] expError = ExpError.CalculateExpError(confidence);
            double[] theoryError = ExpError.TheoryError(N, alpha);
            plotView1.Model.Series.Clear();


            for (int i = 0; i < M; i++)
            {
                var series = new LineSeries()
                {
                    Color = OxyColors.Black
                }; // новая серия данных

                for (int j = 0; j < N; j++)
                {
                    series.Points.Add(new DataPoint(j + 1, vs[i, j])); // Добавляем точки данных в серию

                }
                plotView1.Model.Series.Add(series);// Добавляем серию данных на график 
            }

            var meanLine = new LineSeries()
            {
                Color = OxyColors.Red
            };
            for (int i = 0; i < mean.Length; i++)
            {
                meanLine.Points.Add(new DataPoint(i + 1, mean[i])); // Добавляем точки данных в серию

            }

            for (int i = 0; i < confidence.GetLength(0); i++)
            {
                var confidenceLine = new LineSeries()
                {
                    Color = OxyColors.Blue
                };

                for (int j = 0; j < confidence.GetLength(1); j++)
                {
                    confidenceLine.Points.Add(new DataPoint(j + 1, confidence[i, j])); // Добавляем точки данных в серию

                }
                plotView1.Model.Series.Add(confidenceLine);// Добавляем серию данных на график 
            }



            plotView1.Model.Series.Add(meanLine);

            plotView1.InvalidatePlot(true);

            ErrorForm f2 = new();
            f2.Show();
            f2.DrawPlot(expError, theoryError);

            double meanValue = mean[^1];
            int lastIndex = confidence.GetLength(1) - 1;
            double confidenceInterval = (confidence[1, lastIndex] - confidence[0, lastIndex]) / 2;
            label5.Text = $"{meanValue} +- {confidenceInterval}";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int N = Convert.ToInt32(textBox1.Text);
            int M = Convert.ToInt32(textBox2.Text);
            double alpha = Convert.ToDouble(textBox3.Text);
            double time = Convert.ToDouble(textBox4.Text);
            DrawPlot(N, M, alpha, time);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != (char)Keys.Delete)
            {
                e.Handled = true;
            }
            else if (e.KeyChar == '0' && ((TextBox)sender).Text.Length == 0)
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != (char)Keys.Delete)
            {
                e.Handled = true;
            }
            else if (e.KeyChar == '0' && ((TextBox)sender).Text.Length == 0)
            {
                e.Handled = true;
            }
        }

        private void plotView1_Click(object sender, EventArgs e)
        {

        }
    }
}
