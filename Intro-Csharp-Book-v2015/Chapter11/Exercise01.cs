namespace Chapter11;

public static class Exercise01
{
    public static void IsYearLeap()
    {
        Console.WriteLine("Enter year: ");
        int year = Convert.ToInt32(Console.ReadLine());
        bool isYearLeap = DateTime.IsLeapYear(year);
        Console.WriteLine($"Is year leap: {isYearLeap}");
    }
}