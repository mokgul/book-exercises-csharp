namespace Chapter08;

public static class ChristmasHat
{
    public static void Print()
    {
        int n = int.Parse(Console.ReadLine());

        int width = 4 * n + 1;
        
        Console.WriteLine(new string('.', 2 * n) + "/|\\" + new string('.', 2 * n));
        Console.WriteLine(new string('.', 2 * n) + "\\|/" + new string('.', 2 * n));
        Console.WriteLine(new string('.', 2 * n) + "***" + new string('.', 2 * n));
        
        for (int i = 1; i <= n; i++)
        {
            int dots = 2 * n - i;
            string middle = "*" + new string('-', i) + "*" + new string('-', i) + "*";
            Console.WriteLine(new string('.', dots) + middle + new string('.', dots));
        }
        
        Console.WriteLine(new string('*', width));
        for (int i = 0; i < 2 * n; i++)
        {
            Console.Write("*.");
        }
        Console.WriteLine("*");
        Console.WriteLine(new string('*', width));
    }
}