using System;
using System.Collections.Generic;

namespace UI
{
    public class SimulatedAnnealing
    {
        static int[,] distances = {
        { 0, 11, 17, 21, 32, 22 },
        { 11, 0, 24, 9, 35, 45 },
        { 17, 24, 0, 42, 19, 12 },
        { 21, 9, 42, 0, 8, 27 },
        { 32, 35, 19, 8, 0, 28 },
        { 22, 45, 12, 27, 28, 0 }
    };

        static int CalculateTourLength(int[] tour)
        {
            int totalDistance = 0;
            for (int i = 0; i < tour.Length - 1; i++)
            {
                totalDistance += distances[tour[i], tour[i + 1]];
            }

            totalDistance += distances[tour[tour.Length - 1], tour[0]];
            return totalDistance;
        }

        static int[] GenerateInitialTour()
        {
            int[] tour = new int[distances.GetLength(0)];
            for (int i = 0; i < tour.Length; i++)
            {
                tour[i] = i;
            }
            return tour;
        }

        static int[] SwapCities(int[] tour, Random rand)
        {
            int city1 = rand.Next(tour.Length);
            int city2 = rand.Next(tour.Length);
            int temp = tour[city1];
            tour[city1] = tour[city2];
            tour[city2] = temp;
            return tour;
        }

        internal static List<StaticticPoint> Calculate()
        {
            Random random = new Random();
            int[] currentTour = GenerateInitialTour();
            int currentDistance = CalculateTourLength(currentTour);
            int listDist = currentDistance;
            List<StaticticPoint> statictics = new List<StaticticPoint>();

            double temperature = 100.0;
            double coolingRate = 0.003;

            int iteration = 0;
            while (temperature > 1)
            {
                int[] newTour = SwapCities((int[])currentTour.Clone(), random);
                int newDistance = CalculateTourLength(newTour);
                
                temperature *= 1 - coolingRate;
                iteration++;

                double randomDouble = random.NextDouble();
                if (newDistance < currentDistance || Math.Exp(-(newDistance- currentDistance) / temperature) > randomDouble)
                {
                    currentTour = newTour;
                    currentDistance = newDistance;

                    statictics.Add(new StaticticPoint(iteration, currentDistance, temperature));
                }
            }

            return statictics;
        }
    }
}

