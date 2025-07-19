namespace Chapter16;

public static class Exercise15
{
    public class Node
    {
        public int Value;
        public Node? Next;

        public Node(int value)
        {
            Value = value;
            Next = null;
        }
    }

    public class LinkedList
    {
        public Node? Head;

        public void Add(int value)
        {
            Node newNode = new Node(value);
            if (Head == null)
            {
                Head = newNode;
                return;
            }

            Node current = Head;
            while (current.Next != null)
                current = current.Next;

            current.Next = newNode;
        }

        public void Print()
        {
            Node? current = Head;
            while (current != null)
            {
                Console.Write(current.Value + " ");
                current = current.Next;
            }
            Console.WriteLine();
        }

        // In-place bubble sort (can be replaced with selection or insertion sort too)
        public void Sort()
        {
            if (Head == null) return;

            bool swapped;
            do
            {
                swapped = false;
                Node? current = Head;
                while (current.Next != null)
                {
                    if (current.Value > current.Next.Value)
                    {
                        int temp = current.Value;
                        current.Value = current.Next.Value;
                        current.Next.Value = temp;
                        swapped = true;
                    }
                    current = current.Next;
                }
            } while (swapped);
        }
    }

}