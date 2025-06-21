using System.Numerics;

namespace Chapter09;

public static class Exercise10
{
    public static BigInteger CalculateFactorial(int n)
    {
        if (n == 1)
            return 1;
        BigInteger result = 1;
        for (int i = 2; i <= n; i++)
        {
            result *= i;
        }

        return result;
    }
}