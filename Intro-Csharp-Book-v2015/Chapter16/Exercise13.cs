namespace Chapter16;

public static class Exercise13
{
    public class StrictDeque<T>
    {
        private class Node
        {
            public T Value;
            public Node? Next;
            public Node? Prev;
            public bool IsLeftInsert;

            public Node(T value, bool isLeftInsert)
            {
                Value = value;
                IsLeftInsert = isLeftInsert;
            }
        }

        private Node? head;
        private Node? tail;
        public int Count { get; private set; }

        public void AddLeft(T value)
        {
            var node = new Node(value, true);
            if (head == null)
            {
                head = node;
            }
            else
            {
                node.Next = head;
                head.Prev =  node;
                head = node;
            }
            Count++;
        }

        public void AddRight(T value)
        {
            var node = new Node(value, false);
            if (tail == null)
            {
                tail = node;
            }
            else
            {
                node.Prev = tail;
                tail.Next = node;
                tail = node;
            }
            Count++;
        }

        public T RemoveLeft()
        {
            if (head == null)
                throw new InvalidOperationException("Deque is empty");
            
            if(!head.IsLeftInsert)
                throw new InvalidOperationException("Cannot remove element added from the right.");
            
            T result = head.Value;
            head = head.Next;
            if(head != null)
                head.Prev = null;
            else
                tail = null;
            Count--;
            return result;
        }
        
        public T RemoveRight()
        {
            if (tail == null)
                throw new InvalidOperationException("Deque is empty.");
            if (tail.IsLeftInsert)
                throw new InvalidOperationException("Cannot remove element added from the left.");

            T result = tail.Value;
            tail = tail.Prev;
            if (tail != null)
                tail.Next = null;
            else
                head = null;

            Count--;
            return result;
        }

        public void Clear()
        {
            head = tail = null;
            Count = 0;
        }
    }
}