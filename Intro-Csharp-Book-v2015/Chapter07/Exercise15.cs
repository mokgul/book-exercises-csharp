namespace Chapter07;

public static class Exercise15
{
    public static void PrintIndexOfChars()
    {
        char[] alphabet = new char[26];
        int index = 0;
        for (char c = 'a'; c <= 'z'; c++)
        {
            alphabet[index++] = c;
        }

        Console.WriteLine("Enter a word: ");
        string word = Console.ReadLine().ToLower();
        for (int i = 0; i < word.Length; i++)
        {
            int currentLetter = word[i];
            for (int j = 0; j < alphabet.Length; j++)
            {
                if (currentLetter == alphabet[j])
                {
                    Console.Write($"{j} ");
                }
            }
        }
    }
}