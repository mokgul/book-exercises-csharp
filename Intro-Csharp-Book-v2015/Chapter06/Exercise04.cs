namespace Chapter06;

public static class Exercise04
{
    public static void PrintAllPlayingCards()
    {
        Dictionary<int, char> dict = new Dictionary<int, char>()
        {
            { 4, '\u2660' },
            { 3, '\u2665' },
            { 2, '\u2666' },
            { 1, '\u2663' }
        };

        int counter = 4;
        while(counter != 0)
        {
            for (int i = 2; i < 15; i++)
            {
                string output = i switch
                {
                    _ when i < 11 => $"{i} {dict[counter]} | ",
                    11 => $"J {dict[counter]} | ",
                    12 => $"Q {dict[counter]} | ",
                    13 => $"K {dict[counter]} | ",
                    14 => $"A {dict[counter]} | "
                };
                Console.Write(output);
            }
            Console.WriteLine();
            counter--;
        }
    }
}