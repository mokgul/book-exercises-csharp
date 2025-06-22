namespace Chapter10;

public static class Exercise02
{
    public static void Combinations(int n, int k)
    {
        int[] combination = new int[k];
        GenerateCombinationsWithRepetition(n, k, 0, 1, combination);
    }

    static void GenerateCombinationsWithRepetition(int n, int k, int index, int start, int[] combination)
    {
        if (index == k)
        {
            Console.WriteLine(string.Join(" ", combination));
            return;
        }

        for (int i = start; i <= n; i++)
        {
            combination[index] = i;
            GenerateCombinationsWithRepetition(n, k, index + 1, i, combination);
        }
    }
}