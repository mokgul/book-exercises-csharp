namespace Chapter06;

public static class Exercise17
{
    public static void FindBiggestCommonDominator(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        Console.WriteLine(a);
    }
}