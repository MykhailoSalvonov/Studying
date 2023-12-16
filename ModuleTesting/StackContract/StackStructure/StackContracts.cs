using System;
using System.Diagnostics.Contracts;

namespace StackContract
{
    [ContractClassFor(typeof(IStringStack))]
    abstract class StackContracts
    {
        public void Push(string item)
        {
            Contract.Requires(item != null);
        }

        public string Pop()
        {
            Contract.Requires(Count() > 0);
            Contract.Ensures(Contract.Result<string>() != null);

            return default(string);
        }

        public string Top()
        {
            Contract.Requires(Count() > 0);
            Contract.Ensures(Contract.Result<string>() != null);

            return default(string);
        }

        public int Count()
        {
            Contract.Ensures(Contract.Result<int>() >= 0);

            return default(int);
        }
    }
}
