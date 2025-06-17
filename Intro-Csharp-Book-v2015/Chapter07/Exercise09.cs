namespace Chapter07;

public static class Exercise09
{
    public static void MaxSequenceSum(int[] arr)
    {
        int maxSum = int.MinValue;
        int step = 1;
        while (step <= arr.Length)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int currentSum = 0;
                int count = step;
                while (count >= 0)
                {
                    if(count + i < arr.Length)
                        currentSum += arr[count + i];
                    count--;
                }
                if (currentSum > maxSum)
                    maxSum = currentSum;
            }

            step++;
        }
        Console.WriteLine(maxSum);
    }
}