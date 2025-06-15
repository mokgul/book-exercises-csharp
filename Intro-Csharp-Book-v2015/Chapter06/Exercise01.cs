namespace Chapter06;

public static class Exercise01
{
    public static void PrintNumbersToN()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
            Console.Write($"{i} ");
    }
}