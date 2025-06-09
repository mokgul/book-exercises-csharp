namespace Chapter01;

public static class Exercise07
{
    public static void WriteNumbers(int[] numbers)
    {
        Array.ForEach(numbers,n => Console.WriteLine(n));
    }
}