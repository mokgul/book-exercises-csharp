namespace Chapter06;

public static class Exercise08
{
    public static void CalculateCatalanNumber(int n)
    {
        long factorialN = 1;
        long factorialNPlusOne = 1;
        long factorial2N = 1;

        for (long i = 1; i <= n; i++)
            factorialN *= i;
        factorialNPlusOne = factorialN * (n + 1);

        for (long i = 1; i <= 2 * n; i++)
        {
            factorial2N *= i;
        }

        long result = factorial2N / (factorialNPlusOne * factorialN);
        Console.WriteLine(result);
    }
}