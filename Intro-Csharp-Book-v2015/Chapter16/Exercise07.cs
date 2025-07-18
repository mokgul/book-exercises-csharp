namespace Chapter16;

public static class Exercise07
{
    public static void CountOccurrence()
    {
        List<int> list = new List<int>() { 1, 2, 2, 4, 11, 3, 7, 5, 5, 5, 5, 21 };
        Dictionary<int, int> dict = new Dictionary<int, int>();
        foreach (var n in list)
        {
            if (dict.ContainsKey(n))
                dict[n]++;
            else
                dict[n] = 1;
        }

        foreach (var n in dict)
        {
            Console.WriteLine($"{n.Key} - {n.Value} times");
        }
    }
}