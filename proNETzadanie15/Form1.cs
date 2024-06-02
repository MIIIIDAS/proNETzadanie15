using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SinusoidPlotter
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            PlotSinusoid();
        }

        private void PlotSinusoid()
        {
            // Ustawienia wykresu
            chart.Series.Clear();
            chart.ChartAreas[0].AxisX.Minimum = 0;
            chart.ChartAreas[0].AxisX.Maximum = 2 * Math.PI;
            chart.ChartAreas[0].AxisY.Minimum = -1;
            chart.ChartAreas[0].AxisY.Maximum = 1;
            chart.ChartAreas[0].AxisX.Title = "x";
            chart.ChartAreas[0].AxisY.Title = "sin(x)";

            // Dodawanie serii do wykresu
            Series series = chart.Series.Add("Sinusoid");
            series.ChartType = SeriesChartType.Line;
            series.Color = System.Drawing.Color.Blue;

            // Dodawanie punktów do serii (wartości funkcji sin(x))
            double step = 0.1;
            for (double x = 0; x <= 2 * Math.PI; x += step)
            {
                series.Points.AddXY(x, Math.Sin(x));
            }
        }
    }
}
