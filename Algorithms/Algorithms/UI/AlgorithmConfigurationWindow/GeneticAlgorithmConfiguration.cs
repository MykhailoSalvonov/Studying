using System;
using System.Windows.Forms;
using UI.AlgorithmConfigurationWindow;
using UI.Algorithms.Genetic2;

namespace UI
{
    public partial class GeneticAlgorithmConfiguration : Form, IParameters<GenericAlgorithmParameters>
    {
        public GenericAlgorithmParameters? Parameters { get; private set; }

        public GeneticAlgorithmConfiguration()
        {
            InitializeComponent();
        }

        private void applyBtn_Click(object sender, EventArgs e)
        {
            Parameters = new GenericAlgorithmParameters(
                populationSize: int.Parse(populationSizeValue.Text),
                generations: int.Parse(generationsValue.Text),
                mutationRate: double.Parse(mutationRateValue.Text)
            );
            Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
