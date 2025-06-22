namespace Chapter10;

public static class Exercise05
{
    public static void CombinationsWords(string[] words)
    {
        string[] subset = new string[words.Length];
        GenerateSubsets(words, 0, 0, subset);
    }

    static void GenerateSubsets(string[] words, int index, int subsetSize, string[] subset)
    {
        if (index == words.Length)
        {
            Console.Write("(");
            for (int i = 0; i < subsetSize; i++)
            {
                Console.Write(subset[i]);
                if (i < subsetSize - 1) Console.Write(" ");
            }
            Console.WriteLine(")");
            return;
        }

        // Избираме текущия елемент
        subset[subsetSize] = words[index];
        GenerateSubsets(words, index + 1, subsetSize + 1, subset);

        // Пропускаме текущия елемент
        GenerateSubsets(words, index + 1, subsetSize, subset);
    }
}