namespace Chapter16;

public static class Exercise09
{
    public static void PrintSequence(int n, int count = 50)
    {
        Queue<int> queue = new Queue<int>();
        queue.Enqueue(n);

        int printed = 0;
        while (printed < count)
        {
            int current = queue.Dequeue();
            Console.Write(current);
            
            printed++;
            if(printed < count)
                Console.Write(", ");
            
            queue.Enqueue(current + 1);
            queue.Enqueue(2 * current + 1);
            queue.Enqueue(current + 2);
        }
        Console.WriteLine();
    }
}