using System.Globalization;

namespace Chapter11;

public static class Exercise09
{
    public static void CalculateWorkDays()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.Write("Въведете бъдеща дата (гггг-мм-дд): ");
        string input = Console.ReadLine();

        if (!DateTime.TryParseExact(input, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime endDate))
        {
            Console.WriteLine("Невалидна дата!");
            return;
        }

        DateTime today = DateTime.Today;
        if (endDate < today)
        {
            Console.WriteLine("Датата трябва да е след днешната!");
            return;
        }

        int workingDays = CountWorkingDays(today, endDate);
        Console.WriteLine($"Брой работни дни между {today:yyyy-MM-dd} и {endDate:yyyy-MM-dd}: {workingDays}");
    }

    static int CountWorkingDays(DateTime start, DateTime end)
    {
        // Примерни официални празници (фиксирани и подвижни за демонстрация)
        HashSet<DateTime> holidays = new HashSet<DateTime>
        {
            new DateTime(start.Year, 1, 1),   // Нова година
            new DateTime(start.Year, 3, 3),   // Освобождение
            new DateTime(start.Year, 5, 1),   // Ден на труда
            new DateTime(start.Year, 5, 6),   // Гергьовден
            new DateTime(start.Year, 5, 24),  // Ден на буквите
            new DateTime(start.Year, 9, 6),   // Съединение
            new DateTime(start.Year, 9, 22),  // Независимост
            new DateTime(start.Year, 12, 24),
            new DateTime(start.Year, 12, 25),
            new DateTime(start.Year, 12, 26)
        };

        // Работни съботи (примерно)
        HashSet<DateTime> workingSaturdays = new HashSet<DateTime>
        {
            new DateTime(start.Year, 5, 13),
            new DateTime(start.Year, 12, 16)
        };

        int count = 0;
        for (DateTime day = start; day <= end; day = day.AddDays(1))
        {
            DayOfWeek dayOfWeek = day.DayOfWeek;

            bool isHoliday = holidays.Contains(day);
            bool isWeekend = dayOfWeek == DayOfWeek.Saturday || dayOfWeek == DayOfWeek.Sunday;

            if (isHoliday)
                continue;

            if (dayOfWeek == DayOfWeek.Saturday && workingSaturdays.Contains(day))
            {
                count++; // работна събота
            }
            else if (dayOfWeek != DayOfWeek.Saturday && dayOfWeek != DayOfWeek.Sunday)
            {
                count++; // нормален работен ден
            }
        }

        return count;
    }
}