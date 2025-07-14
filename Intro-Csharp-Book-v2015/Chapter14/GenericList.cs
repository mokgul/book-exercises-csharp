using System.Text;

namespace Chapter14;

public class GenericList<T>
{
    private T[] elements;
    private int count;

    public GenericList(int capacity)
    {
        if(capacity <= 0)
            throw new ArgumentException("Capacity must be greater than zero");
        elements = new T[capacity];
        count = 0;
    }
    
    public int Count => count;
    public int Capacity => elements.Length;
    
    private void Resize()
    {
        int newCapacity = elements.Length * 2;
        T[] newElements = new T[newCapacity];

        for (int i = 0; i < elements.Length; i++)
        {
            newElements[i] = elements[i];
        }

        elements = newElements;
    }

    public void Add(T element)
    {
        if(count >= elements.Length)
            Resize();
        elements[count++] = element;
    }

    public T this[int index]
    {
        get
        {
            if(index < 0 || index >= count)
                throw new IndexOutOfRangeException("Index is out of range");
            return elements[index];
        }
        set
        {
            if(index < 0 || index >= count)
                throw new IndexOutOfRangeException("Index is out of range");
            elements[index] = value;
        }
    }

    public void Remove(int index)
    {
        if(index < 0 || index >= count)
            throw new IndexOutOfRangeException("Index is out of range");

        for (int i = index; i < count - 1; i++)
        {
            elements[i] = elements[i + 1];
        }

        elements[count - 1] = default(T);
        count--;
    }

    public void Insert(int index, T element)
    {
        if(index < 0 || index >= count)
            throw new IndexOutOfRangeException("Index is out of range");
        
        if(count >= elements.Length)
            Resize();
        
        for (int i = count; i > index; i--)
        {
            elements[i] = elements[i - 1];
        }
        elements[index] = element;
        count++;
    }

    public void Clear()
    {
        for (int i = 0; i < count; i++)
        {
            elements[i] = default(T);
        }
        count = 0;
    }

    public int IndexOf(T value)
    {
        for (int i = 0; i < count; i++)
        {
            if(Equals(elements[i], value))
                return i;
        }
        return -1;
    }

    public override string ToString()
    {
        if (count == 0)
            return "[empty]";
        
        StringBuilder sb = new StringBuilder();
        sb.Append('[');
        for (int i = 0; i < count; i++)
        {
            sb.Append(elements[i]);
            if (i != count - 1)
                sb.Append(", ");
        }
        sb.Append(']');
        return sb.ToString();
    }
}