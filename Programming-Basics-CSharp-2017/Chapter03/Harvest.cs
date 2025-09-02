namespace Chapter03;

public static class Harvest
{
    public static void CalculateWineVolume()
    {
        int vineArea = int.Parse(Console.ReadLine());
        double grapePerSquareMeter = double.Parse(Console.ReadLine());
        int neededAmountWine = int.Parse(Console.ReadLine());
        int workersQuantity = int.Parse(Console.ReadLine());

        double grapesForWine = (vineArea * grapePerSquareMeter) * 0.40;
        double wineProduced  = grapesForWine / 2.5;

        if (wineProduced < neededAmountWine)
        {
            Console.WriteLine($"It will be a tough winter! More {Math.Floor(neededAmountWine - wineProduced)} liters of wine needed.");
        }
        else
        {
            double extraWine = neededAmountWine - wineProduced;
            double literPerPerson = extraWine / workersQuantity;
            Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(wineProduced)} liters.");
            Console.WriteLine($"{Math.Floor(extraWine)} liters left. -> {Math.Floor(literPerPerson)} liters per person.");
        }
    }
}