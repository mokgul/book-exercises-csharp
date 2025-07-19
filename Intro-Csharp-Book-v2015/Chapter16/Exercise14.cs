namespace Chapter16;

public static class Exercise14
{
    public class CircularQueue<T>
    {
        private T[] items;
        private int head;
        private int tail;
        private int count;

        public CircularQueue(int capacity = 4)
        {
            items = new T[capacity];
            head = 0;
            tail = 0;
            count = 0;
        }
        
        public int Count => count;

        public void Enqueue(T item)
        {
            if (count == items.Length)
                Resize();
            
            items[tail] = item;
            tail = (tail + 1) % items.Length;
            count++;
        }
        
        public T Dequeue()
        {
            if (count == 0)
                throw new InvalidOperationException("Queue is empty.");

            T value = items[head];
            items[head] = default!;
            head = (head + 1) % items.Length;
            count--;
            return value;
        }

        public T Peek()
        {
            if (count == 0)
                throw new InvalidOperationException("Queue is empty.");

            return items[head];
        }

        public void Clear()
        {
            items = new T[4];
            head = 0;
            tail = 0;
            count = 0;
        }

        private void Resize()
        {
            int newCapacity = items.Length * 2;
            T[] newArray = new T[newCapacity];
            for (int i = 0; i < count; i++)
            {
                newArray[i] = items[(head + i) % items.Length];
            }

            items = newArray;
            head = 0;
            tail = count;
        }
    }
}