namespace Chapter05;

public static class Exercise01
{
    public static void CompareAndReverse(int a, int b)
    {
        (a, b) = a > b ? (b, a) : (a, b);
        Console.WriteLine($"Numbers: {a}, {b}");
    }
}