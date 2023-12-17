using System;
using System.Collections.Generic;
using System.Linq;
using UI.Algorithms.Annealing;
using UI.Algorithms.AntsAlgorithm;

namespace UI.Algorithms
{
    public class AntColonyOptimizer : IAlgorithm<AntsAlgorithmParameters>
    {
        public AntsAlgorithmParameters Parameters { get; private set; }

        public List<Ant> Ants { get; set; }

        public AntColonyOptimizer(AntsAlgorithmParameters parameters)
        {
            Parameters = parameters;
        }

        public void Calculate(int[,] distance)
        {
            Pheromones pheromones = new Pheromones(distance.GetLength(0), 1.0, Parameters.EvaporationRate, Parameters.Q);
            Random random = new Random();

            for (int i = 0; i < Parameters.Iterations; i++)
            {
                Ants = new List<Ant>();
                Ants = Enumerable.Range(0, Parameters.AntsAmount).Select(_ => new Ant(distance, pheromones, random, Parameters.Alpha, Parameters.Beta)).ToList();
                Ants.ForEach(ant => ant.Move());
                pheromones.UpdatePheromones(Ants);
            }

            var bestAnt = Ants.OrderBy(ant => ant.TourLength).FirstOrDefault();

            List<int> bestRoute = new List<int>(bestAnt.VisitedCities); ;
            double bestLength = bestAnt.TourLength;
        }
    }
}
