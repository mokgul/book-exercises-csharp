namespace Chapter02;

public static class CurrencyConverter
{
    public static void Convert()
    {
        double usdRate = 1.79549;
        double eurRate = 1.95583;
        double gbpRate = 2.53405;

        Console.Write("Enter amount: ");
        double amount = double.Parse(Console.ReadLine());

        Console.Write("Enter currency to convert from (BGN, USD, EUR, GBP): ");
        string fromCurrency = Console.ReadLine().ToUpper();

        Console.Write("Enter currency to convert to (BGN, USD, EUR, GBP): ");
        string toCurrency = Console.ReadLine().ToUpper();
        
        double amountInBGN = 0;

        switch (fromCurrency)
        {
            case "BGN": amountInBGN = amount; break;
            case "USD": amountInBGN = amount * usdRate; break;
            case "EUR": amountInBGN = amount * eurRate; break;
            case "GBP": amountInBGN = amount * gbpRate; break;
            default: Console.WriteLine("Invalid currency!"); return;
        }
        
        double result = 0;

        switch (toCurrency)
        {
            case "BGN": result = amountInBGN; break;
            case "USD": result = amountInBGN / usdRate; break;
            case "EUR": result = amountInBGN / eurRate; break;
            case "GBP": result = amountInBGN / gbpRate; break;
            default: Console.WriteLine("Invalid currency!"); return;
        }

        Console.WriteLine($"Result: {Math.Round(result, 2)} {toCurrency}");
    }
}