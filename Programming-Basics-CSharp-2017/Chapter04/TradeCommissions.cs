namespace Chapter04;

public static class TradeCommissions
{
    public static void Calculate()
    {
        decimal[] Sofia = { 0.05m, 0.07m, 0.08m, 0.12m };
        decimal[] Varna = { 0.045m, 0.075m, 0.10m, 0.13m };
        decimal[] Plovdiv = { 0.055m, 0.08m, 0.12m, 0.145m };

        var city = Console.ReadLine().ToLower();
        decimal sales = decimal.Parse(Console.ReadLine());
        decimal commission = 0;

        switch (sales)
        {
            case > 0 and <= 500:
                switch (city)
                {
                    case "sofia": commission = sales * Sofia[0]; break;
                    case "varna": commission = sales * Varna[0]; break;
                    case "plovdiv": commission = sales * Plovdiv[0]; break;
                    default: Console.WriteLine("error"); break;
                }
                break;
            
            case > 500 and <= 1000:
                switch (city)
                {
                    case "sofia": commission = sales * Sofia[1]; break;
                    case "varna": commission = sales * Varna[1]; break;
                    case "plovdiv": commission = sales * Plovdiv[1]; break;
                    default: Console.WriteLine("error"); break;
                }
                break;
            
            case > 1000 and <= 10000:
                switch (city)
                {
                    case "sofia": commission = sales * Sofia[2]; break;
                    case "varna": commission = sales * Varna[2]; break;
                    case "plovdiv": commission = sales * Plovdiv[2]; break;
                    default: Console.WriteLine("error"); break;
                }
                break;
            
            case > 10000:
                switch (city)
                {
                    case "sofia": commission = sales * Sofia[3]; break;
                    case "varna": commission = sales * Varna[3]; break;
                    case "plovdiv": commission = sales * Plovdiv[3]; break;
                    default: Console.WriteLine("error"); break;
                }
                break;
            
            default:
                Console.WriteLine("error");
                break;
        }

        if (commission != 0)
            Console.WriteLine($"{commission:f2}");
    }
}