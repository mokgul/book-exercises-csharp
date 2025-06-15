namespace Chapter06;

public static class Exercise12
{
    public static void DecimalToBinaryUsingLoops(int number)
    {
        string binary = string.Empty;
        while (number != 0)
        {
            int remainder = number % 2;
            binary += remainder == 0 ? "0" : "1";
            number /= 2;
        }
        Console.WriteLine($"The binary representation of {number} is {binary}");
    }

    public static void DecimalToBinaryUsingInternalLibrary(int number)
    {
        string binary = Convert.ToString(number, 2);
        Console.WriteLine($"The binary representation of {number} is {binary}");
    }

    public static void DecimalToBinaryUsingStringFormat(int number)
    {
        Console.WriteLine($"The binary representation of {number} is {number:b8}");
    }
}