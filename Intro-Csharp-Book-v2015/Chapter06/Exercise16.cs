namespace Chapter06;

public static class Exercise16
{
    public static void RandomizeNumbers(int n)
    {
        List<int> list = new List<int>();
        for (int i = 1; i <= n; i++)
            list.Add(i);

        int[] randomized = new int[list.Count];
        int index = 0;
        while (list.Count > 0)
        {
            var random = new Random().Next(0, list.Count);
            randomized[index] = list.ElementAt(random);
            list.RemoveAt(random);
            index++;
        }

        Console.WriteLine(string.Join(", ", randomized));
    }
}