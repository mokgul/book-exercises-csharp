namespace Chapter07;

public static class Exercise04
{
    public static void FindBiggestEqualElementsSequence(int[] arr)
    {
        int maxElement = arr[0];
        int maxLength = 1;

        int currentElement = arr[0];
        int currentLength = 1;

        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] == currentElement)
            {
                currentLength++;
            }
            else
            {
                currentElement = arr[i];
                currentLength = 1;
            }

            if (currentLength > maxLength)
            {
                maxLength = currentLength;
                maxElement = currentElement;
            }
        }

        int[] seq = new int[maxLength];
        Array.Fill(seq, maxElement);

        Console.WriteLine($"Longest sequence is: {string.Join(", ", seq)}");
    }
}