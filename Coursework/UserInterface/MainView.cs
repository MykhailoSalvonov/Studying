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
                    //pictureBox1.Image = System.Drawing.Image.FromFile(filePath);
                    //pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;

                    //pictureBox1.Size = pictureBox1.Image.Size;
                    //Size = new Size(pictureBox1.Image.Width + 40, pictureBox1.Image.Height + 60);

                    filePath = UseFilter(filePath);
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private string UseFilter(string filePath)
        {
            string resultPath;
            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = "C:\\Users\\saliv\\anaconda3\\envs\\desctop_env\\python.exe";
            start.Arguments = $"\"D:\\Git\\Studying\\Coursework\\PythonScripts\\Filtering.py\" \"{filePath}\"";
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
    }
}
