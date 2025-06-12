namespace Chapter04;

public static class Exercise05
{
    public static void PrintCoundNumbersDivisibleByFiveInRange()
    {
        int start = int.Parse(Console.ReadLine());
        int end = int.Parse(Console.ReadLine());

        start += (5 - start % 5) % 5;
        end -= (end % 5);
        int count = ((end - start) / 5) + 1;
        Console.WriteLine($"Numbers divisible by 5: {count}");
    }
}