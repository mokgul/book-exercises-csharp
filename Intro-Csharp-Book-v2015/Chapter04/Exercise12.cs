using System.Numerics;

namespace Chapter04;

public static class Exercise12
{
    public static void Fibonacci()
    {
        BigInteger[] fib = new BigInteger[100];
        fib[0] = 0;
        fib[1] = 1;

        for (int i = 2; i < fib.Length; i++)
        {
            fib[i] = fib[i - 1] + fib[i - 2];
        }
        fib.ToList().ForEach(b => Console.WriteLine(b));
    }
}