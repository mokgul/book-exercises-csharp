namespace Chapter16;

public static class Exercise06
{
    public static void RemoveOddCountedNumbers()
    {
        List<int> nums = [4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2];
        Dictionary<int, int> dic = new Dictionary<int, int>();

        foreach (var n in nums)
        {
            if (dic.ContainsKey(n))
            {
                dic[n]++;
            }
            else
            {
                dic.Add(n, 1);
            }
        }
        
        List<int> stack = new List<int>();
        foreach (var n in nums)
        {
            if (dic.ContainsKey(n) &&  dic[n] % 2 == 0)
            {
               stack.Add(n);
            }
        }
        
        Console.WriteLine(string.Join(", ", stack));
    }
}