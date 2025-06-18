namespace Chapter07;

public static class Exercise19
{
    public static void PrintPrimeNumbersInRange(int start, int end)
    {
        for (var i = start; i <= end; i++)
        {
            bool isPrime = IsNumPrime(i);
            if (isPrime) Console.Write(i + " ");
        }
    }

    static bool IsNumPrime(int num)
    {
        if (num <= 1) return false;
        for (int i = 2; i < num; i++)
        {
            if (num % i == 0) return false;
        }
        return true;
    }
}