namespace Chapter04;

public static class SmallShop
{
    public static void CalculatePrice()
    {
        var prices = new Dictionary<string, Dictionary<string, double>>()
        {
            { "coffee", new Dictionary<string, double> { { "Sofia", 0.50 }, { "Plovdiv", 0.40 }, { "Varna", 0.45 } } },
            { "water", new Dictionary<string, double> { { "Sofia", 0.80 }, { "Plovdiv", 0.70 }, { "Varna", 0.70 } } },
            { "beer", new Dictionary<string, double> { { "Sofia", 1.20 }, { "Plovdiv", 1.15 }, { "Varna", 1.10 } } },
            { "sweets", new Dictionary<string, double> { { "Sofia", 1.45 }, { "Plovdiv", 1.30 }, { "Varna", 1.35 } } },
            { "peanuts", new Dictionary<string, double> { { "Sofia", 1.60 }, { "Plovdiv", 1.50 }, { "Varna", 1.55 } } }
        };
        
        string product = Console.ReadLine();
        string city = Console.ReadLine();
        double quantity = double.Parse(Console.ReadLine());

        if (prices.ContainsKey(product))
        {
            if (prices[product].ContainsKey(city))
            {
                double price = prices[product][city] * quantity;
                Console.WriteLine($"The price is {price:F2}.");
            }
            else
            {
                Console.WriteLine("Not a valid city.");
            }
        }
        else
        {
            Console.WriteLine("Product not found.");
        }
    }
}