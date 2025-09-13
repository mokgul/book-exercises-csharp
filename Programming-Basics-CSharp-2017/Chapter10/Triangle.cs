namespace Chapter10;

public static class Triangle
{
    public static void Print(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            PrintLine(1, i);
        }
    }

    private static void PrintLine(int start, int end)
    {
        for (int i = start; i <= end; i++)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }

    public static void CalculateArea(double a, double h)
    {
        double area = GetTriangleArea(a, h);
        Console.WriteLine($"The area of the triangle is {area}");
    }

    private static double GetTriangleArea(double a, double h)
    {
        return (a * h) / 2;
    }
}