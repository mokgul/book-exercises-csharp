namespace Chapter11;

public static class Exercise06
{
    public static void CalculateAreaByAllSides(double a, double b, double c)
    {
        double p = (a + b + c) / 2.0;
        double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        Console.WriteLine($"Area = {Math.Round(area, 2)}");
    }

    public static void CalculateAreaBySideAndHeight(double a, double h)
    {
        double area = (a * h) / 2.0;
        Console.WriteLine($"Area = {Math.Round(area, 2)}");
    }

    public static void CalculateAreaByTwoSidesAndAngle(double a, double b, double angle)
    {
        double sin = Math.Sin(angle / 57.3);
        double area = (a * b * sin) / 2.0;
        Console.WriteLine($"Area = {Math.Round(area, 2)}");
    }
}