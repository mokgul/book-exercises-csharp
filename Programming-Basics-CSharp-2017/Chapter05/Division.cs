namespace Chapter05;

public static class Division
{
    public static void Calculate()
    {
        double[] counters = [0, 0, 0];
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(Console.ReadLine());
            if (num % 2 == 0) counters[0]++;
            if (num % 3 == 0) counters[1]++;
            if (num % 4 == 0) counters[2]++;
        }
        counters = counters.Select(x => (x / (double)n) * 100).ToArray();

        Console.WriteLine($"{counters[0]:f2}%");
        Console.WriteLine($"{counters[1]:f2}%");
        Console.WriteLine($"{counters[2]:f2}%");

    }
}