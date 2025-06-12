namespace Chapter04;

public static class Exercise01
{
    private static readonly Func<int> R = () => int.Parse(Console.ReadLine());

    public static void ReadAndSumNumbers()
    {
        var nums = new [] {R(), R(), R()};
        Console.WriteLine(nums.Sum());
    }
}