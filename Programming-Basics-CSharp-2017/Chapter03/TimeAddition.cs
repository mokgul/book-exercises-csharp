namespace Chapter03;

public static class TimeAddition
{
    public static void AddMinutes()
    {
        int hour = int.Parse(Console.ReadLine());
        int minute = int.Parse(Console.ReadLine());

        minute += 15;
        if (minute > 59)
        {
            minute -= 60;
            hour++;
        }

        if (hour > 23)
        {
            hour -= 24;
        }
        Console.WriteLine($"{hour:D2}:{minute:D2}");
    }
}