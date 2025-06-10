namespace Chapter03;

public static class Exercise04
{
    public static void IsThirdBitOneOrZero(int number) => Console.WriteLine((number & 8) != 0);
}