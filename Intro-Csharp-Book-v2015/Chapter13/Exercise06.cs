using System.Text.RegularExpressions;

namespace Chapter13;

public static class Exercise06
{
    public static void UpperCaseSubstrings(string a)
    {
        var pattern = @"(?i)<upcase>(.*?)</upcase>";
        var result = Regex.Replace(a, pattern, m => m.Groups[1].Value.ToUpper(), RegexOptions.Singleline);
        Console.WriteLine(result);
    }
}