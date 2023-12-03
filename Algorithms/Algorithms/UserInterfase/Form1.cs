using System.Windows.Forms.DataVisualization;
namespace UserInterfase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var statictics = SimulatedAnnealing.Calculate();
        }
    }
}
