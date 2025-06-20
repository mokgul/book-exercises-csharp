namespace Chapter08;

public static class Exercise11
{
    private static readonly Dictionary<char, int> RomanNumerals = new Dictionary<char, int>()
    {
        { 'I', 1 }, { 'V', 5 }, { 'X', 10 }, { 'L', 50 }, { 'C', 100 }, { 'D', 500 }, { 'M', 1000 }
    };

    public static void RomanNumeralsToArabic(string romanNumerals)
    {
        int num = 0;
        int previousValue = 0;
        for (int i = 0; i < romanNumerals.Length; i++)
        {
            int current = RomanNumerals[romanNumerals[i]];

            if (current >= previousValue)
            {
                num += current;
                previousValue = current;
            }
            else
            {
                num -= current;
                previousValue = current;
            }
        }
        Console.WriteLine(num);
    }
}