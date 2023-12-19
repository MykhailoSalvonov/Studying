using System;
using System.Collections.Generic;
using System.Linq;

namespace UI.Algorithms.AntsAlgorithm
{
    public class Ant
    {
        /// <summary>
        /// Alpha - Важливість феромону:
        /// Цей параметр контролює, наскільки важливим є феромонний слід при виборі шляху мурахами (оптимальні значення 1 - 3).
        /// </summary>
        private double Alpha { get; }

        /// <summary>
        /// Beta - Важливість відстані:
        ///Цей параметр визначає, наскільки важлива інформація про відстань між містами (оптимальні значення 2 - 5).
        /// </summary>
        private double Beta { get; }

        public List<int> VisitedCities { get; set; }
        public double TourLength { get; set; }
        private Pheromones Pheromones { get; }
        private int NumberOfCities { get; }
        private int[,] Distances { get; }
        private Random Random { get; }


        public Ant(int[,] distances, Pheromones pheromones, Random random, double alpha, double beta)
        {
            VisitedCities = new List<int>();
            TourLength = 0.0;

            Alpha = alpha;
            Beta = beta;

            Pheromones = pheromones;
            NumberOfCities = distances.GetLength(0);
            Distances = distances;
            Random = random;
        }

        public void Move()
        {
            int startCity = Random.Next(NumberOfCities);
            VisitedCities.Add(startCity);

            for (int i = 0; i < NumberOfCities - 1; i++)
            {
                int nextCity = SelectNextCity();
                VisitedCities.Add(nextCity);
                TourLength += Distances[VisitedCities[i], nextCity];
            }

            // Повернення до початкового міста
            TourLength += Distances[VisitedCities[NumberOfCities - 1], startCity];
        }

        #region Private Methods

        private int SelectNextCity()
        {
            int currentCity = VisitedCities.Last();
            double[] probabilities = CalculateProbabilities(currentCity);

            // Вибір наступного міста на основі обчислених ймовірностей
            return RouletteWheelSelection(probabilities);
        }

        private double[] CalculateProbabilities(int currentCity)
        {
            double[] probabilities = new double[NumberOfCities];
            double sum = 0.0;

            for (int i = 0; i < NumberOfCities; i++)
            {
                if (!VisitedCities.Contains(i))
                {
                    double pheromoneLevel = Pheromones.GetPheromoneLevel(currentCity, i);
                    double pheromone = Math.Pow(pheromoneLevel, Alpha);

                    double inverseDistance = Distances[currentCity, i] == 0 ? 0 : Math.Pow(1.0 / Distances[currentCity, i], Beta);
                    probabilities[i] = pheromone * inverseDistance;
                    sum += probabilities[i];
                }
            }

            for (int i = 0; i < NumberOfCities; i++)
            {
                probabilities[i] = sum == 0 ? 0 : probabilities[i] / sum;
            }

            return probabilities;
        }

        private int RouletteWheelSelection(double[] probabilities)
        {
            double randomValue = Random.NextDouble();
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

        #endregion
    }
}
