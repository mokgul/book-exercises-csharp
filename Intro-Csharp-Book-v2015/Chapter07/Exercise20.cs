namespace Chapter07;

public static class Exercise20
{
    public static void Ex20Nonsense()
    {
        int[] numbers = { 2, 1, 2, 4, 3, 5, 2, 6 };
        int S = 14;

        bool found = CheckSubsetSum(numbers, S);

        Console.WriteLine(found ? "Yes" : "No");
    }

    static bool CheckSubsetSum(int[] array, int targetSum)
    {
        int n = array.Length;
        int totalCombinations = 1 << n; // 2^n combinations

        for (int i = 0; i < totalCombinations; i++)
        {
            int currentSum = 0;

            for (int j = 0; j < n; j++)
            {
                // Check if j-th element is included in this combination
                if ((i & (1 << j)) != 0)
                {
                    currentSum += array[j];
                }
            }

            if (currentSum == targetSum)
            {
                return true;
            }
        }

        return false;
    }
}