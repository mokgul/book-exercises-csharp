namespace Chapter04;

public static class Volleyball
{
    public static void Calculate()
    {
        int weekends = 48; // 48 saturdays and 48 sundays 
        
        string year = Console.ReadLine();
        int holidays = int.Parse(Console.ReadLine());
        int weekendsOutOfTown = int.Parse(Console.ReadLine());
        
        double freeWeekends = ((weekends - weekendsOutOfTown) * 3.00) / 4;
        double playsDuringHolidays = (2.0 * holidays) / 3;
        double totalPlays = freeWeekends + playsDuringHolidays + weekendsOutOfTown;

        if (year == "leap")
            totalPlays *= 1.15;
        
        Console.WriteLine(Math.Floor(totalPlays));
    }
}