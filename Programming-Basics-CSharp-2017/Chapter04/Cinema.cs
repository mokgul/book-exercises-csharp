namespace Chapter04;

public static class Cinema
{
    public static void CalculatePrice()
    {
        string type = Console.ReadLine();
        int rows = int.Parse(Console.ReadLine());
        int cols = int.Parse(Console.ReadLine());
        
        double price = 0;
        switch (type)
        {
            case "Premiere": price = rows * cols * 12.00; break;
            case "Normal": price = rows * cols * 7.50; break;
            case "Discount": price = rows * cols * 5.00; break;
            default: Console.WriteLine("error"); break;
        }
        Console.WriteLine("{0:F2}", price);
    }
}