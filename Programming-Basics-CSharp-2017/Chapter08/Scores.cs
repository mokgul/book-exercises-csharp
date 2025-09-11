namespace Chapter08;

public static class Scores
{
    public static void Print()
    {
        int studentsQty = int.Parse(Console.ReadLine());
        double[] counters = [0, 0, 0, 0];
        double average = 0.0;

        for (int i = 0; i < studentsQty; i++)
        {
            double current = double.Parse(Console.ReadLine());
            switch (current)
            {
                case var a when a >= 2 && a < 3: counters[0]++; break;
                case var a when a >= 3 && a < 4: counters[1]++; break;
                case var a when a >= 4 && a < 5: counters[2]++; break;
                case var a when a >= 5: counters[3]++; break;
                default: Console.WriteLine("Invalid score"); break;
            }
            average += current;
        }
        counters = counters.Select(x => (x / studentsQty) * 100).ToArray();
        average /= studentsQty;
        Console.WriteLine($"Top students: {counters[3]:f2}%.");
        Console.WriteLine($"Between 4.00 and 4.99: {counters[2]:f2}%.");
        Console.WriteLine($"Between 3.00 and 3.99: {counters[1]:f2}%.");
        Console.WriteLine($"Fail: {counters[0]:f2}%.");
        Console.WriteLine($"Average: {average:F2}");
    }
}