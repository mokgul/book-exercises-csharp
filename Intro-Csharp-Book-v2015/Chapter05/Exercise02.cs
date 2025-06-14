namespace Chapter05;

public static class Exercise02
{
    public static void CheckMultiplicationResultSign(int a, int b, int c)
    {
        int sign = new int[] { a, b, c }.Count(n => n < 0);
        Console.WriteLine($"Sign of the multiplication result: {(sign % 2 != 0 ? "Negative" : "Positive")}");
    }
}