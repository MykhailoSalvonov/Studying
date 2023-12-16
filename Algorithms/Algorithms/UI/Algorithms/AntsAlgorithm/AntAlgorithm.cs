using System;
using System.Collections.Generic;
using System.Linq;
using UI.Algorithms.AntsAlgorithm;

namespace UI.Algorithms
{
    public class AntColonyOptimizer
    {
        private int[,] distances = {
            { 0, 11, 17, 21, 32, 22 },
            { 11, 0, 24, 9, 35, 45 },
            { 17, 24, 0, 42, 19, 12 },
            { 21, 9, 42, 0, 8, 27 },
            { 32, 35, 19, 8, 0, 28 },
            { 22, 45, 12, 27, 28, 0 }
        };

        private List<Ant> Ants { get; set; }
        private double[,] PheromonesBetweenCities { get; }

        private int NumberOfCities => distances.Length;


        private Random Random;

        /// <summary>
        /// Evaporation Rate (Швидкість випаровування феромону):
        /// Цей параметр визначає, наскільки швидко феромони випаровуються з часом (оптимальні значення 0.1 - 0.5).
        /// </summary>
        private const double EvaporationRate = 0.3;

        /// <summary>
        /// Alpha - Важливість феромону:
        /// Цей параметр контролює, наскільки важливим є феромонний слід при виборі шляху мурахами (оптимальні значення 1 - 3).
        /// </summary>
        private const double Alpha = 1.5;

        /// <summary>
        /// Beta - Важливість відстані:
        ///Цей параметр визначає, наскільки важлива інформація про відстань між містами (оптимальні значення 2 - 5).
        /// </summary>
        private const double Beta = 3.5;

        /// <summary>
        /// Q (Константа феромону):
        ///Це константа, яка впливає на кількість феромону, залишеного мурахою (оптимальне значення ~ довжина маршруту).
        /// </summary>
        private const double Q = 100;

        public AntColonyOptimizer()
        {
            Random = new Random();  
            Ants = new List<Ant>();
            PheromonesBetweenCities = new double[NumberOfCities, NumberOfCities];
            InitializePheromones();
        }

        private void InitializePheromones()
        {
            for (int i = 0; i < NumberOfCities; i++)
            {
                for (int j = 0; j < NumberOfCities; j++)
                {
                    PheromonesBetweenCities[i, j] = 1.0; 
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
            Ants.Clear();
            for (int i = 0; i < numberOfAnts; i++)
            {
                Ants.Add(new Ant());
            }
        }

        private void MoveAnts()
        {
            foreach (var ant in Ants)
            {
                int startCity = RandomCity();
                ant.VisitedCities.Add(startCity);

                for (int i = 0; i < NumberOfCities - 1; i++)
                {
                    int nextCity = SelectNextCity(ant);
                    ant.VisitedCities.Add(nextCity);
                    ant.TourLength += distances[ant.VisitedCities[i], nextCity];
                }

                // Повернення до початкового міста
                ant.TourLength += distances[ant.VisitedCities[NumberOfCities - 1], startCity];
            }
        }

        private int SelectNextCity(Ant ant)
        {
            int currentCity = ant.VisitedCities.Last();
            double[] probabilities = CalculateProbabilities(ant, currentCity);

            // Вибір наступного міста на основі обчислених ймовірностей
            return RouletteWheelSelection(probabilities);
        }

        private double[] CalculateProbabilities(Ant ant, int currentCity)
        {
            double[] probabilities = new double[NumberOfCities];
            double sum = 0.0;

            for (int i = 0; i < NumberOfCities; i++)
            {
                if (!ant.VisitedCities.Contains(i))
                {
                    double pheromone = Math.Pow(PheromonesBetweenCities[currentCity, i], Alpha);
                    double inverseDistance = distances[currentCity, i]==0 ? 0 : Math.Pow(1.0 / distances[currentCity, i], Beta);
                    probabilities[i] = pheromone * inverseDistance;
                    sum += probabilities[i];
                }
            }

            for (int i = 0; i < NumberOfCities; i++)
            {
                probabilities[i] /= sum;
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

        private int RandomCity()
        {
            return Random.Next(NumberOfCities);
        }

        private void UpdatePheromones()
        {
            // Випаровування феромонів
            for (int i = 0; i < NumberOfCities; i++)
            {
                for (int j = 0; j < NumberOfCities; j++)
                {
                    PheromonesBetweenCities[i, j] *= (1 - EvaporationRate);
                }
            }

            // Додавання нових феромонів
            foreach (var ant in Ants)
            {
                double contribution = Q / ant.TourLength;
                for (int i = 0; i < ant.VisitedCities.Count - 1; i++)
                {
                    int cityX = ant.VisitedCities[i];
                    int cityY = ant.VisitedCities[i + 1];
                    PheromonesBetweenCities[cityX, cityY] += contribution;
                }

                // Додавання феромонів для повернення до початкового міста
                int startCity = ant.VisitedCities[0];
                int endCity = ant.VisitedCities[ant.VisitedCities.Count - 1];
                PheromonesBetweenCities[endCity, startCity] += contribution;
            }
        }

        public static double Calculate()
        {
            List<StaticticPoint> statictics = new List<StaticticPoint>();
            int iterations = 50; // Можна встановити відповідно до ваших потреб
            int numberOfAnts = 20; // Можна встановити відповідно до ваших потреб
            AntColonyOptimizer antColonyOptimizer = new AntColonyOptimizer();
            antColonyOptimizer.Optimize(iterations, numberOfAnts);

            double bestLength = double.MaxValue;
            List<int> bestRoute = null;

            foreach (var ant in antColonyOptimizer.Ants)
            {
                if (ant.TourLength < bestLength)
                {
                    bestLength = ant.TourLength;
                    bestRoute = new List<int>(ant.VisitedCities);
                }
            }

            return bestLength;
        }
    }
}
