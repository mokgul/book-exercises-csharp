namespace Chapter08;

public static class StarsRectangle
{
    public static void Print()
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(new string('%', n * 2));
        int numRows = n;
        if (n % 2 == 0) numRows--;

        for (int i = 0; i < numRows; i++)
        {
            Console.Write("%");
            if (i == numRows / 2)
            {
                Console.Write(new string(' ', n - 2));
                Console.Write("**");
                Console.Write(new string(' ', n - 2));
            }
            else
            {
                Console.Write(new string(' ', n * 2 - 2));
            }
            Console.Write("%");
            Console.WriteLine();
        }
        Console.WriteLine(new string('%', n * 2));
    }
}