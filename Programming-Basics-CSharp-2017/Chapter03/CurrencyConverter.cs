using System.Globalization;

namespace Chapter03;

public static class CurrencyConverter
{
    public static void Convert()
    {
        string vStr = Console.ReadLine();
        string from = Console.ReadLine();
        string to = Console.ReadLine();

        double value = double.Parse(vStr, CultureInfo.InvariantCulture);
        from = from.Trim().ToLowerInvariant();
        to = to.Trim().ToLowerInvariant();
        
        var toMeters = new Dictionary<string, double>
        {
            ["m"]  = 1.0,
            ["mm"] = 0.001,               // 1 mm = 0.001 m
            ["cm"] = 0.01,                // 1 cm = 0.01 m
            ["mi"] = 1.0 / 0.000621371192, // 1 mi = 1609.344 m
            ["in"] = 1.0 / 39.3700787,     // 1 in = 0.0254 m
            ["km"] = 1000.0,              // 1 km = 1000 m
            ["ft"] = 1.0 / 3.2808399,      // 1 ft = 0.3048 m
            ["yd"] = 1.0 / 1.0936133       // 1 yd = 0.9144 m
        };

        if (!toMeters.ContainsKey(from) || !toMeters.ContainsKey(to))
        {
            Console.WriteLine("Unsupported unit.");
            return;
        }
        
        double inMeters = value * toMeters[from];
        double result = inMeters / toMeters[to];
        
        Console.WriteLine(result.ToString("G17", CultureInfo.InvariantCulture));
    }
}