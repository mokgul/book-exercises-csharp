using System.Text.RegularExpressions;

namespace Chapter13;

public static class Exercise26
{
    public static void ExtraxtTextFromHtml()
    {
        string html = "" +
                      "<html>\n" +
                      "<head><title>News</title></head>\n" +
                      "<body><p><a href=\"http://softuni.bg\">Software University\n" +
                      "(SoftUni)</a> provides <b>high-quality education</b> for\n" +
                      "software engineers, profession and job.</p></body>\n" +
                      "</html>";
        
        // Extract title
        var titleMatch = Regex.Match(html, @"<title>(.*?)</title>", RegexOptions.Singleline | RegexOptions.IgnoreCase);
        string title = titleMatch.Success ? titleMatch.Groups[1].Value.Trim() : "";

        // Extract body content
        var bodyMatch = Regex.Match(html, @"<body.*?>(.*?)</body>", RegexOptions.Singleline | RegexOptions.IgnoreCase);
        string bodyContent = bodyMatch.Success ? bodyMatch.Groups[1].Value : "";

        // Remove all HTML tags from body
        string bodyText = Regex.Replace(bodyContent, "<.*?>", "").Trim();

        Console.WriteLine("Title: " + title);
        Console.WriteLine("Body: " + bodyText);
    }
}