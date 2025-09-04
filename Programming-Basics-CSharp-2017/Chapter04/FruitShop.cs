namespace Chapter04;

public static class FruitShop
{
    public static void CalculatePrice()
    {
        var weekPrices = new Dictionary<string, double>()
        {
            { "banana", 2.50 }, { "apple", 1.20 },
            { "orange", 0.85 }, { "grapefruit", 1.45 },
            { "kiwi", 2.70 }, { "pineapple", 5.50 },
            { "grapes", 3.85 }
        };

        var weekendPrices = new Dictionary<string, double>()
        {
            { "banana", 2.70 }, { "apple", 1.25 },
            { "orange", 0.90 }, { "grapefruit", 1.60 },
            { "kiwi", 3.00 }, { "pineapple", 5.60 },
            { "grapes", 4.20 }
        };
        string fruit = Console.ReadLine();
        string day = Console.ReadLine();
        double quantity = double.Parse(Console.ReadLine());

        double price = 0;
        switch (day)
        {
            case "Monday":
            case "Tuesday":
            case "Wednesday":
            case "Thursday":
            case "Friday":
                if (weekPrices.ContainsKey(fruit))
                {
                    price = weekPrices[fruit] * quantity;
                }
                else
                {
                    Console.WriteLine("error");
                    return;
                }

                break;
            case "Saturday":
            case "Sunday":
                if (weekendPrices.ContainsKey(fruit))
                {
                    price = weekendPrices[fruit] * quantity;
                }
                else
                {
                    Console.WriteLine("error");
                    return;
                }

                break;
            default:
                Console.WriteLine("error");
                return;
        }

        Console.WriteLine($"{price:F2}");
    }
}