namespace Chapter07;

public static class Exercise07
{
    public static void MaxSumOfKElementsInArray()
    {
        Console.WriteLine("Enter the length of the array: n =");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the number of elements to sum: k =");
        int k = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        int[] elements = new int[k];

        for (int index = 0; index < n; index++)
        {
            Console.Write("arr[{0}] = ", index);
            arr[index] = int.Parse(Console.ReadLine());
        }

        int maxSum = 0;
        for (int i = 0; i < n; i++)
        {
            if (i + k < n)
            {
                int currentSum = 0;
                for (int j = 0; j < k; j++)
                {
                    currentSum += arr[i + j];
                }
                if (maxSum < currentSum)
                {
                    maxSum = currentSum;
                    for (int j = 0; j < k; j++)
                    {
                        elements[j] = arr[i + j];
                    }
                }
            }
        }

        Console.WriteLine($"Max sum: {maxSum}. Elements: {string.Join(", ", elements)}");
    }
}