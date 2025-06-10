namespace Chapter02;

public static class Exercise13
{
    public static void ReverseValues()
    {
        int a = 5;
        int b = 10;
        (a, b) = (b, a);
        Console.WriteLine($"a: {a}, b: {b}");
    }
}