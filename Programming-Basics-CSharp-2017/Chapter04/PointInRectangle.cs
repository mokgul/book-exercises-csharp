namespace Chapter04;

public static class PointInRectangle
{
    public static void InsideOrOutside()
    {
        var x1 = double.Parse(Console.ReadLine());
        var y1 = double.Parse(Console.ReadLine());
        var x2 = double.Parse(Console.ReadLine());
        var y2 = double.Parse(Console.ReadLine());
        var x = double.Parse(Console.ReadLine());
        var y = double.Parse(Console.ReadLine());

        if (x >= x1 && x <= x2 && y >= y1 && y <= y2)
            Console.WriteLine("Inside");
        else
            Console.WriteLine("Outside");
    }
}