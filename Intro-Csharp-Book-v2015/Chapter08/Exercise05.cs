namespace Chapter08;

public static class Exercise05
{
    public static void BinaryToDecimal(string binary)
    {
        int num = 0;
        for (int i = 0; i < binary.Length; i++)
        {
            int n = Convert.ToInt32(binary[i].ToString());
            num += n * (int)Math.Pow(2, binary.Length - i - 1);
        }
        Console.WriteLine(num);
    }
}