namespace Chapter08;

public static class Exercise10
{
    public static void HornersMethod(string binary)
    {
        int sum = int.Parse(binary[0].ToString());

        for (int i = 1; i < binary.Length; i++)
        {
            sum = sum * 2 + int.Parse(binary[i].ToString());
        }

        Console.WriteLine(sum);
    }
}