using System;
using System.Collections.Generic;
using System.Linq;

namespace UI.Algorithms.Genetic2
{
    public class GeneticAlgorithm
    {
        private const int PopulationSize = 100;
        private const int Generations = 100;
        private const double MutationRate = 0.01;
        private static readonly Random random = new Random();
        private int[,] distances;

        public GeneticAlgorithm(int[,] distances)
        {
            this.distances = distances;
        }

        public int Calculate()
        {
            // Ініціалізація популяції
            List<int[]> population = InitializePopulation(PopulationSize);

            for (int generation = 0; generation < Generations; generation++)
            {
                // Вибір і кросовер
                List<int[]> newPopulation = new List<int[]>();
                while (newPopulation.Count < PopulationSize)
                {
                    int[] parent1 = Select(population);
                    int[] parent2 = Select(population);
                    int[] child = Crossover(parent1, parent2);
                    newPopulation.Add(child);
                }

                // Мутація
                population = newPopulation.Select(Mutate).ToList();
            }

            // Пошук найкоротшого маршруту
            return GetRouteLength(population.OrderBy(GetRouteLength).First());
        }

        private List<int[]> InitializePopulation(int size)
        {
            List<int[]> population = new List<int[]>();
            for (int i = 0; i < size; i++)
            {
                int[] route = Enumerable.Range(0, distances.GetLength(0)).ToArray();
                Shuffle(route);
                population.Add(route);
            }
            return population;
        }

        private int GetRouteLength(int[] route)
        {
            int length = 0;
            for (int i = 0; i < route.Length - 1; i++)
            {
                length += distances[route[i], route[i + 1]];
            }
            // Повернення до початкового міста
            length += distances[route[route.Length - 1], route[0]];
            return length;
        }

        private int[] Select(List<int[]> population)
        {
            int tournamentSize = 5;
            List<int[]> tournamentParticipants = new List<int[]>();

            // Вибрати випадкові маршрути для турніру
            for (int i = 0; i < tournamentSize; i++)
            {
                int randomIndex = random.Next(population.Count);
                tournamentParticipants.Add(population[randomIndex]);
            }

            // Повернути маршрут з найменшою довжиною
            return tournamentParticipants.OrderBy(GetRouteLength).First();
        }

        private int[] Crossover(int[] parent1, int[] parent2)
        {
            int[] child = new int[parent1.Length];
            int start = random.Next(0, parent1.Length);
            int end = random.Next(start, parent1.Length);

            // Копіювання частини з першого батька
            for (int i = start; i < end; i++)
            {
                child[i] = parent1[i];
            }

            // Заповнення решти з другого батька
            foreach (int city in parent2)
            {
                if (!child.Contains(city))
                {
                    for (int i = 0; i < child.Length; i++)
                    {
                        if (i >= start && i < end) continue;
                        if (child[i] == 0)
                        {
                            child[i] = city;
                            break;
                        }
                    }
                }
            }

            return child;
        }

        private int[] Mutate(int[] route)
        {
            int[] mutatedRoute = (int[])route.Clone();

            if (random.NextDouble() < MutationRate)
            {
                int index1 = random.Next(route.Length);
                int index2 = random.Next(route.Length);

                // Обмін двох міст
                (mutatedRoute[index1], mutatedRoute[index2]) = (mutatedRoute[index2], mutatedRoute[index1]);
            }

            return mutatedRoute;
        }

        private void Shuffle(int[] array)
        {
            for (int i = array.Length - 1; i > 0; i--)
            {
                int j = random.Next(i + 1);
                (array[j], array[i]) = (array[i], array[j]);
            }
        }
    }

}
