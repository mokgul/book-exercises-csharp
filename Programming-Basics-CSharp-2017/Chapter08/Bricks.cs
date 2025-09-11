namespace Chapter08;

public static class Bricks
{
    public static void CalculateTimeNeeded()
    {
        int x = int.Parse(Console.ReadLine());
        int w = int.Parse(Console.ReadLine());
        int m  = int.Parse(Console.ReadLine());

        double result = Math.Ceiling((w * m) / (double)x);
        Console.WriteLine($"{result:F2}");
    }
}