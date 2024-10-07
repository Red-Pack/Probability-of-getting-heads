using OxyPlot.Axes;
using OxyPlot;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OxyPlot.Series;

namespace Coin
{
    public partial class ErrorForm : Form
    {
        public ErrorForm()
        {
            InitializeComponent();
            PlotInit();
        }

        public void DrawPlot(double[] expError, double[] theoryError)
        {
            var expErrorLine = new LineSeries()
            {
                Color = OxyColors.Red
            };

            for (int i = 0; i < expError.Length; i++)
            {
                expErrorLine.Points.Add(new DataPoint(i + 1, expError[i])); // Добавляем точки данных в серию

            }

            var theoryErrorLine = new LineSeries()
            {
                Color = OxyColors.Blue
            };

            for (int i = 0; i < theoryError.Length; i++)
            {
                theoryErrorLine.Points.Add(new DataPoint(i + 1, theoryError[i])); // Добавляем точки данных в серию

            }

            plotView1.Model.Series.Add(expErrorLine);
            plotView1.Model.Series.Add(theoryErrorLine);
            plotView1.InvalidatePlot(true);


        }

        void PlotInit()
        {
            Controls.Add(plotView1);
            var plotModel = new PlotModel()
            {
                Title = "График ошибки",
                Axes =
                {
                    new LogarithmicAxis { Position = AxisPosition.Bottom},
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
    }
}
