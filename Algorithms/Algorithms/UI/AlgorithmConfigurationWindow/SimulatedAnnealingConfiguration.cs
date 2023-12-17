using System;
using System.Windows.Forms;
using UI.Algorithms.Annealing;

namespace UI.AlgorithmConfigurationWindow
{
    public partial class SimulatedAnnealingConfiguration : Form, IParameters<AnnealingAlgorithmParameters>
    {
        public AnnealingAlgorithmParameters? Parameters { get; private set; }

        public SimulatedAnnealingConfiguration()
        {
            InitializeComponent();
        }

        private void applyBtn_Click(object sender, EventArgs e)
        {
            Parameters = new AnnealingAlgorithmParameters(
                temperature: double.Parse(temperatureValue.Text),
                coolingRate: double.Parse(coolingRateValue.Text)
            );
            Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
