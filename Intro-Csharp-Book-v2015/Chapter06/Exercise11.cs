namespace Chapter06;

public static class Exercise11
{
    public static void CountFactorialNulls(int n)
    {
        long factorial = Factorial(n);
        int count = 0;
        while (true)
        {
            long lastDigit = factorial % 10;
            factorial /= 10;
            if (lastDigit == 0)
                count++;
            else
                break;
        }
        Console.WriteLine(count);
    }

    private static long Factorial(int n)
    {
        long factorial = 1;
        for (int i = 1; i <= n; i++)
            factorial *= i;
        return factorial;
    }
}