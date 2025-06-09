namespace Chapter01;

public static class Exercise10
{
    public static void PrintAHundredSequence()
    {
        int value = 2;
        int[] sequence = new int[100];
        for (int i = 0; i < 100; i++)
        {
            sequence[i] = value % 2 == 0 ? value : -value;
            value++;
        }

        Console.WriteLine($"Hundred sequence: {string.Join(", ", sequence)}");
    }
}