namespace Chapter06;

public static class Exercise13
{
    public static void BinaryToDecimalUsingInternalLibrary(string binary)
    {
        int number = Convert.ToInt32(binary, 2);
        Console.WriteLine($"The decimal representation of {binary} is {number}");
    }

    public static void BinaryToDecimalUsingLoops(string binary)
    {
        int number = 0;
        for (int i = 0; i < binary.Length; i++)
        {
            if (int.Parse(binary[^(i+1)].ToString()) == 1)
            {
                number += (int)Math.Pow(2, i);
            }
        }
        Console.WriteLine($"The decimal representation of {binary} is {number}");
    }

    public static void BinaryToDecimalUsingStringFormat(int binary)
    {
        Console.WriteLine($"The decimal representation of {binary:b8} is {binary:D}");
    }
}