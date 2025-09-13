namespace Chapter10;

public class NumbersToText
{
    public static void NumberToText()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());
            Letterize(number);
        }
    }
    
    public static void Letterize(int number)
    {
        if (number > 999)
        {
            Console.WriteLine("too large");
            return;
        }
        if (number < -999)
        {
            Console.WriteLine("too small");
            return;
        }

        if (Math.Abs(number) < 100) // не е трицифрено
        {
            return;
        }

        string result = "";
        if (number < 0)
        {
            result += "minus ";
            number = Math.Abs(number);
        }

        int hundreds = number / 100;
        int tens = (number / 10) % 10;
        int ones = number % 10;

        result += DigitToWord(hundreds) + "-hundred";

        if (tens == 0 && ones == 0)
        {
            Console.WriteLine(result);
            return;
        }

        result += " and ";

        if (tens == 1) // teen numbers
        {
            result += TeenToWord(ones);
        }
        else
        {
            if (tens > 1)
            {
                result += TensToWord(tens);
                if (ones > 0) result += " " + DigitToWord(ones);
            }
            else
            {
                result += DigitToWord(ones);
            }
        }

        Console.WriteLine(result);
    }

    private static string DigitToWord(int d)
    {
        switch (d)
        {
            case 0: return "zero";
            case 1: return "one";
            case 2: return "two";
            case 3: return "three";
            case 4: return "four";
            case 5: return "five";
            case 6: return "six";
            case 7: return "seven";
            case 8: return "eight";
            case 9: return "nine";
            default: return "";
        }
    }

    private static string TeenToWord(int d)
    {
        switch (d)
        {
            case 0: return "ten";
            case 1: return "eleven";
            case 2: return "twelve";
            case 3: return "thirteen";
            case 4: return "fourteen";
            case 5: return "fifteen";
            case 6: return "sixteen";
            case 7: return "seventeen";
            case 8: return "eighteen";
            case 9: return "nineteen";
            default: return "";
        }
    }

    private static string TensToWord(int d)
    {
        switch (d)
        {
            case 2: return "twenty";
            case 3: return "thirty";
            case 4: return "forty";
            case 5: return "fifty";
            case 6: return "sixty";
            case 7: return "seventy";
            case 8: return "eighty";
            case 9: return "ninety";
            default: return "";
        }
    }
}