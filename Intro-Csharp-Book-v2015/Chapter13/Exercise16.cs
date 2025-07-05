using System.Text.RegularExpressions;

namespace Chapter13;

public static class Exercise16
{
    public static void ReplaceTagsInHtml()
    {
        string html = @"<p>Please visit <a href=""http://softuni.bg"">our site</a> to
            choose a software engineering training course. Also visit <a
            href=""http://softuni.bg/forum"">our forum</a> to discuss the
            courses.</p>";

        string pattern = @"<a\s+href=""(.*?)"">(.*?)</a>";
        string replacement = "[URL=$1]$2[/URL]";

        string result = Regex.Replace(html, pattern, replacement, RegexOptions.IgnoreCase);

        Console.WriteLine("Result:\n");
        Console.WriteLine(result);
    }
}