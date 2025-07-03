namespace Chapter13;

public static class Exercise02
{
    public static void StringReverse(string a)
    {
        for (var i = a.Length - 1; i >= 0; i--)
            Console.Write(a[i]);
        Console.WriteLine();
    }
}