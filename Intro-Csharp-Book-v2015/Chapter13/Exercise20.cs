using System.Text.RegularExpressions;

namespace Chapter13;

public static class Exercise20
{
    public static void ExtractDates()
    {
        string text =
            "I was born at 14.06.1980. My sister was born at 3.7.1984. In\n5/1999 I graduated my high school. The law says (see section\n7.3.12) that we are allowed to do this (section 7.4.2.9).";
        string pattern = @"\b\d{1,2}\.\d{1,2}\.\d{4}\b";
        
        MatchCollection matches = Regex.Matches(text, pattern);
        foreach (Match match in matches)
        {
            Console.WriteLine($"{match.Value}");
        }
    }
}