namespace Chapter22;

public static class Exercise07
{
    public static void UppercaseEveryWord(string s)
    {
        string[] words = s.Split(' ').Select(w => w.ToLower()).ToArray();
        words = words.Select(w => w[0].ToString().ToUpper() + w.Substring(1)).ToArray();
        foreach (var word in words)
        {
            Console.Write(word + " ");
        }
    }
}