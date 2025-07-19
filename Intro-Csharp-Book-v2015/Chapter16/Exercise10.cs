namespace Chapter16;

public static class Exercise10
{
    public static void Operations(int n, int m)
    {
        Queue<int> queue = new Queue<int>();
        queue.Enqueue(n);
        bool initialValueIsOdd = m % 2 != 0;
        if (n < m / 2)
        {
            while (n < m / 2)
            {
                if (m / 2 - n > 1)
                    n += 2;
                else
                    n += 1;
                queue.Enqueue(n);
            }
            queue.Enqueue(initialValueIsOdd ? n * 2 + 1 : n * 2);
        }
        else if (n > m / 2)
        {
            while (n > m / 2)
            {
                if (n - m / 2 > 1)
                    n -= 2;
                else
                    n -= 1;
                queue.Enqueue(n);
            }
            queue.Enqueue(initialValueIsOdd ? n * 2 + 1 : n * 2);
        }
        else
        {
            queue.Enqueue(initialValueIsOdd ? n * 2 + 1 : n * 2);
        }
        
        Console.WriteLine(string.Join(", ", queue));
    }
}