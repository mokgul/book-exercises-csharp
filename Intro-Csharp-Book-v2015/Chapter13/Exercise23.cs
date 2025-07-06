namespace Chapter13;

public static class Exercise23
{
    public static void CountWordsInString()
    {
        string input = Console.ReadLine();
        
        string[] words = input.Split(' ').Select(x => x.Trim('.', ',', '!', ':', '"')).ToArray();
        Dictionary<string, int> wordCount = new Dictionary<string, int>();

        foreach (string word in words)
        {
            if (!wordCount.ContainsKey(word))
            {
                wordCount.Add(word, 0);
            }
            else
            {
                wordCount[word]++;
            }
        }
        
        wordCount = wordCount.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
        foreach (KeyValuePair<string, int> pair in wordCount)
        {
            Console.WriteLine("{0}: {1}", pair.Key, pair.Value);
        }
    }
}