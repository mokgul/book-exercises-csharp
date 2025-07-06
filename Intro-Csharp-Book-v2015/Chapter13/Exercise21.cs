namespace Chapter13;

public static class Exercise21
{
    public static void ExtractPalindromes()
    {
        string text =
            "Anna went to see her civic group in noon. She met Bob and Eve there. \"Wow,\" she said, \"Madam, level up your kayak!\" A man, a plan, a canal: Panama.";
        string[] words = text.Split(' ').Select(x => x.Trim('.', ',', '!', ':', '"')).ToArray();
        foreach (string word in words)
        {
            var reversedWord = string.Join("",word.Reverse());
            if (word.Equals(reversedWord, StringComparison.InvariantCultureIgnoreCase))
            {
                Console.WriteLine($"{word}");
            }
        }
    }
}