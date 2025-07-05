namespace Chapter13;

public static class Exercise14
{
    public static void ReverseWordOrder()
    {
        string text = "C# is not C++ and PHP is not Delphi";
        var parts = text.Split(' ').Reverse();
        Console.WriteLine(string.Join(" ", parts));
    }
}