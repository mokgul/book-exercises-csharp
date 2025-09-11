namespace Chapter08;

public static class Distance
{
    public static void Solve()
    {
        int v0 = int.Parse(Console.ReadLine());
        int t1 = int.Parse(Console.ReadLine());
        int t2 = int.Parse(Console.ReadLine());
        int t3 = int.Parse(Console.ReadLine());
        
        double h1 = t1 / 60.0;
        double h2 = t2 / 60.0;
        double h3 = t3 / 60.0;
        
        double v1 = v0 * 1.10;
        double v2 = v1 * 0.95;
        
        double d1 = v0 * h1;
        double d2 = v1 * h2;
        double d3 = v2 * h3;

        double total = d1 + d2 + d3;

        Console.WriteLine($"{total:F2}");
    }
}