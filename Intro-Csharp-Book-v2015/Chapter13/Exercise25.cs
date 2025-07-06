namespace Chapter13;

public static class Exercise25
{
    public static void SortWords()
    {
        string[] words = Console.ReadLine().Split(',');
        words = words.OrderBy(w => w).ToArray();
        Console.WriteLine(string.Join(",", words));
    }
}