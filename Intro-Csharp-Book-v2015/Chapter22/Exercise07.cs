using System.Globalization;

namespace Chapter22;

public static class Exercise07
{
    public static void UppercaseEveryWord(string s)
    {
        string result = new CultureInfo("en-US", false).TextInfo.ToTitleCase(s);
        Console.WriteLine(result);
    }
}