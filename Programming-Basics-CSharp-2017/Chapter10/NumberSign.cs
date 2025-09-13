namespace Chapter10;

public static class NumberSign
{
    public static void Print(int n)
    {
         switch(n)
        {
            case > 0: Console.WriteLine($"The number {n} is positive."); break;
            case < 0: Console.WriteLine($"The number {n} is negative."); break;
            default: Console.WriteLine($"The number {n} is zero."); break;
        };
    }
}