namespace Chapter08;

public static class Exercise06
{
    public static void DecimalToHexadecimal(int num)
    {
        string output = string.Empty;
        while (num > 0)
        {
            output += num % 16;
            num /= 16;
        }
        Console.WriteLine(output);
    }
}