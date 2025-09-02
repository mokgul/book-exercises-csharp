namespace Chapter03;

public static class SleepingCatTom
{
    public static void CalculatePlayTime()
    {
        int sleepingNorm     = 30000;
        int workdaysPlaytime = 63;
        int dayOffsPlaytime  = 127;

        int dayoffs = int.Parse(Console.ReadLine());

        int workdays   = 365 - dayoffs;
        int playtime   = workdays * workdaysPlaytime + dayoffs * dayOffsPlaytime;
        int difference = Math.Abs(sleepingNorm - playtime);

        if (playtime > sleepingNorm)
        {
            Console.WriteLine("Tom will run away");
            Console.WriteLine($"{difference / 60} hours and {difference % 60} minutes more for play");
        }
        else if (playtime <= sleepingNorm)
        {
            Console.WriteLine("Tom sleeps well");
            Console.WriteLine($"{difference / 60} hours and {difference % 60} minutes less for play");
        }
    }
}