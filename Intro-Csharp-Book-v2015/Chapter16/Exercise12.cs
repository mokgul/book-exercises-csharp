namespace Chapter16;

public static class Exercise12
{
    public class DynamicStack<T>
    {
        private class Node
        {
            public T Value;
            public Node? Next;

            public Node(T value)
            {
                Value = value;
            }
        }

        private Node? top;
        private int count;
        
        public int Count => count;
        public bool IsEmpty => top == null;

        public void Push(T value)
        {
            var node = new Node(value)
            {
                Next = top
            };
            top = node;
            count++;
        }

        public T Pop()
        {
            if(IsEmpty)
                throw new InvalidOperationException("Stack is empty");
            T result = top!.Value;
            top = top.Next;
            count--;
            return result;
        }

        public T Peek()
        {
            if(IsEmpty)
                throw new InvalidOperationException("Stack is empty");
            return top!.Value;
        }
        

        public T[] ToArray()
        {
            T[] result = new T[count];
            var current = top;
            int index = 0;
            while (current != null)
            {
                result[index++] = current.Value;
                current = current.Next;
            }
            return result;
        }
    }
}