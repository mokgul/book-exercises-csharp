namespace Chapter08;

public static class Exercise04
{
    public static void DecimalToBinary(int number)
    {
        string output = string.Empty;
        while (number > 0)
        {
            output += number % 2;
            number /= 2;
        }
        Console.WriteLine(output);
    }
}