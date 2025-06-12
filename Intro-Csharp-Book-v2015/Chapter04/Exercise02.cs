namespace Chapter04;

public static class Exercise02
{
    public static void CalculateCircleAreaAndPerimeter()
    {
        int r = int.Parse(Console.ReadLine());
        var area = Math.PI * r * r;
        var perimeter = 2 * Math.PI * r;
        Console.WriteLine($"Area: {area:F2}. Perimeter: {perimeter:F2}");
    }
}