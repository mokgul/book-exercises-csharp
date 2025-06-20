namespace Chapter08;

public static class Exercise14
{
    public static void UseFloatingPointTypesAndDecimal()
    {
        float a = 0f;
        double b = 0;
        decimal c = 0m;

        for (float i = 0; i < 50_000_000; i+=0.000001f)
        {
            a += i;
        }

        for (double i = 0; i < 50_000_000; i+=0.000001)
        {
            b += i;
        }

        for (decimal i = 0; i < 50_000_000; i+=0.000001m)
        {
            c += i;
        }

        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(c);
    }
}