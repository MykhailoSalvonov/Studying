using System.Collections.Generic;

namespace UI.Algorithms.AntsAlgorithm
{
    public class Pheromones
    {
        private double[,] pheromoneMatrix;
        private int numberOfCities;

        /// <summary>
        /// Evaporation Rate (Швидкість випаровування феромону):
        /// Цей параметр визначає, наскільки швидко феромони випаровуються з часом (оптимальні значення 0.1 - 0.5).
        /// </summary>
        private const double EvaporationRate = 0.3;

        /// <summary>
        /// Q (Константа феромону):
        ///Це константа, яка впливає на кількість феромону, залишеного мурахою (оптимальне значення ~ довжина маршруту).
        /// </summary>
        private const double Q = 100;

        public Pheromones(int numberOfCities, double initialPheromone)
        {
            this.numberOfCities = numberOfCities;
            pheromoneMatrix = new double[numberOfCities, numberOfCities];

            InitializePheromones(initialPheromone);
        }

        private void InitializePheromones(double initialPheromone)
        {
            for (int i = 0; i < numberOfCities; i++)
            {
                for (int j = 0; j < numberOfCities; j++)
                {
                    pheromoneMatrix[i, j] = initialPheromone;
                }
            }
        }

        public void EvaporatePheromones()
        {
            for (int i = 0; i < numberOfCities; i++)
            {
                for (int j = 0; j < numberOfCities; j++)
                {
                    pheromoneMatrix[i, j] *= (1 - EvaporationRate);
                }
            }
        }

        public void UpdatePheromone(int cityX, int cityY, double contribution)
        {
            pheromoneMatrix[cityX, cityY] += contribution;
        }

        public double GetPheromoneLevel(int cityX, int cityY)
        {
            return pheromoneMatrix[cityX, cityY];
        }

        public void UpdatePheromones(List<Ant> ants)
        {
            EvaporatePheromones();

            foreach (var ant in ants)
            {
                double contribution = Q / ant.TourLength;
                for (int i = 0; i < ant.VisitedCities.Count - 1; i++)
                {
                    int cityX = ant.VisitedCities[i];
                    int cityY = ant.VisitedCities[i + 1];
                    pheromoneMatrix[cityX, cityY] += contribution;
                }

                // Додавання феромонів для повернення до початкового міста
                int startCity = ant.VisitedCities[0];
                int endCity = ant.VisitedCities[ant.VisitedCities.Count - 1];
                pheromoneMatrix[endCity, startCity] += contribution;
            }
        }
    }
}
