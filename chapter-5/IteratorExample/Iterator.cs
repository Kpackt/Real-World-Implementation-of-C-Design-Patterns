using System.Collections;

namespace IteratorExample;

public abstract class Iterator : IEnumerator
{
    object IEnumerator.Current => Current();
    public abstract int Key();
    public abstract bool MoveNext();
    public abstract void Reset();
    protected abstract object Current();
}