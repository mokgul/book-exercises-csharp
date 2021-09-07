namespace Chapter05;

public class Histogram
{
    public static void Calculate()
    {
        double[] counters = [0, 0, 0, 0, 0];
        int qty = int.Parse(Console.ReadLine());
        for (int i = 0; i < qty; i++)
        {
            int current =  int.Parse(Console.ReadLine());
            switch (current)
            {
                case < 200: counters[0]++; break;
                case < 400: counters[1]++; break;
                case < 600: counters[2]++; break;
                case < 800: counters[3]++; break;
                case <= 1000: counters[4]++; break;
            }
        }
        counters = counters.Select(x => (x / (double)qty) * 100).ToArray();
        foreach (double counter in counters)
        {
            Console.WriteLine($"{counter:F2}%");
        }
    }
}