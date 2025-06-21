namespace Chapter09;

public static class Exercise07
{
    public static string ReverseNumber(int number)
    {
        char[] arr = number.ToString().ToCharArray().Reverse().ToArray();
        return string.Join("", arr);
    }
}