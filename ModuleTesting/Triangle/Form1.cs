using ModuleTesting;

namespace TriangleBuilder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sizeA = (int)numericUpDown1.Value;
            int sizeB = (int)numericUpDown2.Value;
            int sizeC = (int)numericUpDown3.Value;

            Triangle triangle = null;
            bool error = false;

            try
            {
                triangle = new Triangle(sizeA, sizeB, sizeC);
            }
            catch (Exception ex)
            {
                error = true;
                resultLabel.ForeColor = Color.Red;
                resultLabel.Text = ex.Message;
            }

            if (!error)
            {
                resultLabel.ForeColor = Color.Green;
                resultLabel.Text = $"Triangle has been created successful, it has type - {triangle?.Type}";
            }

        }

        /*
                 private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private Label resultLabel;
         */
    }
}