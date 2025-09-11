namespace Chapter08;

public static class DateAfterGivenTime
{
    public static void Print()
    {
        int d = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());

        DateTime date = new DateTime(2025, m, d);
        date = date.AddDays(5);
        Console.WriteLine($"{date.Day}.{date.Month:D2}");
    }
}