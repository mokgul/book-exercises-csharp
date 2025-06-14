namespace Chapter05;

public static class Exercise07
{
    public static void PrintBiggestNumber(int[] numbers)
    {
        int biggest = numbers.OrderByDescending(n => n).First();
        Console.WriteLine("Biggest number: {0}",biggest);
    }
}