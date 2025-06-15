namespace Chapter06;

public static class Exercise10
{
    public static void PrintMatrix(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            int start = i;
            int count = n;
            while (count != 0)
            {
                Console.Write(start);
                start++;
                count--;
            }
            Console.WriteLine();
        }
    }
}