namespace Chapter07;

public static class Exercise05
{
    public static void FindIncreasingSequence(int[] arr)
    {
        int maxLength = 1;
        int currentLength = 1;
        int endIndex = 0;

        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > arr[i - 1])
            {
                currentLength++;
                if (currentLength > maxLength)
                {
                    maxLength = currentLength;
                    endIndex = i;
                }
            }
            else
            {
                currentLength = 1;
            }
        }

        Console.Write("Longest increasing sequence: ");
        for (int i = endIndex - maxLength + 1; i <= endIndex; i++)
        {
            Console.Write(arr[i] + " ");
        }

        Console.WriteLine();
    }
}