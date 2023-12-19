using System;
using System.Collections.Generic;
using System.Linq;

namespace UI.Algorithms
{
    public class GeneticAlg
    {
        private const int PopulationSize = 100;
        private const int GenomeSize = 8;
        private const int MaxGenerations = 100;
        private const double MutationRate = 0.01;
        private const double CrossoverRate = 0.7;
        private static Random random = new Random();

        public static string Calculate()
        {
            List<int> population = InitializePopulation(PopulationSize);
            int generation = 0;
            string result = "";

            while (generation < MaxGenerations)
            {
                List<int> newPopulation = new List<int>();
                List<double> fitnessScores = population.Select(x => FitnessFunction(x)).ToList();

                while (newPopulation.Count < PopulationSize)
                {
                    // Selection
                    int parent1 = RouletteWheelSelection(population, fitnessScores);
                    int parent2 = RouletteWheelSelection(population, fitnessScores);

                    // Crossover
                    (int child1, int child2) = Crossover(parent1, parent2);

                    // Mutation
                    child1 = Mutate(child1);
                    child2 = Mutate(child2);

                    newPopulation.Add(child1);
                    newPopulation.Add(child2);
                }

                population = newPopulation;
                generation++;

                int bestSolution = population.OrderByDescending(x => FitnessFunction(x)).First();
                result= $"Generation {generation}: Best Solution = {bestSolution}, Fitness = {FitnessFunction(bestSolution)}";
            }
            return result;
        }

        private static List<int> InitializePopulation(int size)
        {
            return Enumerable.Range(0, size).Select(x => random.Next(256)).ToList();
        }

        private static double FitnessFunction(int x)
        {
            if (x < 0 || x > 255) 
                throw new ArgumentOutOfRangeException(nameof(x));

            return Math.Pow((Math.Pow(x, 2) - 3 * x + 2), 2) / 256;
        }

        private static int RouletteWheelSelection(List<int> population, List<double> fitnessScores)
        {
            double totalFitness = fitnessScores.Sum();
            double randomPoint = random.NextDouble() * totalFitness;
            double currentSum = 0;

            for (int i = 0; i < population.Count; i++)
            {
                currentSum += fitnessScores[i];
                if (currentSum >= randomPoint)
                {
                    return population[i];
                }
            }

            return population.Last();
        }

        private static int CorrectGenomeRange(int genome)
        {
            return Math.Max(0, Math.Min(genome, 255));
        }

        private static (int, int) Crossover(int parent1, int parent2)
        {
            if (random.NextDouble() > CrossoverRate)
            {
                return (parent1, parent2);
            }

            int crossoverPoint = random.Next(1, GenomeSize - 1);
            int mask = (1 << crossoverPoint) - 1;
            int child1 = (parent1 & mask) | (parent2 & ~mask);
            int child2 = (parent2 & mask) | (parent1 & ~mask);

            return (CorrectGenomeRange(child1), CorrectGenomeRange(child2));
        }

        private static int Mutate(int genome)
        {
            for (int i = 0; i < GenomeSize; i++)
            {
                if (random.NextDouble() < MutationRate)
                {
                    genome ^= (1 << i);
                }
            }

            return CorrectGenomeRange(genome);
        }
    }
}
