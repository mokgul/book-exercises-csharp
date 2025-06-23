namespace Chapter11;

public static class Exercise03
{
    public static void PrintToday()
    {
        var today = DateTime.Today.DayOfWeek;
        Console.WriteLine($"Today is {today}");
    }
}