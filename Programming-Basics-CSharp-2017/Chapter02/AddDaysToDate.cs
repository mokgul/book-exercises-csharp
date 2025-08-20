using System.Globalization;

namespace Chapter02;

public static class AddDaysToDate
{
    public static void Calculate()
    {
        string input = Console.ReadLine();
        DateTime birthDate = DateTime.ParseExact(input, "dd-MM-yyyy", CultureInfo.InvariantCulture);

        DateTime resultDate = birthDate.AddDays(1000);

        Console.WriteLine(resultDate.ToString("dd-MM-yyyy"));
    }
}