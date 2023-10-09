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
            int value = -1;
            int.TryParse(this.sizeA.Text, out value);
            int sizeA = value;

            int.TryParse(this.sizeB.Text, out value);
            int sizeB = value;

            int.TryParse(this.sizeC.Text, out value);
            int sizeC = value;

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

        private void sizeA_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPressValidation(sender, e);
        }

        private void sizeB_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPressValidation(sender, e);
        }

        private void sizeC_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyPressValidation(sender, e);
        }

        private void KeyPressValidation(object sender, KeyPressEventArgs e)
        {
            // Перевірка, чи введений символ є цифрою, Backspace або роздільником між числами (+, -)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-' && e.KeyChar != '+')
            {
                e.Handled = true; // Відхилення введення символу, який не є цифрою
            }

            // Перевірка на правильний формат числа зі знаком (можливість одного знаку плюс або мінус)
            if ((e.KeyChar == '-' || e.KeyChar == '+') && (sender as TextBox).Text.Contains("-"))
            {
                e.Handled = true; // Запрет вводу додаткового символу "-" або "+"
            }
            else if ((e.KeyChar == '-' || e.KeyChar == '+') && (sender as TextBox).SelectionStart != 0)
            {
                e.Handled = true; // Заборона вставки символів "+" або "-" у середину числа
            }
        }
    }
}