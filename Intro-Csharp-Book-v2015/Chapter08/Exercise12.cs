namespace Chapter08;

public static class Exercise12
{
    private static readonly Dictionary<int, string> ArabicToRoman = new Dictionary<int, string>()
    {
        { 1000, "M" },
        { 900, "CM" },
        { 500, "D" },
        { 400, "CD" },
        { 100, "C" },
        { 90, "XC" },
        { 50, "L" },
        { 40, "XL" },
        { 10, "X" },
        { 9, "IX" },
        { 5, "V" },
        { 4, "IV" },
        { 1, "I" },
    };

    public static void ArabicNumeralsToRoman(int number)
    {
        string roman = string.Empty;

        foreach (var kvp in ArabicToRoman)
        {
            while (number >= kvp.Key)
            {
                roman += kvp.Value;
                number -= kvp.Key;
            }
        }

        Console.WriteLine(roman);
    }

}