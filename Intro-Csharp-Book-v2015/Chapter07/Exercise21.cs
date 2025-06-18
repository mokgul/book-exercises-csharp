namespace Chapter07;

public static class Exercise21
{
    static bool found = false;
    public static void Ex21Nonsense()
    {
        int[] numbers = { 1, 3, 5, 7, 9 };
        int K = 3;
        int S = 15;

        List<int> combination = new List<int>();
        FindCombinations(numbers, K, S, 0, combination, 0);

        if (!found)
        {
            Console.WriteLine("Невъзможно е да се намерят такива елементи.");
        }
    }

    static void FindCombinations(int[] array, int k, int targetSum, int index, List<int> current, int currentSum)
    {
        if (current.Count == k)
        {
            if (currentSum == targetSum)
            {
                Console.WriteLine("Намерена комбинация: " + string.Join(" + ", current) + " = " + targetSum);
                found = true;
            }
            return;
        }

        for (int i = index; i < array.Length; i++)
        {
            current.Add(array[i]);
            FindCombinations(array, k, targetSum, i + 1, current, currentSum + array[i]);
            current.RemoveAt(current.Count - 1);
        }
    }
}