namespace Chapter06;

public static class Exercise02
{
    public static void PrintNumbersWithCondition()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            if (i % 3 == 0 && i % 7 == 0)
                continue;
            Console.WriteLine(i);
        }
    }
}