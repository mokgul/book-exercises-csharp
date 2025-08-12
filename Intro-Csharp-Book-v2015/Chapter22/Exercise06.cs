namespace Chapter22;

public static class Exercise06
{
    public static void FindNumbers(int[] numbers)
    {
        var nums = numbers.Where(n => n % 7 == 0 && n % 3 == 0);

        foreach (var num in nums)
        {
            Console.Write($"{num} ");
        }
        Console.WriteLine();
    }
}