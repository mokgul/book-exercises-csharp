namespace Chapter10;

public static class Exercise07
{
    public static void Permutations(int n)
    {
        int[] array = new int[n];
        bool[] used = new bool[n + 1];
        GeneratePermutations(array, used, 0, n);
    }

    static void GeneratePermutations(int[] array, bool[] used, int index, int n)
    {
        if (index == n)
        {
            Console.WriteLine(string.Join(" ", array));
            return;
        }

        for (int i = 1; i <= n; i++)
        {
            if (!used[i])
            {
                array[index] = i;
                used[i] = true;
                GeneratePermutations(array, used, index + 1, n);
                used[i] = false; // backtrack
            }
        }
    }
}