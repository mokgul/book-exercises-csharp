namespace Chapter19;

public static class Exercise02
{
    public class MinHeap
    {
        private List<int> heap = new List<int>();

        public void Add(int element)
        {
            heap.Add(element);
            HeapifyUp(heap.Count - 1);
        }

        public int ExtractMin()
        {
            if (heap.Count == 0) throw new InvalidOperationException("Heap is empty.");

            int min = heap[0];
            heap[0] = heap[^1];
            heap.RemoveAt(heap.Count - 1);
            HeapifyDown(0);
            return min;
        }

        public int PeekMin()
        {
            if (heap.Count == 0) throw new InvalidOperationException("Heap is empty.");
            return heap[0];
        }

        private void HeapifyUp(int index)
        {
            while (index > 0)
            {
                int parent = (index - 1) / 2;
                if (heap[index] >= heap[parent]) break;

                (heap[index], heap[parent]) = (heap[parent], heap[index]);
                index = parent;
            }
        }

        private void HeapifyDown(int index)
        {
            int left, right, smallest;
            while ((left = 2 * index + 1) < heap.Count)
            {
                right = left + 1;
                smallest = left;

                if (right < heap.Count && heap[right] < heap[left])
                    smallest = right;

                if (heap[index] <= heap[smallest]) break;

                (heap[index], heap[smallest]) = (heap[smallest], heap[index]);
                index = smallest;
            }
        }

        public int Count => heap.Count;
    }
}