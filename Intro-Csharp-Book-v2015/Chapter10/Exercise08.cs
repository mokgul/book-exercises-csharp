namespace Chapter10;

public static class Exercise08
{
    public static void ArrayElementsThatSum(int[] array)
    {
        int targetSum = 4;
        List<int> currentSubset = new List<int>();
        FindSubsetsWithSum(array, targetSum, 0, 0, currentSubset);
    }

    static void FindSubsetsWithSum(int[] array, int target, int index, int currentSum, List<int> subset)
    {
        if (index == array.Length)
        {
            if (currentSum == target)
            {
                Console.WriteLine(string.Join(" + ", subset));
            }
            return;
        }

        // Включваме текущия елемент
        subset.Add(array[index]);
        FindSubsetsWithSum(array, target, index + 1, currentSum + array[index], subset);

        // Не включваме текущия елемент (backtrack)
        subset.RemoveAt(subset.Count - 1);
        FindSubsetsWithSum(array, target, index + 1, currentSum, subset);
    }
}