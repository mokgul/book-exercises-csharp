namespace Chapter08;

public static class Exercise08
{
    public static void HexadecimalToBinary(int num)
    {
        string binary = Convert.ToString(num, 2);
        Console.WriteLine(binary);
    }
}