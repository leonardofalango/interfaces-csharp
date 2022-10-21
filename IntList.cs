using System.Collections;

public class IntList : IEnumerable
{
    private int[] values = new int[10];
    private int count = 0;

    public int this[int index]
    {
        get 
        {
            if (index < 0 || index >= count)
                throw new IndexOutOfRangeException();
            return values[index];
        }
        set
        {
            if (index < 0 || index >= count)
                throw new IndexOutOfRangeException();
            values[index] = value;
        }
    }

    public int Count => count;

    public void Add(int num)
    {
        if (count == values.Length)
        {
            int[] newValues = new int[2 * values.Length];
            for (int i = 0; i < values.Length; i++)
                newValues[i] = values[i];
            this.values = newValues;
        }

        values [count] = num;
        count++;
    }

    public IEnumerator GetEnumerator()
    {
        IntListIterator enumerator = new IntListIterator(this);
        return enumerator;
    }
}

public class IntListIterator : IEnumerator
{
    private IntList list;
    int index = -1;
    public IntListIterator(IntList list)
    {
        this.list = list;
    }
    public object Current => list[index];

    public bool MoveNext()
    {
        index++;
        return index < list.Count;
    }

    public void Reset() => index = -1;
}