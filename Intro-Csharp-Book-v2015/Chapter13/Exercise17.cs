namespace Chapter13;

public static class Exercise17
{
    public static void DatesDifference()
    {
        Console.Write("Enter the first date: ");
        string firstDate = Console.ReadLine();
        Console.Write("Enter the second date: ");
        string secondDate = Console.ReadLine();

        string[] formats = ["d.M.yyyy", "dd.M.yyyy", "d.MM.yyyy", "dd.MM.yyyy"];

        try
        {
            DateTime first = DateTime.ParseExact(firstDate, formats, null);
            DateTime second = DateTime.ParseExact(secondDate, formats, null);
            var difference = second - first;
            Console.WriteLine($"Distance: {difference.Days}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid date format");
        }
    }
}