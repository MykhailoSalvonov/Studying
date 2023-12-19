namespace UI.Algorithms
{
    public interface IAlgorithm<T>
    {
        T Parameters { get; }
        int Calculate(int[,] distance);
    }
}
