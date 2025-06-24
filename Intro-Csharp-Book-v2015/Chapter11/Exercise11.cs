namespace Chapter11;

public static class Exercise11
{
    private static readonly string[] phrases =
    [
        "Продуктът е отличен.",
        "Това е страхотен продукт.",
        "Постоянно ползвам този продукт.",
        "Това е най-добрият продукт от тази категория."
    ];

    private static readonly string[] actions =
    [
        "Вече се чувствам добре.",
        "Успях да се променя.",
        "Той направи чудо.",
        "Не мога да повярвам, но вече се чувствам страхотно.",
        "Опитайте и вие. Аз съм много доволна."
    ];

    private static readonly string[] authorFirstName =
    [
        "Диана", "Петя", "Стела", "Елена", "Катя"
    ];

    private static readonly string[] authorSecondName =
    [
        "Иванова", "Петрова", "Кирова"
    ];

    private static readonly string[] cities =
    [
        "София", "Пловдив", "Варна", "Русе", "Бургас"
    ];

    public static void PrintRandomAd()
    {
        Random random = new Random();
        string message =
            phrases[random.Next(0, phrases.Length)] + " " +
            actions[random.Next(0, actions.Length)] + " " +
            " - " + authorFirstName[random.Next(0, authorFirstName.Length)] +
            " " + authorSecondName[random.Next(0, authorSecondName.Length)] +
            ", " + cities[random.Next(0, cities.Length)];
        Console.WriteLine(message);
    }
}