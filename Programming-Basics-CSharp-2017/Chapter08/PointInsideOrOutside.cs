namespace Chapter08;

public static class PointInsideOrOutside
{
    public static void Check()
    {
        int first = int.Parse(Console.ReadLine());
        int second = int.Parse(Console.ReadLine());
        int point = int.Parse(Console.ReadLine());
        
        Console.WriteLine(point >= first && point <= second ? "in" : "out");
        Console.WriteLine(Math.Min(Math.Abs(point - first), Math.Abs(point - second)));
    }
}