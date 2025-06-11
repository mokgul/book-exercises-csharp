namespace Chapter03;

public static class Exercise12
{
    public static void IsBitOne(int v, int p)
    {
        Console.WriteLine(((v >> p) & 1) == 1);
    }
}