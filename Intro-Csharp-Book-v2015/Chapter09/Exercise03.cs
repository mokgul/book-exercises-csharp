namespace Chapter09;

public static class Exercise03
{
    public static string ReturnLastDigitAsText(int number)
    {
        int lastDigit = number % 10;
        string text = lastDigit switch
        {
            0 => "zero",
            1 => "one",
            2 => "two",
            3 => "three",
            4 => "four",
            5 => "five",
            6 => "six",
            7 => "seven",
            8 => "eight",
            9 => "nine"
        };
        return text;
    }
}