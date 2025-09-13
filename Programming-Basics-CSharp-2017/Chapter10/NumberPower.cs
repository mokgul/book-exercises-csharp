namespace Chapter10;

public static class NumberPower
{
    public static void Print(int x, int n)
    {
        double result = GetPower(x, n);
        Console.WriteLine(result);
    }

    private static double GetPower(int x, int n)
    {
        return Math.Pow(x, n);
    }
}