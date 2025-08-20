namespace Chapter02;

public static class UsdToBgn
{
    public static void Convert()
    {
        double usd = double.Parse(Console.ReadLine());
        double bgn = usd * 1.79549;
        Console.WriteLine($"{bgn:f2} BGN");
    }
}