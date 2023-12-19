using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class MainView : Form
    {
        public string BaseImagePath { get; set; }
        public string ModifiedImagePath { get; set; }

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
                    BaseImagePath = openFileDialog.FileName;
                    ModifiedImagePath = openFileDialog.FileName;
                    pictureBox1.Image = System.Drawing.Image.FromFile(BaseImagePath);
                    pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;

                    pictureBox1.Size = pictureBox1.Image.Size;
                    Size = new Size(pictureBox1.Image.Width + 40, pictureBox1.Image.Height + 60);
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private string UseFilter(string filePath, FilterType filterType, FilterLevel bSpline)
        {
            string resultPath;
            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = "C:\\Users\\mykhailo\\anaconda3\\envs\\desktop_env\\python.exe";
            start.Arguments = $"\"D:\\Git\\Studying\\Coursework\\PythonScripts\\ConvolutionFiltering.py\" \"{filePath}\" \"{filterType}\" \"{bSpline}\"";
            start.UseShellExecute = false;
            start.RedirectStandardOutput = true;

            using (Process process = Process.Start(start))
            {
                using (StreamReader reader = process.StandardOutput)
                {
                    resultPath = reader.ReadToEnd();
                }
            }

            return resultPath;
        }

        private void x2ContrastFilterMenuItem_Click(object sender, EventArgs e) => ApplyFilter(FilterType.Contrast, FilterLevel.y2);
        private void x3ContrastFilterMenuItem_Click(object sender, EventArgs e) => ApplyFilter(FilterType.Contrast, FilterLevel.y3);
        private void x4ContrastFilterMenuItem_Click(object sender, EventArgs e) => ApplyFilter(FilterType.Contrast, FilterLevel.y4);
        private void x5ContrastFilterMenuItem_Click(object sender, EventArgs e) => ApplyFilter(FilterType.Contrast, FilterLevel.y5);
        private void x2LowFilterMenuItem_Click(object sender, EventArgs e) => ApplyFilter(FilterType.Low, FilterLevel.y2);
        private void x3LowFilterMenuItem_Click(object sender, EventArgs e) => ApplyFilter(FilterType.Low, FilterLevel.y3);
        private void x4LowFilterMenuItem_Click(object sender, EventArgs e) => ApplyFilter(FilterType.Low, FilterLevel.y4);
        private void x5LowFilterMenuItem_Click(object sender, EventArgs e) => ApplyFilter(FilterType.Low, FilterLevel.y5);
        private void x2HighFilterMenuItem_Click(object sender, EventArgs e) => ApplyFilter(FilterType.High, FilterLevel.y2);
        private void x3HighFilterMenuItem_Click(object sender, EventArgs e) => ApplyFilter(FilterType.High, FilterLevel.y3);
        private void x4HighFilterMenuItem_Click(object sender, EventArgs e) => ApplyFilter(FilterType.High, FilterLevel.y4);
        private void x5HighFilterMenuItem_Click(object sender, EventArgs e) => ApplyFilter(FilterType.High, FilterLevel.y5);

        private void ApplyFilter(FilterType type, FilterLevel filter)
        {
            ModifiedImagePath = UseFilter(ModifiedImagePath, FilterType.High, filter);
            pictureBox1.Image = System.Drawing.Image.FromFile(ModifiedImagePath);
        }

        
    }

    internal enum FilterType
    {
        Contrast,
        Low,
        High
    }

    internal enum FilterLevel
    {
        y2,
        y3,
        y4,
        y5
    }
}
