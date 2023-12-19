namespace UI.Algorithms.Annealing
{
    public struct AnnealingAlgorithmParameters
    {
        public AnnealingAlgorithmParameters(double temperature, double coolingRate)
        {
            Temperature = temperature;
            CoolingRate = coolingRate;
        }

        public double Temperature { get; }
        public double CoolingRate { get; }

    }
}
