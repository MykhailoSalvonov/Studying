using StackContract;
using System.Collections.Generic;
using System.Diagnostics.Contracts;


public class StringStack : IStringStack
{
    private List<string> elements = new List<string>();

    [ContractInvariantMethod]
    private void ObjectInvariant()
    {
        Contract.Invariant(elements != null);
    }

    public void Push(string item)
    {
        Contract.Requires(item != null);
        Contract.Ensures(elements.Count == Contract.OldValue(elements.Count) + 1);

        elements.Add(item);
    }

    public string Pop()
    {
        Contract.Requires(elements.Count > 0);
        Contract.Ensures(Contract.Result<string>() != null);
        Contract.Ensures(elements.Count == Contract.OldValue(elements.Count) - 1);

        string item = elements[elements.Count - 1];
        elements.RemoveAt(elements.Count - 1);
        return item;
    }

    public string Top()
    {
        Contract.Requires(elements.Count > 0);
        Contract.Ensures(Contract.Result<string>() != null);

        return elements[elements.Count - 1];
    }

    public int Count()
    {
        Contract.Ensures(Contract.Result<int>() >= 0);
        return elements.Count;
    }
}
