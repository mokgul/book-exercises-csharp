namespace Chapter07;

public static class Exercise22
{
    public static void Ex22Nonsense()
    {
        Console.WriteLine("Enter numbers:");
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

        List<int> lis = LongestNonDecreasingSubsequence(arr);

        Console.WriteLine("LIS:");
        Console.WriteLine(string.Join(" ", lis));
    }

    static List<int> LongestNonDecreasingSubsequence(int[] arr)
    {
        int n = arr.Length;
        int[] dp = new int[n];
        int[] prev = new int[n];
        Array.Fill(dp, 1);
        Array.Fill(prev, -1);

        int maxLength = 1;
        int lastIndex = 0;

        for (int i = 1; i < n; i++)
        {
            for (int j = 0; j < i; j++)
            {
                if (arr[j] <= arr[i] && dp[j] + 1 > dp[i])
                {
                    dp[i] = dp[j] + 1;
                    prev[i] = j;
                }
            }

            if (dp[i] > maxLength)
            {
                maxLength = dp[i];
                lastIndex = i;
            }
        }

        List<int> lis = new List<int>();
        while (lastIndex != -1)
        {
            lis.Add(arr[lastIndex]);
            lastIndex = prev[lastIndex];
        }

        lis.Reverse();
        return lis;
    }
}