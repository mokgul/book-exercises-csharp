namespace Chapter10;

public static class Exercise04
{
    public static void CombinationStrings(string[] input, int k)
    {
        string[] subset = new string[k];
        GenerateSubsets(input, k, 0, 0, subset);
    }

    static void GenerateSubsets(string[] input, int k, int index, int start, string[] subset)
    {
        if (index == k)
        {
            Console.WriteLine("(" + string.Join(" ", subset) + ")");
            return;
        }

        for (int i = start; i < input.Length; i++)
        {
            subset[index] = input[i];
            GenerateSubsets(input, k, index + 1, i + 1, subset);
        }
    }
}