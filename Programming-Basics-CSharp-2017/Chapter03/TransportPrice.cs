namespace Chapter03;

public static class TransportPrice
{
    public static void Calculate()
    {
        double taxi  = 0;
        double bus   = 0;
        double train = 0;
        double price = 0;

        int distance = int.Parse(Console.ReadLine());
        string time  = Console.ReadLine();

        if (time == "day")
        {
            taxi += 0.79;
            bus += 0.09;
            train += 0.06;
        }
        else
        {
            taxi += 0.90;
            bus += 0.09;
            train += 0.06;
        }

        if (distance < 20)
        {
            price = distance * taxi + 0.70;
        }
        else if (distance < 100)
        {
            price = distance * bus;
        }
        else
        {
            price = distance * train;
        }
        Console.WriteLine("{0:0.00}",price);
    }
}