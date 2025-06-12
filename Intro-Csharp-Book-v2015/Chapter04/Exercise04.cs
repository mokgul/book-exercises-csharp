namespace Chapter04;

public static class Exercise04
{
    public static void PrintNumbersWithIndent()
    {
        Console.WriteLine("{0,-10:x}", 15);
        Console.WriteLine("{0,-10:f2}", 23.58);
        Console.WriteLine("{0,-10:f2}", -15.47);
    }
}