namespace Chapter08;

public static class Exercise09
{
    public static void BinaryToHexadecimal(string binary)
    {
        int num = 0;
        for (int i = 0; i < binary.Length; i++)
        {
            int n = Convert.ToInt32(binary[i].ToString());
            num += n * (int)Math.Pow(2, binary.Length - i - 1);
        }
        string hex = num.ToString("X");
        Console.WriteLine(hex);
    }
}