namespace Chapter08;

public static class SumOfNumbers
{
    public static void Calculate()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        string result = (a, b, c) switch
        {
            var (x, y, z) when x + y == z => $"{x} + {y} + {z}",
            var (x, y, z) when x + z == y => $"{x} + {z} + {y}",
            var (x, y, z) when y + z == x => $"{y} + {z} + {x}",
            _ => "No"
        };
        Console.WriteLine(result);
    }
}