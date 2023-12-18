using System;
using System.Windows.Forms;
using UI.AlgorithmConfigurationWindow;
using UI.Algorithms;
using UI.Algorithms.Annealing;
using UI.Algorithms.AntsAlgorithm;
using UI.Algorithms.Genetic2;

namespace UI
{
    public partial class MainView : Form
    {
        private Algorithm Algorithm { get; set; }
        private int result;
        private CalculateAlgorithm Calculation { get; set; }
        private delegate int CalculateAlgorithm(int[,] distance);

        private static int[,] distances = {
            { 0, 11, 17, 21, 32, 22 },
            { 11, 0, 24, 9, 35, 45 },
            { 17, 24, 0, 42, 19, 12 },
            { 21, 9, 42, 0, 8, 27 },
            { 32, 35, 19, 8, 0, 28 },
            { 22, 45, 12, 27, 28, 0 }
        };

        public MainView()
        {
            InitializeComponent();
        }

        private void calculate_button_Click(object sender, EventArgs e)
        {
            result = Calculation(distances);
            resultBtn.Enabled = true;
        }

        private void result_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"The best algorithm ({Algorithm}) solution is: {result}", "Result");
        }

        private void algorithmSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (algorithmSelector.SelectedItem.ToString()) 
            {
                case "Simulated Annealing":
                    Algorithm = Algorithm.Annealing;
                    configureAlgorithm.Enabled = true;
                    break;
                case "Ant Algorithm":
                    Algorithm = Algorithm.Ant;
                    configureAlgorithm.Enabled = true;
                    break;
                case "Genetic Algorithm":
                    Algorithm = Algorithm.Genetic;
                    configureAlgorithm.Enabled = true;
                    break;
                
                default:
                    throw new ArgumentException("Cannot find such algorithm.");
            }
        }

        private void configureMap_Click(object sender, EventArgs e)
        {
            var wnd = new ConfigurationMapWindow();

            wnd.FillGridWithData(distances);
            
            wnd.ShowDialog();

            distances = wnd.ExtractDataFromGrid();
        }

        private void configureAlgorithm_Click(object sender, EventArgs e)
        {
            switch(Algorithm) 
            { 
                case Algorithm.Annealing:
                    var parameters1 = ApplyConfiguration<SimulatedAnnealingConfiguration, AnnealingAlgorithmParameters>(new SimulatedAnnealingConfiguration());
                    if(parameters1 != null)
                        Calculation = new SimulatedAnnealing(parameters1.Value).Calculate;
                    break;
                case Algorithm.Ant:
                    var parameters2 = ApplyConfiguration<AntAlgorithmConfiguration, AntsAlgorithmParameters>(new AntAlgorithmConfiguration());
                    if (parameters2 != null)
                        Calculation = new AntColonyOptimizer(parameters2.Value).Calculate;
                    break;
                case Algorithm.Genetic:
                    var parameters3 = ApplyConfiguration<GeneticAlgorithmConfiguration, GenericAlgorithmParameters>(new GeneticAlgorithmConfiguration());
                    if (parameters3 != null)
                        Calculation = new GeneticAlgorithm(parameters3.Value).Calculate;
                    break;
            }
        }

        private R? ApplyConfiguration<T, R>(T wnd)
            where T : Form, new() where R : struct
        {
            wnd.ShowDialog();

            var algorithmParameters = ((IParameters<R>)wnd).Parameters;

            if (algorithmParameters != null)
            {
                calculateBtn.Enabled = true;
            }

            return algorithmParameters;
        }
    }

    internal enum Algorithm
    {
        Ant,
        Genetic,
        Annealing
    }
}
