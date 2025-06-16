namespace Chapter07;

public static class Exercise06
{
    public static void LongestIncreasingSubsequence(int[] arr)
    {
        int[] length = new int[arr.Length];
        int[] previous = new int[arr.Length];
        int[] longestSequence;

        int lastIndex = -1;
        int maxLength = 0;


        for (int i = 0; i < arr.Length; i++)
        {
            length[i] = 1;
            previous[i] = -1;

            for (int j = 0; j < i; j++)
            {
                if (arr[j] < arr[i] && length[j] >= length[i])
                {
                    length[i] = 1 + length[j];
                    previous[i] = j;
                }
            }

            if (length[i] > maxLength)
            {
                maxLength = length[i];
                lastIndex = i;
            }
        }

        longestSequence = new int[maxLength];

        for (int index = 0; index < maxLength; index++)
        {
            longestSequence[index] = arr[lastIndex];
            lastIndex = previous[lastIndex];
        }

        Array.Reverse(longestSequence);

        Console.WriteLine(string.Join(" ", longestSequence));
    }
}