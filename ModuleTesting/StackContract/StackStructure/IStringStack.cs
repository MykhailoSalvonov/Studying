using System.Diagnostics.Contracts;

namespace StackContract
{
    [ContractClass(typeof(StackContracts))]
    public interface IStringStack
    {
        void Push(string item);

        string Pop();

        string Top();

        int Count();
    }
}
