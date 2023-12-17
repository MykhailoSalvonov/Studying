using System;
using System.Windows.Forms;
using UI.Algorithms;
using UI.Algorithms.AntsAlgorithm;
using UI.Algorithms.Genetic2;

namespace UI
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            int[,] distances = {
                { 0, 11, 17, 21, 32, 22 },
                { 11, 0, 24, 9, 35, 45 },
                { 17, 24, 0, 42, 19, 12 },
                { 21, 9, 42, 0, 8, 27 },
                { 32, 35, 19, 8, 0, 28 },
                { 22, 45, 12, 27, 28, 0 }
            };

            var t = AntAlgorithm.Calculate();
            var t2 = new GeneticAlgorithm(distances).Calculate();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainView());
        }
    }
}
