namespace Chapter06;

public static class Exercise15
{
    public static void ConvertHexadecimalToDecimalUsingInternalLibrary(string hexadecimal)
    {

        int number = Convert.ToInt32(hexadecimal, 16);
        Console.WriteLine($"The decimal representation of {hexadecimal} is {number}");
    }

    public static void ConvertHexadecimalToDecimalUsingStringFormat(int hexadecimal)
    {
        Console.WriteLine($"The decimal representation of 0x{hexadecimal:X} is {hexadecimal:D}");
    }

    public static void ConvertHexadecimalToDecimalUsingNoLibrary(string hexadecimal)
    {
        Dictionary<char, int> dictionary = new Dictionary<char, int>()
        {
            { '0', 0 }, { '1', 1 }, { '2', 2 }, { '3', 3 },
            { '4', 4 }, { '5', 5 }, { '6', 6 }, { '7', 7 },
            { '8', 8 }, { '9', 9 }, { 'A', 10 }, { 'B', 11 },
            { 'C', 12 }, { 'D', 13 }, { 'E', 14 }, { 'F', 15 }
        };

        string number = hexadecimal.Split('x').Last();
        int result = 0;
        for (int i = 0; i < number.Length; i++)
        {
            result += (dictionary[number[^(i + 1)]] * (int)Math.Pow(16, i));
        }
        Console.WriteLine($"The decimal representation of {hexadecimal} is {result}");
    }
}