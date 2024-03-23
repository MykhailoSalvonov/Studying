using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class MainView : Form
    {
        public string BaseImagePath { get; private set; }

        public string TempImagePath { get; private set; }

        

        public MainView()
        {
            InitializeComponent();
            filtersToolStripMenuItem.Enabled = false;
            combinedFiltersToolStripMenuItem.Enabled = false;
            subdivisionToolStripMenuItem.Enabled = false;
            filteringTypeToolStripMenuItem.Enabled = false;
        }

        public MainView(string path)
        {
            BaseImagePath = path;
            InitializeComponent();
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.Image = Image.FromFile(BaseImagePath);
            CreateTempImgCopy(path);

            filteringTypeToolStripMenuItem.Enabled = false;
        }

        private void CreateTempImgCopy(string path)
        {
            string tempFolderPath = Path.Combine(Directory.GetCurrentDirectory(), "temp");
            string newFileName = Regex.Replace(path, "_\\d{18}", "");
            
            newFileName = $"{Path.GetFileNameWithoutExtension(newFileName)}_{DateTime.Now.Ticks}{Path.GetExtension(newFileName)}";
            
            TempImagePath = Path.Combine(tempFolderPath, newFileName);

            if (!Directory.Exists(tempFolderPath))
                Directory.CreateDirectory(tempFolderPath);

            File.Copy(path, TempImagePath, true);
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

                    pictureBox1.Image = Image.FromFile(BaseImagePath);
                    pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;

                    pictureBox1.Size = pictureBox1.Image.Size;
                    Size = new Size(pictureBox1.Image.Width + 40, pictureBox1.Image.Height + 60);
                }
            }

            CreateTempImgCopy(BaseImagePath);

            filtersToolStripMenuItem.Enabled = true;
            combinedFiltersToolStripMenuItem.Enabled = true;
            subdivisionToolStripMenuItem.Enabled = true;
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filePath = "";
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "JPG Files (*.jpg)|*.jpg";
                saveFileDialog.RestoreDirectory = true;
                
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = saveFileDialog.FileName;
                }
            }

            string directoryPath = Path.GetDirectoryName(filePath);
            string fileExtension = Path.GetExtension(filePath);

            if (Directory.Exists(directoryPath))
            {
                File.Copy(BaseImagePath, filePath, true);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ModifyImage(FilterType filterType, string bSpline)
        {
            string result;
            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = Program.PythonPath;


            if(filterType == FilterType.Low || filterType == FilterType.High || filterType == FilterType.Contrast)
                start.Arguments = $"\"D:\\Git\\Studying\\Coursework\\PythonScripts\\SimpleFiltering.py\" \"{TempImagePath}\" \"{filterType}\" \"{bSpline}\"";
            else if(filterType == FilterType.Subdivision)
                start.Arguments = $"\"D:\\Git\\Studying\\Coursework\\PythonScripts\\SubdivisionFiltering.py\" \"{TempImagePath}\" \"{bSpline}\"";
            else if (filterType == FilterType.Combined)
                start.Arguments = $"\"D:\\Git\\Studying\\Coursework\\PythonScripts\\CombinedFiltering.py\" \"{TempImagePath}\" \"{bSpline}\"";
            start.UseShellExecute = false;
            start.RedirectStandardOutput = true;

            using (Process process = Process.Start(start))
            {
                using (StreamReader reader = process.StandardOutput)
                {
                    result = reader.ReadToEnd();
                }
            }
            if (result.Trim() != "1")
                
                throw new Exception();
        }

        private void x2ContrastFilterMenuItem_Click(object sender, EventArgs e) => ApplyChanges(FilterType.Contrast, FilterLevel.y2);
        private void x3ContrastFilterMenuItem_Click(object sender, EventArgs e) => ApplyChanges(FilterType.Contrast, FilterLevel.y3);
        private void x4ContrastFilterMenuItem_Click(object sender, EventArgs e) => ApplyChanges(FilterType.Contrast, FilterLevel.y4);
        private void x5ContrastFilterMenuItem_Click(object sender, EventArgs e) => ApplyChanges(FilterType.Contrast, FilterLevel.y5);
        private void x2LowFilterMenuItem_Click(object sender, EventArgs e) => ApplyChanges(FilterType.Low, FilterLevel.y2);
        private void x3LowFilterMenuItem_Click(object sender, EventArgs e) => ApplyChanges(FilterType.Low, FilterLevel.y3);
        private void x4LowFilterMenuItem_Click(object sender, EventArgs e) => ApplyChanges(FilterType.Low, FilterLevel.y4);
        private void x5LowFilterMenuItem_Click(object sender, EventArgs e) => ApplyChanges(FilterType.Low, FilterLevel.y5);
        private void x2HighFilterMenuItem_Click(object sender, EventArgs e) => ApplyChanges(FilterType.High, FilterLevel.y2);
        private void x3HighFilterMenuItem_Click(object sender, EventArgs e) => ApplyChanges(FilterType.High, FilterLevel.y3);
        private void x4HighFilterMenuItem_Click(object sender, EventArgs e) => ApplyChanges(FilterType.High, FilterLevel.y4);
        private void x5HighFilterMenuItem_Click(object sender, EventArgs e) => ApplyChanges(FilterType.High, FilterLevel.y5);
        private void x20SubdivisionMenuItem_Click(object sender, EventArgs e) => ApplyChanges(FilterType.Subdivision, SubdivisionLevel.y20);
        private void x21SubdivisionMenuItem_Click(object sender, EventArgs e) => ApplyChanges(FilterType.Subdivision, SubdivisionLevel.y21);
        private void x22SubdivisionMenuItem_Click(object sender, EventArgs e) => ApplyChanges(FilterType.Subdivision, SubdivisionLevel.y22);
        private void x30SubdivisionMenuItem_Click(object sender, EventArgs e) => ApplyChanges(FilterType.Subdivision, SubdivisionLevel.y30);
        private void x31SubdivisionMenuItem_Click(object sender, EventArgs e) => ApplyChanges(FilterType.Subdivision, SubdivisionLevel.y31);
        private void x40SubdivisionMenuItem11_Click(object sender, EventArgs e) => ApplyChanges(FilterType.Subdivision, SubdivisionLevel.y40);
        private void x41SubdivisionMenuItem_Click(object sender, EventArgs e) => ApplyChanges(FilterType.Subdivision, SubdivisionLevel.y41);
        private void h20S21L40CombinedFilterMenuItem_Click(object sender, EventArgs e) => ApplyChanges(FilterType.Combined, CombinedFilter.H20S21L40);

        private void ApplyChanges(FilterType type, FilterLevel level)
        {
            ModifyImage(type, level.ToString());
            
            var window = new MainView(TempImagePath);
            window.Show();
            CreateTempImgCopy(BaseImagePath);
        }

        private void ApplyChanges(FilterType type, CombinedFilter filter)
        {
            ModifyImage(type, filter.ToString());

            var window = new MainView(TempImagePath);
            window.Show();
            CreateTempImgCopy(BaseImagePath);
        }

        private void ApplyChanges(FilterType type, SubdivisionLevel filter)
        {
            ModifyImage(type, filter.ToString());

            var window = new MainView(TempImagePath);
            window.Show();
            CreateTempImgCopy(BaseImagePath);
        }


    }

    internal enum FilterType
    {
        Contrast,
        Low,
        High,
        Subdivision,
        Combined
    }

    internal enum FilterLevel
    {
        y2,
        y3,
        y4,
        y5
    }

    internal enum SubdivisionLevel
    {
        y20,
        y21,
        y22,
        y30,
        y31,
        y40,
        y41
    }

    internal enum CombinedFilter
    {
        H20S21L40
    }
}
