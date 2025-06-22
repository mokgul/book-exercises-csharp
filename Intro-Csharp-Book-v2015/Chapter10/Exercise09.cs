namespace Chapter10;

public static class Exercise09
{
    public static void ElementsThatSumToN()
    {
        int[] array = { 3, 34, 4, 12, 5, 2 };
        int target = 9;
        Console.WriteLine(HasSubsetSum(array, target) ? "Yes" : "No");
    }

    static bool HasSubsetSum(int[] array, int target)
    {
        int n = array.Length;
        int subsetCount = 1 << n; // 2^n подмножества

        for (int mask = 0; mask < subsetCount; mask++)
        {
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                if ((mask & (1 << i)) != 0)
                    sum += array[i];
            }

            if (sum == target)
                return true;
        }

        return false;
    }
}