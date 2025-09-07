namespace Chapter05;

public static class LatinAlphabet
{
    public static void Print()
    {
        for (int i = 'a'; i <= 'z'; i++)
        {
            Console.WriteLine(i);
        }
    }

    public static void SumVowelValues()
    {
        string text = Console.ReadLine();
        int sum = 0;

        foreach (char c in text)
        {
            sum += c switch
            {
                'a' => 1,
                'e' => 2,
                'i' => 3,
                'o' => 4,
                'u' => 5,
                _ => 0
            };
        }
        Console.WriteLine(sum);
    }
}