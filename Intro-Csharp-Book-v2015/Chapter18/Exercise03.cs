namespace Chapter18;

public static class Exercise03
{
    public static void CountWords()
    {
        string text = "This is the TEXT. Text, text, text - THIS TEXT! Is this the text?";
        string[] words = text.Split([' ', '!', '-', '.', ',' , '?'], StringSplitOptions.RemoveEmptyEntries);
        
        Dictionary<string, int> counts = new Dictionary<string, int>();
        foreach (string word in words)
        {
            if (!counts.ContainsKey(word.ToLower()))
            {
                counts[word.ToLower()] = 1;
            }
            else
            {
                counts[word.ToLower()]++;
            }
        }

        foreach (var pair in counts.OrderBy(p => p.Value))
        {
            Console.WriteLine($"{pair.Key}: {pair.Value}");
        }
    }
}