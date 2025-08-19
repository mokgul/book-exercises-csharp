namespace Chapter02;

public static class CircleAreaAndPerimeter
{
    public static void Calculate()
    {
        Console.Write("Enter circle radius. r = ");
        var r = double.Parse(Console.ReadLine());
        Console.WriteLine("Area = " + Math.PI * r * r);
        Console.WriteLine("Perimeter = " + 2 * Math.PI * r);
    }
}