namespace Chapter18;

public static class Exercise01
{
    public static void CountNumbers()
    {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        int[] numbers = { 3, 4, 4, 2, 3, 3, 4, 3, 2 };

        foreach (var num in numbers)
        {
            if (!dict.ContainsKey(num))
            {
                dict[num] = 1;
            }
            else
            {
                dict[num]++;
            }
        }

        foreach (var num in dict.OrderBy(s => s.Key))
        {
            Console.WriteLine($"{num.Key} - {num.Value}");
        }
    }
}