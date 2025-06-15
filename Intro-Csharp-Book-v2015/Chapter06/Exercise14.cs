namespace Chapter06;

public static class Exercise14
{
    public static void ConvertDecimalToHexadecimalUsingInternalLibrary(int number)
    {
        string hexadecimal = Convert.ToString(number, 16);
        Console.WriteLine($"0x{hexadecimal}");
    }

    public static void ConvertDecimalToHexadecimalUsingStringFormat(int number)
    {
        Console.WriteLine($"0x{number:X}");
    }

    public static void ConvertDecimalToHexadecimalUsingLoops(int number)
    {
        string hexChars = "0123456789ABCDEF";
        string result = "";

        while (number > 0)
        {
            int remainder = number % 16;
            result = hexChars[remainder] + result;
            number /= 16;
        }
        Console.WriteLine($"0x{result}");
    }
}