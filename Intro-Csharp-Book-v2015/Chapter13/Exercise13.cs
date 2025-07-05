using System.Text.RegularExpressions;

namespace Chapter13;

public static class Exercise13
{
    public static void ExtractUrlComponents(string url)
    {
        var pattern = @"^([a-zA-Z]+):\/\/([^\/]+)\/(.+)$";

        Match match = Regex.Match(url, pattern);
        if (match.Success)
        {
            Console.WriteLine("Protocol: " + match.Groups[1].Value);
            Console.WriteLine("Server:   " + match.Groups[2].Value);
            Console.WriteLine("Resource:   " + match.Groups[3].Value);
        }
        else
        {
            Console.WriteLine("Invalid URL");
        }
    }
}