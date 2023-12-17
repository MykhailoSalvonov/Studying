using System;
using System.Windows.Forms;
using UI.AlgorithmConfigurationWindow;
using UI.Algorithms.AntsAlgorithm;

namespace UI
{
    public partial class AntAlgorithmConfiguration : Form, IParameters<AntsAlgorithmParameters>
    {
        public AntsAlgorithmParameters? Parameters { get; private set; }

        public AntAlgorithmConfiguration()
        {
            InitializeComponent();
        }

        private void applyBtn_Click(object sender, EventArgs e)
        {
            Parameters = new AntsAlgorithmParameters(
                alpha: double.Parse(alphaValue.Text),
                beta: double.Parse(betaValue.Text),
                q: double.Parse(qValue.Text),
                evaporationRate: double.Parse(evaporationRateValue.Text),
                antsAmount: int.Parse(antsAmountValue.Text),
                iterations: int.Parse(iterationsValue.Text)
            );
            Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
