using System;

namespace UI.Algorithms.Annealing
{
    public class SimulatedAnnealing : IAlgorithm<AnnealingAlgorithmParameters>
    {
        int[,] Distances { get; set; }
        Random Random {  get; }

        public AnnealingAlgorithmParameters Parameters { get; private set; }

        public SimulatedAnnealing(AnnealingAlgorithmParameters parameters) 
        {
            Parameters = parameters;
            Random = new Random();
        }

        private int CalculateTourLength(int[] tour)
        {
            int totalDistance = 0;
            for (int i = 0; i < tour.Length - 1; i++)
            {
                totalDistance += Distances[tour[i], tour[i + 1]];
            }

            totalDistance += Distances[tour[tour.Length - 1], tour[0]];
            return totalDistance;
        }

        private int[] GenerateInitialTour()
        {
            int[] tour = new int[Distances.GetLength(0)];
            for (int i = 0; i < tour.Length; i++)
            {
                tour[i] = i;
            }
            return tour;
        }

        private int[] SwapCities(int[] tour, Random rand)
        {
            int city1 = rand.Next(tour.Length);
            int city2 = rand.Next(tour.Length);
            int temp = tour[city1];
            tour[city1] = tour[city2];
            tour[city2] = temp;
            return tour;
        }

        public int Calculate(int[,] distance)
        {
            Distances = distance;
            int[] currentTour = GenerateInitialTour();
            int currentDistance = CalculateTourLength(currentTour);

            double temperature = Parameters.Temperature;
            double coolingRate = Parameters.CoolingRate;

            int iteration = 0;
            while (temperature > 1)
            {
                int[] newTour = SwapCities((int[])currentTour.Clone(), Random);
                int newDistance = CalculateTourLength(newTour);
                
                double randomDouble = Random.NextDouble();
                if (newDistance < currentDistance && Math.Exp(-(newDistance - currentDistance) / temperature) > randomDouble)
                {
                    currentTour = newTour;
                    currentDistance = newDistance;
                }

                temperature *= 1 - coolingRate;
                iteration++;
            }

            return currentDistance;
        }
    }
}

