namespace Chapter08;

public static class Exercise03
{
    public static void HexadecimalToBinaryAndDecimal(int hexadecimal)
    {
        string binary = Convert.ToString(hexadecimal, 2);
        Console.WriteLine(binary);

        string hex = Convert.ToString(hexadecimal, 16);
        Console.WriteLine(hex);
    }
}