namespace Chapter18;

public static class Exercise13
{
    public static void Subsequences()
    {
        int N = 5;
        int[] P = { 1, 1, 2, 1, -1, 2, 3, -1, 1, 2, 3, 5, 1, -1, 2, 3 };

        var happySubsequences = new List<List<int>>();

        for (int start = 0; start < P.Length; start++)
        {
            int sum = 0;
            var currentSubseq = new List<int>();

            for (int end = start; end < P.Length; end++)
            {
                sum += P[end];
                currentSubseq.Add(P[end]);

                if (sum == N)
                {
                    happySubsequences.Add(new List<int>(currentSubseq));
                }
            }
        }
        
        var sorted = happySubsequences
            .OrderByDescending(s => s.Count)
            .Take(10)
            .ToList();
        
        Console.WriteLine("Първите 10 щастливи подредици със сума " + N + ":");
        int i = 1;
        foreach (var seq in sorted)
        {
            Console.WriteLine($"{i++}. [{string.Join(", ", seq)}]");
        }
    }
}