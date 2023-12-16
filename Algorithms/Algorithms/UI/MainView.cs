using System;
using System.Collections.Generic;
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
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.ChartType = SeriesChartType.FastLine;
            foreach(var item in Data)
            {
                series1.Points.AddXY(item.Iteration, item.Distance);
            }

            ChartView newForm1 = new ChartView(series1);
            newForm1.Show();
        }

        List<StaticticPoint> Data;
    }
}
