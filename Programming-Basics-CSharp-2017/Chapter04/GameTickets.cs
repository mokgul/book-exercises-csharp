namespace Chapter04;

public static class GameTickets
{
    public static void CalculatePrice()
    {
        double budget = double.Parse(Console.ReadLine());
        string category = Console.ReadLine();
        int people = int.Parse(Console.ReadLine());

        double total = people switch
        {
            <= 4 => budget * 0.75,
            <= 9 => budget * 0.60,
            <= 24 => budget * 0.50,
            <= 49 => budget * 0.40,
            >= 50 => budget * 0.25
        };
        total += category == "VIP" ? people * 499.99 : people * 249.99;
        Console.WriteLine(budget >= total
            ? $"Yes! You have {(budget - total):f2} leva left."
            : $"Not enough money! You need {(total - budget):f2} leva.");
    }
}