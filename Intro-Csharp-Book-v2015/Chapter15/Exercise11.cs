using System.Text.RegularExpressions;

namespace Chapter15;

public static class Exercise11
{
    public static void DeleteWords()
    {
        string inputPath = "input.txt";
        string outputPath = "output.txt";

        try
        {
            string content = File.ReadAllText(inputPath);

            
            string pattern = @"\btest\w*\b";
            string result = Regex.Replace(content, pattern, "", RegexOptions.IgnoreCase);
            
            result = Regex.Replace(result, @"\s+", " ").Trim();

            File.WriteAllText(outputPath, result);
            Console.WriteLine("Думите започващи с 'test' бяха премахнати.");
        }
        catch (IOException ex)
        {
            Console.WriteLine("Грешка при достъпа до файла: " + ex.Message);
        }
    }
}