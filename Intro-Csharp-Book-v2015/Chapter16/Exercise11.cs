namespace Chapter16;

public static class Exercise11
{
    public class DoublyLinkedList<T>
    {
        private class Node
        {
            public T Value;
            public Node? Prev;
            public Node? Next;

            public Node(T value)
            {
                Value = value;
            }
        }

        private Node? head;
        private Node? tail;
        private int count;

        public int Count => count;

        public void AddLast(T value)
        {
            var newNode = new Node(value);
            if (head == null)
            {
                head = tail = newNode;
            }
            else
            {
                tail!.Next = newNode;
                newNode.Prev = tail;
                tail = newNode;
            }

            count++;
        }

        public void AddFirst(T value)
        {
            var newNode = new Node(value);
            if (head == null)
            {
                head = tail = newNode;
            }
            else
            {
                newNode.Next = head;
                head.Prev = newNode;
                head = newNode;
            }

            count++;
        }

        public void InsertAt(int index, T value)
        {
            if (index < 0 || index > count)
                throw new ArgumentOutOfRangeException();

            if (index == 0)
            {
                AddFirst(value);
                return;
            }

            if (index == count)
            {
                AddLast(value);
                return;
            }

            var newNode = new Node(value);
            var current = head;
            for (int i = 0; i < index; i++)
                current = current!.Next;

            newNode.Next = current;
            newNode.Prev = current!.Prev;

            current.Prev!.Next = newNode;
            current.Prev = newNode;

            count++;
        }

        public bool Remove(T value)
        {
            var current = head;
            while (current != null)
            {
                if (Equals(current.Value, value))
                {
                    RemoveNode(current);
                    return true;
                }

                current = current.Next;
            }

            return false;
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index >= count)
                throw new ArgumentOutOfRangeException();

            var current = head;
            for (int i = 0; i < index; i++)
                current = current!.Next;

            RemoveNode(current!);
        }

        private void RemoveNode(Node node)
        {
            if (node.Prev != null)
                node.Prev.Next = node.Next;
            else
                head = node.Next;

            if (node.Next != null)
                node.Next.Prev = node.Prev;
            else
                tail = node.Prev;

            count--;
        }

        public T GetAt(int index)
        {
            if (index < 0 || index >= count)
                throw new ArgumentOutOfRangeException();

            var current = head;
            for (int i = 0; i < index; i++)
                current = current!.Next;

            return current!.Value;
        }

        public bool Contains(T value) => IndexOf(value) != -1;

        public int IndexOf(T value)
        {
            var current = head;
            int index = 0;
            while (current != null)
            {
                if (Equals(current.Value, value))
                    return index;
                current = current.Next;
                index++;
            }

            return -1;
        }

        public T[] ToArray()
        {
            var result = new T[count];
            var current = head;
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