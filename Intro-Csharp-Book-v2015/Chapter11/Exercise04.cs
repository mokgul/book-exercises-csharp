namespace Chapter11;

public static class Exercise04
{
    public static void PrintElapsedTime()
    {
        var elapsed = Environment.TickCount64;
        TimeSpan uptime = TimeSpan.FromMilliseconds(elapsed);

        int days    = uptime.Days;
        int hours   = uptime.Hours;
        int minutes = uptime.Minutes;
        int seconds = uptime.Seconds;
        int ms      = uptime.Milliseconds;

        Console.WriteLine(
            $"{days}d {hours}h {minutes}m {seconds}s {ms}ms"
        );

    }
}