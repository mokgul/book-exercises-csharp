namespace Chapter13;

public static class Exercise07
{
    public static void ReadAndFillString()
    {
        var str =  Console.ReadLine();
        if (str.Length < 20)
        {
            for (int i = str.Length; i <= 20; i++)
            {
                str += "*";
            }
        }
        Console.WriteLine(str);
    }
}