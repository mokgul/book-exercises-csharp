using System.Text.RegularExpressions;

namespace Chapter15;

public static class Exercise07
{
    public static void ReplaceWholeWordInLargeFile(string inputFile, string outputFile)
    {
        var regex = new Regex(@"\bstart\b");

        using (var reader = new StreamReader(inputFile))
        using (var writer = new StreamWriter(outputFile))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string replacedLine = regex.Replace(line, "finish");
                writer.WriteLine(replacedLine);
            }
        }
    }
}