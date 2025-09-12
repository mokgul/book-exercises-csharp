namespace Chapter09;

public static class MagicalDates
{
    public static void Solve()
    {
        string startDate = Console.ReadLine();
        string endDate = Console.ReadLine();
        int weight = int.Parse(Console.ReadLine());

        DateTime start = new DateTime(int.Parse(startDate), 1, 1);
        DateTime end = new  DateTime(int.Parse(endDate), 12, 31);

        for (DateTime date = start; date <= end; date = date.AddDays(1))
        {
            int currentWeight = GetWeight(date);
            if (currentWeight == weight)
            {
                Console.WriteLine(date.ToString("dd-MM-yyyy"));
            }
        }
    }

    private static int GetWeight(DateTime date)
    {
        string dateString = date.ToString("ddMMyyyy");
        int weight = 0;
        for (int i = 0; i < dateString.Length; i++)
        {
            for (int j = i + 1; j < dateString.Length; j++)
            {
                weight += int.Parse(dateString[i].ToString()) * int.Parse(dateString[j].ToString()); 
            }
        }
        return weight;
    }
}