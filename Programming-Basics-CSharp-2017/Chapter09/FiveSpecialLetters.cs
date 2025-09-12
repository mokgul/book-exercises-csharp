namespace Chapter09;

public static class FiveSpecialLetters
{
    static Dictionary<char, int> weights = new Dictionary<char, int>()
    {
        { 'a', 5 },
        { 'b', -12 },
        { 'c', 47 },
        { 'd', 7 },
        { 'e', -32 }
    };

    public static void Solve()
    {
        int start = int.Parse(Console.ReadLine());
        int end = int.Parse(Console.ReadLine());

        char[] letters = { 'a', 'b', 'c', 'd', 'e' };
        bool found = false;

        for (int i = 0; i < letters.Length; i++)
        {
            for (int j = 0; j < letters.Length; j++)
            {
                for (int k = 0; k < letters.Length; k++)
                {
                    for (int l = 0; l < letters.Length; l++)
                    {
                        for (int m = 0; m < letters.Length; m++)
                        {
                            string word = new string(new char[] { letters[i], letters[j], letters[k], letters[l], letters[m] });

                            int weight = GetWeight(word);

                            if (weight >= start && weight <= end)
                            {
                                Console.Write(word + " ");
                                found = true;
                            }
                        }
                    }
                }
            }
        }

        if (!found)
        {
            Console.WriteLine("No");
        }
    }

    private static int GetWeight(string word)
    {
        // премахване на повторения отдясно наляво
        string filtered = "";
        foreach (char c in word)
        {
            if (!filtered.Contains(c))
            {
                filtered += c;
            }
        }

        int total = 0;
        for (int i = 0; i < filtered.Length; i++)
        {
            total += (i + 1) * weights[filtered[i]];
        }
        return total;
    }
}