using System.Text.RegularExpressions;

namespace Chapter24;

public static class Exercise01
{
    public static void ReadMails()
    {
        string inputFile = "mails.txt";
        string outputFile = "validMails.txt";

        // username: [a-zA-Z_]+
        // host: [a-z]+
        // domain: [a-z]{2,4}
        string pattern = @"^([A-Z][a-z]+)\s+([A-Z][a-z]+)\s+([a-zA-Z_]+)@([a-z]+)\.([a-z]{2,4})$";
        Regex regex = new Regex(pattern);

        using (StreamReader reader = new StreamReader(inputFile))
        using (StreamWriter writer = new StreamWriter(outputFile))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                if (regex.IsMatch(line))
                {
                    writer.WriteLine(line);
                }
            }
        }

        Console.WriteLine("Validation complete. Check 'validMails.txt'");
    }
}