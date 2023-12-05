using System;
using UserInterfase;

public class SimulatedAnnealing
{
    static int[,] distances = {
        { 0, 23, 16, 41, 29, 35 },
        { 23, 0, 40, 36, 24, 15 },
        { 16, 40, 0, 25, 45, 39 },
        { 41, 36, 25, 0, 38, 34 },
        { 29, 24, 45, 38, 0, 11 },
        { 35, 15, 39, 34, 11, 0 }
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

    static int[] SwapCities(int[] tour)
    {
        Random rand = new Random();
        int city1 = rand.Next(tour.Length);
        int city2 = rand.Next(tour.Length);
        int temp = tour[city1];
        tour[city1] = tour[city2];
        tour[city2] = temp;
        return tour;
    }

    internal static List<StaticticPoint> Calculate()
    {
        int[] currentTour = GenerateInitialTour();
        int currentDistance = CalculateTourLength(currentTour);

        List<StaticticPoint> statictics = new List<StaticticPoint>();

        double temperature = 10000.0;
        double coolingRate = 0.003;

        int iteration = 0;
        while (temperature > 1)
        {
            int[] newTour = SwapCities((int[])currentTour.Clone());
            int newDistance = CalculateTourLength(newTour);

            if (newDistance < currentDistance || Math.Exp((currentDistance - newDistance) / temperature) > new Random().NextDouble())
            {
                currentTour = newTour;
                currentDistance = newDistance;
            }

            statictics.Add(new StaticticPoint(iteration, currentDistance, temperature));

            temperature *= 1 - coolingRate;
            iteration++;
        }

        Console.WriteLine("Shortest Path Length: " + currentDistance);
        Console.WriteLine("Path: " + string.Join(" -> ", currentTour));
        
        return statictics;
    }
}
