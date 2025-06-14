namespace Chapter05;

public static class Exercise10
{
    public static void PrintPoints(int points)
    {
        int result = points switch
        {
            _ when points >= 1 && points <= 3 => points * 10,
            _ when points >= 4 && points <= 6 => points * 100,
            _ when points >= 7 && points <= 9 => points * 1000,
            _  => 0,
        };
        Console.WriteLine(result != 0
            ? $"Points: {result}"
            : "Incorrect number of points. Must be between 1 and 9.");
    }
}