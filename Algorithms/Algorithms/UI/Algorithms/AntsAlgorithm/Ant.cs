using System.Collections.Generic;

namespace UI.Algorithms.AntsAlgorithm
{
    public class Ant
    {
        public List<int> VisitedCities { get; set; }
        public double TourLength { get; set; }

        public Ant()
        {
            VisitedCities = new List<int>();
            TourLength = 0.0;
        }
    }
}
