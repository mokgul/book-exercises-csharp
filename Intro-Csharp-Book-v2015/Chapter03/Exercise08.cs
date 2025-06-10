namespace Chapter03;

public static class Exercise08
{
    public static void IsPointInsideCircleWithRadius5(int x, int y)
    {
        string result = x <= 5 && y <= 5 ? "Inside" : "Not inside";
        Console.WriteLine(result);
    }
}