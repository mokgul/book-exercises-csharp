namespace Chapter04;

public static class PointInFigure
{
    public static void Print()
    {
        string border = "border";
        string inside = "inside";
        string outside = "outside";
        
        int h = int.Parse(Console.ReadLine());
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());
        
        var rectangleBottom = (x > 0 && x < 3 * h) && (y > 0 && y < h);
        var rectangleTop = (x > h && x < 2 * h) && (y > h && y < 4 * h);
        var lineInBetween = (x > h && x < 2 * h) && (y == h);
        
        //border check
        var rectangleBottomBorderLR = (x == 0 || x == 3 * h) && (y >= 0 && y <= h);
        var rectangleBottomBorderBT = (y == 0 || y == h) && (x >= 0 && x <= 3 * h);
        var rectangleTopBorderLR = (x == h || x == 2 * h) && (y >= h && y <= 4 * h);
        var rectangleTopBorderBT = (y == 4 * h) && (x >= h && x <= 2 * h);

        if (rectangleBottom || rectangleTop || lineInBetween)
            Console.WriteLine(inside);
        else if (rectangleBottomBorderLR || rectangleBottomBorderBT || rectangleTopBorderLR || rectangleTopBorderBT)
            Console.WriteLine(border);
        else
            Console.WriteLine(outside);
    }
}