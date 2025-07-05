namespace Chapter13;

public static class Exercise18
{
    public static void DateAddition()
    {
        Console.WriteLine("Enter a date in the format DD.MM.YYYY HH:mm:ss");
        string input = Console.ReadLine();
        try
        {
            var date  = DateTime.ParseExact(input, "dd.MM.yyyy HH:mm:ss", null);
            date = date.AddHours(6).AddMinutes(30);
            Console.WriteLine($"Date: {date.Day} Hour:  {date.Hour}");
        }
        catch (Exception e)
        {
            Console.WriteLine("Incorrect format");
        }
    }
}