namespace Chapter08;

public static class TriangleAreaWithCoordinates
{
    public static void Calculate()
    {
        int x1 = int.Parse(Console.ReadLine());
        int y1 = int.Parse(Console.ReadLine());
        int x2 = int.Parse(Console.ReadLine());
        int y2 = int.Parse(Console.ReadLine());
        int x3 = int.Parse(Console.ReadLine());
        int y3 = int.Parse(Console.ReadLine());
        
        int side = Math.Abs(x2 - x3);
        int height = Math.Abs(y2 - y1);
        double area = ((double)side * height) / 2.0;
        Console.WriteLine($"{area:F2}");
    }
}