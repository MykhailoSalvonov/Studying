using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace UserInterface
{
    public partial class MainView : Form
    {
        public byte[,,] Data { get; set; }

        public MainView()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "JPG Files (*.jpg)|*.jpg";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    pictureBox1.Image = System.Drawing.Image.FromFile(filePath);
                    pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;

                    pictureBox1.Size = pictureBox1.Image.Size;

                    // Встановити розмір форми. Додати маржини для рамок вікна та заголовка.
                    this.Size = new Size(pictureBox1.Image.Width + 40, pictureBox1.Image.Height + 60);

                    Data = BSplineCore.ImageConvertor.ConvertImageTo3DArray(filePath);
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
