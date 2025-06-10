namespace Chapter03;

public static class Exercise03
{
    public static void IsThirdDigitSeven(int number) => Console.WriteLine((number % 100) % 10 == 7);
}