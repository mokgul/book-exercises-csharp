namespace Chapter10;

public static class Square
{
    public static void Print(int n)
    {
        PrintHeaderFooter(n);
        for (int i = 1; i <= n - 2; i++)
        {
            PrintMiddleRow(n);
        }
        PrintHeaderFooter(n);
    }

    private static void PrintHeaderFooter(int n)
    {
        Console.WriteLine(new string('-', 2 * n));
    }

    private static void PrintMiddleRow(int n)
    {
        Console.Write('-');
        for (int i = 0; i < n - 1; i++)
        {
            Console.Write("\\/");
        }
        Console.Write('-');
        Console.WriteLine();
    }
}