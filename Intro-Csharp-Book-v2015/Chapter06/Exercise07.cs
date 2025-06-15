namespace Chapter06;

public static class Exercise07
{
    public static void CalculateFactorialComplexDivision(int n, int k)
    {
        long factorialN = 1;
        long factorialK = 1;

        for (int i = 1; i <= n; i++)
            factorialN *= i;
        for (int i = 1; i <= k; i++)
            factorialK *= i;

        long result = (factorialN * factorialK) / (n - k);
        Console.WriteLine(result);
    }
}