namespace UI.Algorithms.AntsAlgorithm
{
    public struct AntsAlgorithmParameters
    {
        public AntsAlgorithmParameters(double alpha, double beta, double q, double evaporationRate, int antsAmount, int iterations)
        {
            Alpha = alpha;
            Beta = beta;
            Q = q;
            EvaporationRate = evaporationRate;
            AntsAmount = antsAmount;
            Iterations = iterations;
        }

        public double Alpha { get; }
        public double Beta { get; }
        public double Q { get; }
        public double EvaporationRate { get; }
        public int AntsAmount { get; }
        public int Iterations { get; }
    }
}
