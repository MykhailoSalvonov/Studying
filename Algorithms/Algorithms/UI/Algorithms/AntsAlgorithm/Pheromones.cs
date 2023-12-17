using System.Collections.Generic;

namespace UI.Algorithms.AntsAlgorithm
{
    public class Pheromones
    {
        private double[,] _pheromoneMatrix;
        private int _numberOfCities;

        /// <summary>
        /// Evaporation Rate (Швидкість випаровування феромону):
        /// Цей параметр визначає, наскільки швидко феромони випаровуються з часом (оптимальні значення 0.1 - 0.5).
        /// </summary>
        private double EvaporationRate {  get; }

        /// <summary>
        /// Q (Константа феромону):
        ///Це константа, яка впливає на кількість феромону, залишеного мурахою (оптимальне значення ~ довжина маршруту).
        /// </summary>
        private double Q { get; }
        
        public Pheromones(int numberOfCities, double initialPheromone, double evaporationRate, double q)
        {
            _numberOfCities = numberOfCities;
            _pheromoneMatrix = new double[numberOfCities, numberOfCities];

            Q = q;
            EvaporationRate = evaporationRate;

            InitializePheromones(initialPheromone);
        }

        private void InitializePheromones(double initialPheromone)
        {
            for (int i = 0; i < _numberOfCities; i++)
            {
                for (int j = 0; j < _numberOfCities; j++)
                {
                    _pheromoneMatrix[i, j] = initialPheromone;
                }
            }
        }

        public void EvaporatePheromones()
        {
            for (int i = 0; i < _numberOfCities; i++)
            {
                for (int j = 0; j < _numberOfCities; j++)
                {
                    _pheromoneMatrix[i, j] *= (1 - EvaporationRate);
                }
            }
        }

        public void UpdatePheromone(int cityX, int cityY, double contribution)
        {
            _pheromoneMatrix[cityX, cityY] += contribution;
        }

        public double GetPheromoneLevel(int cityX, int cityY)
        {
            return _pheromoneMatrix[cityX, cityY];
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
                    _pheromoneMatrix[cityX, cityY] += contribution;
                }

                // Додавання феромонів для повернення до початкового міста
                int startCity = ant.VisitedCities[0];
                int endCity = ant.VisitedCities[ant.VisitedCities.Count - 1];
                _pheromoneMatrix[endCity, startCity] += contribution;
            }
        }
    }
}
