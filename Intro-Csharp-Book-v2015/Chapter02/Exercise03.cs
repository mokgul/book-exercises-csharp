namespace Chapter02;

public static class Exercise03
{
    public static void CheckPrecision()
    {
        double a = 5.000001;
        double b = 5.000002;
        double precision = 0.000001;

        bool areEqual = Math.Abs(a - b) <= precision;
        Console.WriteLine($"Are a and b equal (with precision {precision}): {areEqual}");
    }
}