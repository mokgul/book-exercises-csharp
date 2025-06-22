namespace Chapter10;

public static class Exercise03
{
    public static void CombinationsN(int n, int k)
    {
        int[] variation = new int[k];
        GenerateVariationsWithRepetition(n, k, 0, variation);
    }

    static void GenerateVariationsWithRepetition(int n, int k, int index, int[] variation)
    {
        if (index == k)
        {
            Console.WriteLine(string.Join(" ", variation));
            return;
        }

        for (int i = 1; i <= n; i++)
        {
            variation[index] = i;
            GenerateVariationsWithRepetition(n, k, index + 1, variation);
        }
    }
}