namespace Chapter13;

public static class Exercise22
{
    public static void CountLettersInString()
    {
        string input = Console.ReadLine();
        
        Dictionary<char, int> letters = new Dictionary<char, int>();
        foreach (char c in input)
        {
            if (!letters.ContainsKey(c))
            {
                letters.Add(c, 0);
            }
            else
            {
                letters[c]++;
            }
        }

        letters = letters.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
        foreach (KeyValuePair<char, int> pair in letters)
        {
            Console.WriteLine("{0}: {1}", pair.Key, pair.Value);
        }
    }
}