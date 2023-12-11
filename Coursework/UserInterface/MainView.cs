using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

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

        private string UseFilter(string filePath, FilterType filterType, string bSpline)
        {
            string resultPath;
            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = "C:\\Users\\Mykhailo\\anaconda3\\envs\\desktop_env\\python.exe";
            start.Arguments = $"\"D:\\Git\\Studying\\Coursework\\PythonScripts\\Filtering.py\" \"{filePath}\" \"{filterType}\" \"{bSpline}\"";
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

        private void x1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModifiedImagePath = UseFilter(ModifiedImagePath, FilterType.Contrast, "y1");
            pictureBox1.Image = System.Drawing.Image.FromFile(ModifiedImagePath);
        }

        private void x2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModifiedImagePath = UseFilter(ModifiedImagePath, FilterType.Contrast, "y2");
            pictureBox1.Image = System.Drawing.Image.FromFile(ModifiedImagePath);
        }

        private void x3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModifiedImagePath = UseFilter(ModifiedImagePath, FilterType.Contrast, "y3");
            pictureBox1.Image = System.Drawing.Image.FromFile(ModifiedImagePath);
        }

        private void x4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModifiedImagePath = UseFilter(ModifiedImagePath, FilterType.Contrast, "y4");
            pictureBox1.Image = System.Drawing.Image.FromFile(ModifiedImagePath);
        }

        private void x2ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ModifiedImagePath = UseFilter(ModifiedImagePath, FilterType.Low, "y2");
            pictureBox1.Image = System.Drawing.Image.FromFile(ModifiedImagePath);
        }

        private void x3ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ModifiedImagePath = UseFilter(ModifiedImagePath, FilterType.Low, "y3");
            pictureBox1.Image = System.Drawing.Image.FromFile(ModifiedImagePath);
        }
    }

    internal enum FilterType
    {
        Contrast,
        Low
    }
}
