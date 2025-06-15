namespace Chapter06;

public static class Exercise09
{
    public static void CalculateComplexSum(double n, double x)
    {
        double sum = 1;

        for (int i = 1; i <= n; i++)
        {
            sum += (Factorial(i) / Math.Pow(x, i));
        }
        Console.WriteLine(sum);
    }

    private static double Factorial(double n)
    {
        double factorial = 1;
        for (int i = 1; i <= n; i++)
            factorial *= i;
        return factorial;
    }
}