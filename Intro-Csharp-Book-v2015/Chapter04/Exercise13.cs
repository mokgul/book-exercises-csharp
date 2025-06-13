namespace Chapter04;

public static class Exercise13
{
    public static void SumFractionalNums()
    {
        double sum = 0;
        for (double i = 1; i <= 1000; i++)
        {
            sum += 1 / i;
        }

        Console.WriteLine($"Sum: {sum}");
    }
}