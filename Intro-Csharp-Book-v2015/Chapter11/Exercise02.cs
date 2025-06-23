namespace Chapter11;

public static class Exercise02
{
    public static void PrintRandomNumbers()
    {
        int[] nums = new int[10];
        Random random = new Random();
        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = random.Next(100, 201);
        }
        Console.WriteLine(string.Join(", ", nums));
    }
}