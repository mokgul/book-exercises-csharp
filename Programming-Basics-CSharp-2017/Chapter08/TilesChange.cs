namespace Chapter08;

public static class TilesChange
{
    public static void Solve()
    {
        double money = double.Parse(Console.ReadLine());
        double floorWidth = double.Parse(Console.ReadLine());
        double floorHeight = double.Parse(Console.ReadLine());
        double tileSide = double.Parse(Console.ReadLine());
        double tileHeight = double.Parse(Console.ReadLine());
        double tilePrice = double.Parse(Console.ReadLine());
        double workerPrice = double.Parse(Console.ReadLine());
        
        double floorArea = floorWidth * floorHeight;
        double tileArea = (tileSide * tileHeight) / 2.0;
        int tilesNeeded = (int)Math.Ceiling(floorArea / tileArea) + 5;
        double total = tilesNeeded * tilePrice + workerPrice;
        if (total <= money)
        {
            Console.WriteLine($"{(money - total):f2} lv left.");
        }
        else
        {
            Console.WriteLine($"You'll need {(total - money):f2} lv more.");
        }
    }
}