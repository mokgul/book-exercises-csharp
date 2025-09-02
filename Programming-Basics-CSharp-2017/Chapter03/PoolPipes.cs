namespace Chapter03;

public static class PoolPipes
{
    public static void CalculateVolume()
    {
        int volume = int.Parse(Console.ReadLine());
        int firstPipe = int.Parse(Console.ReadLine());
        int secondPipe = int.Parse(Console.ReadLine());
        double hours = double.Parse(Console.ReadLine());
        
        double firstPipeVolume = firstPipe * hours;
        double secondPipeVolume = secondPipe * hours;
        double totalVolume = firstPipeVolume + secondPipeVolume;

        if (totalVolume > volume)
        {
            Console.WriteLine($"For {hours} hours the pool overflows with {totalVolume - volume} liters.");
        }
        else
        {
            double fillPercent = totalVolume * 100 / volume;
            double firstPipePercent = firstPipeVolume * 100 / totalVolume;
            double secondPipePercent = secondPipeVolume * 100 / totalVolume;
            Console.WriteLine($"The pool is {fillPercent}% full. Pipe 1: {firstPipePercent:f0}%. Pipe 2: {secondPipePercent:f0}%.");
        }
    }
}