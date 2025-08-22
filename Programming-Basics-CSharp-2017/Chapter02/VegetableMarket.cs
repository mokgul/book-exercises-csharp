namespace Chapter02;

public static class VegetableMarket
{
    public static void SolveTask()
    {
        Console.WriteLine("Enter price for the vegetables:");
        double priceV = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter price for the fruits:");
        double priceF = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter quantity for the vegetables:");
        double quantityV = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter quantity for the fruits:");
        double quantityF = double.Parse(Console.ReadLine());

        double euroRate = 1.94;
        double result = (priceV * quantityV + priceF * quantityF) / euroRate;
        Console.WriteLine($"{result:f2}");
    }
}