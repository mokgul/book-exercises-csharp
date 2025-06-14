namespace Chapter05;

public static class Exercise06
{
    public static void SolveQuadricEquation()
    {
        const int count = 3;
        double[] nums = new double[count];

        for (int i = 0; i < count; i++)
        {
            Console.WriteLine($"Please enter coefficient {i + 1}/{count}:");
            while (!double.TryParse(Console.ReadLine(), out nums[i]))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
                Console.Write($"Please enter coefficient {i}: ");
            }
        }

        (double a, double b, double c) = (nums[0], nums[1], nums[2]);
        double discriminant = Math.Pow(b, 2) - 4.0 * a * c;
        double x1 = 0;
        double x2 = 0;
        switch(discriminant)
        {
            case 0:
                x1 = x2 = -b / (2.0 * a);
                break;

            case > 0:
                x1 = (-b + Math.Sqrt(discriminant)) / (2.0 * a);
                x2 = (-b - Math.Sqrt(discriminant)) / (2.0 * a);
                break;

            case < 0:
                Console.WriteLine("Complex roots.");
                // Handle complex roots if needed, or set x1/x2 to NaN
                x1 = x2 = double.NaN;
                break;
        }
        Console.WriteLine($"x1 = {x1}, x2 = {x2}");
    }
}