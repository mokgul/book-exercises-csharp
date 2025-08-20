namespace Chapter02;

public static class TriangleArea
{
    public static void Calculate()
    {
        Console.WriteLine("Enter triangle side:");
        double side = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter triangle height:");
        double height = double.Parse(Console.ReadLine());
        double area = Math.Round(side * height / 2, 2);
        Console.Write("Area area = ");
        Console.WriteLine(area);
    }
}