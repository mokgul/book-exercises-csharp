namespace Chapter02;

public static class Tiles
{
    public static void Repair()
    {
        int areaWidth = int.Parse(Console.ReadLine());
        double tileWidth = double.Parse(Console.ReadLine());
        double tileHeight = double.Parse(Console.ReadLine());
        int benchWidth =  int.Parse(Console.ReadLine());
        int benchHeight = int.Parse(Console.ReadLine());
        
        int totalArea = areaWidth * areaWidth -  benchWidth * benchHeight;
        double tileArea = tileWidth * tileHeight;
        double tiles = totalArea / tileArea;
        double timeNeeded = tiles * 0.2;
        Console.WriteLine($"Time needed: {timeNeeded}");
    }
}