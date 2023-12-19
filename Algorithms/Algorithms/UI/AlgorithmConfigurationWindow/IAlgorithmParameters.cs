namespace UI.AlgorithmConfigurationWindow
{
    public interface IParameters<T> where T : struct
    {
        T? Parameters { get; }
    }
}
