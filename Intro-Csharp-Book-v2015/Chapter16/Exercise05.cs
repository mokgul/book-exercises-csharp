namespace Chapter16;

public static class Exercise05
{
    public static void RemoveNegativeNumbers()
    {
        List<int> nums = new List<int>() { 19, -10, 12, -6, -3, 34, -2, 5 };
        nums.RemoveAll(n => n < 0);
        
        Console.WriteLine(string.Join(", ", nums));
    }
}