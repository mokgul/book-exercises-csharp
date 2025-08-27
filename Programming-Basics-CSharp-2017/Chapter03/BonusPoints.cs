namespace Chapter03;

public static class BonusPoints
{
    public static void Calculate()
    {
        double bonus = 0;
        int number   = int.Parse(Console.ReadLine());
        if (number <= 100)
            bonus += 5;
        else if (number > 1000)
            bonus = number * 0.10;
        else
            bonus = number * 0.20;

        if (number % 2 == 0)
            bonus += 1;
        else if (number % 10 == 5)
            bonus += 2;
        Console.WriteLine($"Bonus: {bonus}");
        Console.WriteLine($"Total: {number + bonus}");
    }
}