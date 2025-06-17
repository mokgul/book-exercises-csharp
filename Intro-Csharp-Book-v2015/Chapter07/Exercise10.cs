namespace Chapter07;

public static class Exercise10
{
    public static void MostCommonElementInArray(int[] arr)
    {
        int count = 0;
        int element = 0;
        foreach (var item in arr.GroupBy(x => x))
        {
            if (item.Count() > count)
            {
                element = item.Key;
                count = item.Count();
            }

        }
        Console.WriteLine($"Element: {element} Count: {count}");
    }
}