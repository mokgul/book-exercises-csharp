namespace Chapter04;

public static class PointOnRectangleBorder
{
    public static void Check()
    {
        int x1 = int.Parse(Console.ReadLine());
        int y1 = int.Parse(Console.ReadLine());
        int x2 = int.Parse(Console.ReadLine());
        int y2 = int.Parse(Console.ReadLine());
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());
        
        if ((x == x1 || x == x2) && (y >= y1 && y <= y2))
            Console.WriteLine("Border");
        else if ((y == y1 || y == y2) && (x >= x1 && x <= x2))
           Console.WriteLine("Border");
        else
            Console.WriteLine("Inside / Outside");
    }
}