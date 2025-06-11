namespace Chapter03;

public static class Exercise14
{
    public static void IsPrime(int n)
    {
        bool isPrime = true;

        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
            {
                isPrime = false;
                break;
            }
        }

        Console.WriteLine(isPrime ? $"{n} is a prime number." : $"{n} is not a prime number.");
    }
}