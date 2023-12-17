namespace UI.Algorithms
{
    public interface IAlgorithm<T>
    {
        T Parameters { get; }
        void Calculate(int[,] distance);
    }
}
