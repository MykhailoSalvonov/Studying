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

namespace UI
{
    public partial class MainView : Form
    {
        public MainView()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Data = SimulatedAnnealing.Calculate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Series series1 = new Series();
            Series series2 = new Series();
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.ChartType = SeriesChartType.FastLine;
            foreach(var item in Data)
            {
                series1.Points.AddXY(item.Iteration, item.Distance);
                series2.Points.AddXY(item.Iteration, item.Temperature);
            }

            ChartView newForm1 = new ChartView(series1);
            ChartView newForm2 = new ChartView(series2);
            newForm1.Show();
            newForm2.Show();
        }

        List<StaticticPoint> Data;
    }
}
