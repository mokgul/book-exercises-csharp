namespace Chapter09;

public static class BullsAndCows
{
    public static void Solve()
    {
        string secret = Console.ReadLine();
        int targetBulls = int.Parse(Console.ReadLine());
        int targetCows = int.Parse(Console.ReadLine());

        List<string> results = new List<string>();

        for (int guess = 1111; guess <= 9999; guess++)
        {
            string guessStr = guess.ToString();

            // всяка цифра трябва да е [1..9]
            if (guessStr.Contains("0")) continue;

            int bulls, cows;
            CountBullsAndCows(secret, guessStr, out bulls, out cows);

            if (bulls == targetBulls && cows == targetCows)
            {
                results.Add(guessStr);
            }
        }

        if (results.Count == 0)
            Console.WriteLine("No");
        else
            Console.WriteLine(string.Join(" ", results));
    }
    
    static void CountBullsAndCows(string secret, string guess, out int bulls, out int cows)
    {
        bulls = 0;
        cows = 0;

        bool[] usedSecret = new bool[4];
        bool[] usedGuess = new bool[4];
        
        for (int i = 0; i < 4; i++)
        {
            if (secret[i] == guess[i])
            {
                bulls++;
                usedSecret[i] = true;
                usedGuess[i] = true;
            }
        }
        
        for (int i = 0; i < 4; i++)
        {
            if (usedGuess[i]) continue;

            for (int j = 0; j < 4; j++)
            {
                if (!usedSecret[j] && guess[i] == secret[j])
                {
                    cows++;
                    usedSecret[j] = true;
                    usedGuess[i] = true;
                    break;
                }
            }
        }
    }
}