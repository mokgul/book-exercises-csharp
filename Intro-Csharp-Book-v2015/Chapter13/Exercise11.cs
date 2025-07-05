namespace Chapter13;

public static class Exercise11
{
    public static void ReplaceWords(string[] forbiddenKeywords)
    {
        string text =
            "Microsoft announced its next generation C# compiler today. It\nuses advanced parser and special optimizer for the Microsoft CLR.";
        foreach (string word in forbiddenKeywords)
        {
            if (text.Contains(word))
            {
                text = text.Replace(word, new string('*', word.Length));
            }
        }
        Console.WriteLine(text);
    }
}