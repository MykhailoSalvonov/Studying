namespace UI.Algorithms.Genetic2
{
    public struct GenericAlgorithmParameters
    {
        public GenericAlgorithmParameters(int populationSize, int generations, double mutationRate) 
        {
            PopulationSize = populationSize;
            Generations = generations;
            MutationRate = mutationRate;
        }

        public int PopulationSize { get; }
        public int Generations { get; }
        public double MutationRate { get; }
    }
}
