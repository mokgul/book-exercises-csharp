namespace Chapter05;

public static class Exercise11
{
    private static readonly Dictionary<int, string> Numbers = new Dictionary<int, string>()
{
    { 0, "нула" },
    { 1, "едно" },
    { 2, "две" },
    { 3, "три" },
    { 4, "четири" },
    { 5, "пет" },
    { 6, "шест" },
    { 7, "седем" },
    { 8, "осем" },
    { 9, "девет" },
    { 10, "десет" },
    { 11, "единадесет" },
    { 12, "дванадесет" },
    { 13, "тринадесет" },
    { 14, "четиринадесет" },
    { 15, "петнадесет" },
    { 16, "шестнадесет" },
    { 17, "седемнадесет" },
    { 18, "осемнадесет" },
    { 19, "деветнадесет" },
    { 20, "двадесет" },
    { 30, "тридесет" },
    { 40, "четиридесет" },
    { 50, "петдесет" },
    { 60, "шестдесет" },
    { 70, "седемдесет" },
    { 80, "осемдесет" },
    { 90, "деветдесет" }
};

private static readonly Dictionary<int, string> Hundreds = new Dictionary<int, string>()
{
    { 1, "сто" },
    { 2, "двеста" },
    { 3, "триста" },
    { 4, "четиристотин" },
    { 5, "петстотин" },
    { 6, "шестстотин" },
    { 7, "седемстотин" },
    { 8, "осемстотин" },
    { 9, "деветстотин" }
};

public static void PrintNumberInWords(int number)
{
    if (number < 0 || number > 999)
    {
        Console.WriteLine("Числото трябва да е между 0 и 999.");
        return;
    }

    string result = ConvertNumberToWords(number);
    Console.WriteLine(result);
}

private static string ConvertNumberToWords(int number)
{
    if (number == 0)
        return Numbers[0];

    List<string> parts = new();

    int hundreds = number / 100;
    int tensUnits = number % 100;
    int tens = tensUnits / 10;
    int units = tensUnits % 10;

    if (hundreds > 0)
        parts.Add(Hundreds[hundreds]);

    if (tensUnits > 0)
    {
        if (tensUnits <= 20)
        {
            parts.Add((hundreds > 0 ? "и " : "") + Numbers[tensUnits]);
        }
        else
        {
            string tensPart = Numbers[tens * 10];
            string unitsPart = units > 0 ? " и " + Numbers[units] : "";
            parts.Add((hundreds > 0 ? "и " : "") + tensPart + unitsPart);
        }
    }

    return string.Join(" ", parts).Trim();
}

}