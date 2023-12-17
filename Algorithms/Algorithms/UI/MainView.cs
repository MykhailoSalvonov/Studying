using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using UI.Properties;

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

        private void UkrMenuItem_Click(object sender, EventArgs e)
        {
            description.Text = Resources.ukr_description_text;
            calculateBtn.Text = "Розрахувати";
            chartBtn.Text = "Зобразити графік";
            configureMap.Text = "Налаштування карти";
            configureAlgorithm.Text = "Налаштування алгоритму";
            selectAlgorithmLabel.Text = "Оберіть алгоритм: ";
            Text = "Задача комівояжера";
        }

        private void EngMenuItem_Click(object sender, EventArgs e)
        {
            description.Text = Resources.eng_description_text;
            calculateBtn.Text = "Calculate";
            chartBtn.Text = "Show chart";
            configureMap.Text = "Configure map";
            configureAlgorithm.Text = "Configure algorithm";
            selectAlgorithmLabel.Text = "Select algorithm: ";
            Text = "Travelling salesman problem";
        }

        private void description_Click(object sender, EventArgs e)
        {

        }
    }
}
