using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MathY
{
    public partial class Form1 : Form
    {
        public static ChartArea area;
        public static Series series;
        public static Chart chart;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text.Contains("y = kx"))
            {
                area = new ChartArea("y=kx");
                area.AxisX.Crossing = 0;
                area.AxisY.Crossing = 0;

                series = new Series();
                series.ChartType = SeriesChartType.Line;
                series.ChartArea = "y=kx";

                chart = new Chart();
                chart.Parent = this;
                chart.Dock = DockStyle.Fill;

                chart.ChartAreas.Add(area);
                chart.Series.Add(series);

                int k = Convert.ToInt32(numericUpDown1.Value);
                for (int x = -10; x <= 20; x += 10)
                {
                    int y = k * x;
                    series.Points.AddXY(x, y);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            chart.Series.Clear();
        }
    }
}
