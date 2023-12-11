using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Algorithms
{
        public class AntColonyOptimizer
        {
            private int[,] distances;
            private double[,] pheromones;
            private List<Ant> ants;
            private int numberOfCities;

            public AntColonyOptimizer(int[,] _distances)
            {
                distances = _distances;
                numberOfCities = distances.GetLength(0);
                ants = new List<Ant>();
                pheromones = new double[numberOfCities, numberOfCities];
                InitializePheromones();
            }

            private void InitializePheromones()
            {
                for (int i = 0; i < numberOfCities; i++)
                {
                    for (int j = 0; j < numberOfCities; j++)
                    {
                        pheromones[i, j] = 1.0; 
                    }
                }
            }

            public void Optimize(int iterations, int numberOfAnts)
            {
                for (int i = 0; i < iterations; i++)
                {
                    InitializeAnts(numberOfAnts);
                    MoveAnts();
                    UpdatePheromones();
                }
            }

            private void InitializeAnts(int numberOfAnts)
            {
                ants.Clear();
                for (int i = 0; i < numberOfAnts; i++)
                {
                    ants.Add(new Ant());
                }
            }

            private void MoveAnts()
            {
                foreach (var ant in ants)
                {
                    int startCity = RandomCity();
                    ant.VisitedCities.Add(startCity);

                    for (int i = 0; i < numberOfCities - 1; i++)
                    {
                        int nextCity = SelectNextCity(ant);
                        ant.VisitedCities.Add(nextCity);
                        ant.TourLength += distances[ant.VisitedCities[i], nextCity];
                    }

                    // Повернення до початкового міста
                    ant.TourLength += distances[ant.VisitedCities[numberOfCities - 1], startCity];
                }
            }

        private int SelectNextCity(Ant ant)
        {
            int currentCity = ant.VisitedCities.Last();
            double[] probabilities = CalculateProbabilities(ant, currentCity);

            // Вибір наступного міста на основі обчислених ймовірностей
            // Це можна зробити, використовуючи метод рулетки або будь-який інший метод вибору
            return RouletteWheelSelection(probabilities);
        }

        private double[] CalculateProbabilities(Ant ant, int currentCity)
        {
            double[] probabilities = new double[numberOfCities];
            double sum = 0.0;

            for (int i = 0; i < numberOfCities; i++)
            {
                if (!ant.VisitedCities.Contains(i))
                {
                    double pheromone = Math.Pow(pheromones[currentCity, i], Alpha);
                    double inverseDistance = Math.Pow(1.0 / distances[currentCity, i], Beta);
                    probabilities[i] = pheromone * inverseDistance;
                    sum += probabilities[i];
                }
            }

            for (int i = 0; i < numberOfCities; i++)
            {
                probabilities[i] /= sum;
            }

            return probabilities;
        }

        private int RouletteWheelSelection(double[] probabilities)
        {
            double randomValue = new Random().NextDouble();
            double cumulativeProbability = 0.0;

            for (int i = 0; i < probabilities.Length; i++)
            {
                cumulativeProbability += probabilities[i];
                if (randomValue <= cumulativeProbability)
                {
                    return i;
                }
            }

            return probabilities.Length - 1; // Якщо випадкове значення не впало на жодну іншу категорію
        }

        private int RandomCity()
        {
            return new Random().Next(numberOfCities);
        }

        private void UpdatePheromones()
        {
            // Випаровування феромонів
            for (int i = 0; i < numberOfCities; i++)
            {
                for (int j = 0; j < numberOfCities; j++)
                {
                    pheromones[i, j] *= (1 - evaporationRate);
                }
            }

            // Додавання нових феромонів
            foreach (var ant in ants)
            {
                double contribution = Q / ant.TourLength;
                for (int i = 0; i < numberOfCities - 1; i++)
                {
                    int cityX = ant.VisitedCities[i];
                    int cityY = ant.VisitedCities[i + 1];
                    pheromones[cityX, cityY] += contribution;
                    pheromones[cityY, cityX] += contribution; // Якщо маршрут симетричний
                }

                // Додавання феромонів для повернення до початкового міста
                int startCity = ant.VisitedCities[0];
                int endCity = ant.VisitedCities[numberOfCities - 1];
                pheromones[endCity, startCity] += contribution;
                pheromones[startCity, endCity] += contribution; // Якщо маршрут симетричний
            }
        }

    }

    public class Ant
        {
            public List<int> VisitedCities { get; set; }
            public double TourLength { get; set; }

            public Ant()
            {
                VisitedCities = new List<int>();
                TourLength = 0.0;
            }

            // Методи для обходу міст і т.д.
        }
}
