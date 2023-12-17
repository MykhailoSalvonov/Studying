using System.Collections.Generic;
using System.Linq;

namespace UI.Algorithms.AntsAlgorithm
{
    public class AntAlgorithm
    {
        private static int[,] distances = {
            { 0, 11, 17, 21, 32, 22 },
            { 11, 0, 24, 9, 35, 45 },
            { 17, 24, 0, 42, 19, 12 },
            { 21, 9, 42, 0, 8, 27 },
            { 32, 35, 19, 8, 0, 28 },
            { 22, 45, 12, 27, 28, 0 }
        };

        public static double Calculate()
        {
            List<StaticticPoint> statictics = new List<StaticticPoint>();
            
            int iterations = 50;
            int numberOfAnts = 20;

            AntColonyOptimizer antColonyOptimizer = new AntColonyOptimizer();
            antColonyOptimizer.Optimize(iterations, numberOfAnts, distances);
            var bestAnt = antColonyOptimizer.Ants.OrderBy(ant => ant.TourLength).FirstOrDefault();

            List<int> bestRoute = new List<int>(bestAnt.VisitedCities); ;
            double bestLength = bestAnt.TourLength;

            return bestLength;
        }
    }
}
