using System.Collections.Generic;
using System.Diagnostics.Contracts;

public class Stack<T>
{
    private List<T> elements = new List<T>();

    [ContractInvariantMethod]
    private void ObjectInvariant()
    {
        Contract.Invariant(elements != null);
    }

    public void Push(T item)
    {
        Contract.Requires(item != null);
        Contract.Ensures(elements.Count == Contract.OldValue(elements.Count) + 1);

        elements.Add(item);
    }

    public T Pop()
    {
        Contract.Requires(elements.Count > 0);
        Contract.Ensures(Contract.Result<T>() != null);
        Contract.Ensures(elements.Count == Contract.OldValue(elements.Count) - 1);

        T item = elements[elements.Count - 1];
        elements.RemoveAt(elements.Count - 1);
        return item;
    }

    public T Top()
    {
        Contract.Requires(elements.Count > 0);
        Contract.Ensures(Contract.Result<T>() != null);

        return elements[elements.Count - 1];
    }

    public int Count()
    {
        Contract.Ensures(Contract.Result<int>() >= 0);
        return elements.Count;
    }
}
