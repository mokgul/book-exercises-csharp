namespace Chapter04;

public static class Exercise11
{
    public static void PrintNumbersInRange()
    {
        Console.WriteLine("Enter a number: ");
        int n = int.Parse(Console.ReadLine());
        Enumerable.Range(1, n).ToList().ForEach(Console.WriteLine);
    }
}