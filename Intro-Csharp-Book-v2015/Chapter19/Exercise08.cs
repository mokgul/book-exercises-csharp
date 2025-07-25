namespace Chapter19;

public static class Exercise08
{
    public static void Priority()
    {
        var pq = new PriorityQueue<int>();
        pq.Enqueue(5);
        pq.Enqueue(3);
        pq.Enqueue(8);
        pq.Enqueue(1);

        while (pq.Count > 0)
        {
            Console.WriteLine(pq.Dequeue());  // Output: 1, 3, 5, 8
        }
    }
    
    public class PriorityQueue<T> where T : IComparable<T>
    {
        private List<T> heap;

        public PriorityQueue()
        {
            heap = new List<T>();
        }

        public int Count => heap.Count;

        public void Enqueue(T item)
        {
            heap.Add(item);
            HeapifyUp(heap.Count - 1);
        }

        public T Dequeue()
        {
            if (heap.Count == 0)
                throw new InvalidOperationException("PriorityQueue is empty.");

            T root = heap[0];
            heap[0] = heap[^1];
            heap.RemoveAt(heap.Count - 1);

            if (heap.Count > 0)
                HeapifyDown(0);

            return root;
        }

        public T Peek()
        {
            if (heap.Count == 0)
                throw new InvalidOperationException("PriorityQueue is empty.");
            return heap[0];
        }

        private void HeapifyUp(int index)
        {
            while (index > 0)
            {
                int parent = (index - 1) / 2;
                if (heap[index].CompareTo(heap[parent]) >= 0)
                    break;

                (heap[index], heap[parent]) = (heap[parent], heap[index]);
                index = parent;
            }
        }

        private void HeapifyDown(int index)
        {
            int lastIndex = heap.Count - 1;
            while (true)
            {
                int left = 2 * index + 1;
                int right = 2 * index + 2;
                int smallest = index;

                if (left <= lastIndex && heap[left].CompareTo(heap[smallest]) < 0)
                    smallest = left;
                if (right <= lastIndex && heap[right].CompareTo(heap[smallest]) < 0)
                    smallest = right;

                if (smallest == index)
                    break;

                (heap[index], heap[smallest]) = (heap[smallest], heap[index]);
                index = smallest;
            }
        }
    }
}