namespace Chapter03;

public static class Exercise11
{
    public static void MoveBits(int number, int position)
    {
        int n = number;
        int p = position;
        int i = 1; // 00000001
        int mask = i << p; // Move the 1st bit left by p positions

        Console.WriteLine((n & mask) != 0 ? 1 : 0);
    }
}