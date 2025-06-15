namespace Chapter06;

public static class Exercise06
{
    public static void CalculateFactorialDivision(int n, int k)
    {
        int factorialN = 1;
        for (int i = 1; i <= n; i++)
            factorialN *= i;

        int factorialK = 1;
        for(int i = 1; i <= k; i++)
            factorialK *= i;

        int result = factorialN / factorialK;
        Console.WriteLine($"{result}");
    }
}