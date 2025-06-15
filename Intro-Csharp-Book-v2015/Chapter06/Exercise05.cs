using System.Numerics;

namespace Chapter06;

public static class Exercise05
{
    public static void PrintNFibbonacciNumbers()
    {
        Console.WriteLine("Enter N fibonacci numbers: ");
        int n = int.Parse(Console.ReadLine());

        BigInteger[] fib = new BigInteger[n];
        fib[0] = 0;
        fib[1] = 1;

        for (int i = 2; i < fib.Length; i++)
        {
            fib[i] = fib[i - 1] + fib[i - 2];
        }
        fib.ToList().ForEach(b => Console.WriteLine(b));
    }
}