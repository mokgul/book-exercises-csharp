namespace Chapter08;

public static class Exercise02
{
    public static void BinaryToHexadecimalAndDecimal(string binary)
    {
        while (binary.Length % 4 != 0)
        {
            binary = "0" + binary;
        }

        string output = string.Empty;
        for (int i = 0; i < binary.Length; i += 4)
        {
            string temp = binary.Substring(i, 4);
            int number = ConvertToDecimal(temp);
            output += Convert.ToString(number, 16);
        }

        long decimalOutput = 0L;
        for (int i = 0; i < binary.Length; i++)
        {
            int current = int.Parse(binary[i].ToString());
            decimalOutput += current * (int)Math.Pow(2, binary.Length - i - 1);
        }
        Console.WriteLine($"Hexadecimal: {output.ToUpper()}");
        Console.WriteLine($"Decimal: {decimalOutput}");

    }

    static int ConvertToDecimal(string binary)
    {
        int number = Convert.ToInt32(binary, 2);
        return number;
    }
}