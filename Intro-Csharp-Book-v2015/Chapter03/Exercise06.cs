namespace Chapter03;

public static class Exercise06
{
    public static void PrintRectPerAndArea()
    {
        var a = double.Parse(Console.ReadLine() ?? "0.0");
        var b = double.Parse(Console.ReadLine() ?? "0.0");
        Console.WriteLine($"Area: {a * b}. Perimeter: {(a + b) * 2}");
    }
}