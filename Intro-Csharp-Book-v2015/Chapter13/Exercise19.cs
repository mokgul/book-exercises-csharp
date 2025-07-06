using System.Text.RegularExpressions;

namespace Chapter13;

public static class Exercise19
{
    public static void ExtractEmails()
    {
        string text = "Please contact us by phone (+359 222 222 222) or by email at\nexample@abv.bg or at baj.ivan@yahoo.co.uk. This is not email:\ntest@test. This also: @gmail.com. Neither this: a@a.b.";
        string pattern = @"\b[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}\b";
        
        MatchCollection matches = Regex.Matches(text, pattern);
        foreach (Match match in matches)
        {
            Console.WriteLine($"{match.Value}");
        }
    }
}