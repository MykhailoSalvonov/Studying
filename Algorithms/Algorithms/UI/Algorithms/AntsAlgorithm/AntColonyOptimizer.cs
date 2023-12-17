using System;
using System.Collections.Generic;
using System.Linq;
using UI.Algorithms.AntsAlgorithm;

namespace UI.Algorithms
{
    public class AntColonyOptimizer
    {
        public List<Ant> Ants { get; set; }

        public void Optimize(int iterations, int numberOfAnts, int[,] distances)
        {
            Pheromones pheromones = new Pheromones(distances.GetLength(0), 1.0);
            Random random = new Random();

            for (int i = 0; i < iterations; i++)
            {
                Ants = new List<Ant>();
                Ants = Enumerable.Range(0, numberOfAnts).Select(_ => new Ant(distances, pheromones, random)).ToList();
                Ants.ForEach(ant => ant.Move());
                pheromones.UpdatePheromones(Ants);
            }
        }
    }
}
