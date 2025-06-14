namespace Chapter05;

public static class Exercise04
{
    public static void SortNumbersIfStatements(double a, double b, double c)
    {
        string output = "Numbers sorted ascending: {0}, {1}, {2}";
        Console.WriteLine("Sorting numbers using if statements:");
        if (a > b && a > c)
        {
            if(b > c)
                Console.WriteLine(output, a, b, c);
            else
                Console.WriteLine(output, a, c, b);
        }
        else if (b > c && b > a)
        {
            if(c > a)
                Console.WriteLine(output, b, c, a);
            else
                Console.WriteLine(output, b, a, c);
        }
        else
        {
            if(a > b)
                Console.WriteLine(output, c, a, b);
            else
                Console.WriteLine(output, c, b, a);
        }
    }

    public static void SortingNumbersUsingMathLibrary(double a, double b, double c)
    {
        double biggest = Math.Max(a, Math.Max(b, c));
        double smallest = Math.Min(a, Math.Min(b, c));
        double middle = a + b + c - biggest - smallest;
        Console.WriteLine("Numbers sorted ascending: {0}, {1}, {2}", biggest, middle, smallest);
    }

    public static void SortingNumbersUsingArray(double a, double b, double c)
    {
        double[] array = [a, b, c];
        Array.Sort(array);
        array = array.Reverse().ToArray();
        Console.WriteLine("Numbers sorted ascending: {0}, {1}, {2}", array[0], array[1], array[2]);
    }
}