using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace UI
{
    public partial class ChartView : Form
    {
        public ChartView(Series series)
        {
            InitializeComponent(series);
        }
    }
}
