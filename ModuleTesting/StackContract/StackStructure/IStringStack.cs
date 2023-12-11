using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
