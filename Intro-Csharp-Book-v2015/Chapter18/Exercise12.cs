namespace Chapter18;

public static class Exercise12
{
    public static void BusSchedule()
    {
        var buses = new List<(TimeSpan arrival, TimeSpan departure)>
        {
            (ParseTime("08:24"), ParseTime("08:33")),
            (ParseTime("08:20"), ParseTime("09:00")),
            (ParseTime("08:32"), ParseTime("08:37")),
            (ParseTime("09:00"), ParseTime("09:15"))
        };
        
        var intervalStart = ParseTime("08:22");
        var intervalEnd = ParseTime("09:05");
        
        int count = 0;

        foreach (var (arrival, departure) in buses)
        {
            if (arrival >= intervalStart && departure <= intervalEnd)
            {
                count++;
            }
        }

        Console.WriteLine("Брой автобуси в интервала: " + count);
    }
    
    static TimeSpan ParseTime(string time)
    {
        return TimeSpan.ParseExact(time, "hh\\:mm", null);
    }
}