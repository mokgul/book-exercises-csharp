namespace Chapter03;

public static class Number
{
    public static void OddOrEven()
    {
        int number = int.Parse(Console.ReadLine());
        if (number % 2 == 0)
        {
            Console.WriteLine("Odd");
        }
        else
        {
            Console.WriteLine("Even");
        }
    }

    public static void PrintBiggerNumber()
    {
        int number = int.Parse(Console.ReadLine());
        int number2 = int.Parse(Console.ReadLine());

        if (number > number2)
        {
            Console.WriteLine(number);
        }
        else
        {
            Console.WriteLine(number2);
        }
        
        // Console.WriteLine(number > number2 ? number : number2);
    }

    public static void PrintNumberAsText()
    {
        int number = int.Parse(Console.ReadLine());
        if(number == 1)
            Console.WriteLine("one");
        else if(number == 2)
            Console.WriteLine("two");
        else if(number == 3)
            Console.WriteLine("three");
        else if(number == 4)
            Console.WriteLine("four");
        else if(number == 5)
            Console.WriteLine("five");
        else if(number == 6)
            Console.WriteLine("six");
        else if(number == 7)
            Console.WriteLine("seven");
        else if(number == 8)
            Console.WriteLine("eight");
        else if(number == 9)
            Console.WriteLine("nine");
    }

    public static void IsNumberBetween100And200()
    {
        int number = int.Parse(Console.ReadLine());
        if (number >= 100 && number <= 200)
        {
            Console.WriteLine("Between 100 and 200");
        }
        else if (number < 100)
        {
            Console.WriteLine("Less than 100");
        }
        else
        {
            Console.WriteLine("Greater than 200");
        }
    }

    public static void CompareThreeNumbers()
    {
        int number = int.Parse(Console.ReadLine());
        int number2 = int.Parse(Console.ReadLine());
        int number3 = int.Parse(Console.ReadLine());

        if (number != number2)
        {
            Console.WriteLine("Numbers are not equal");
            return;
        }
        if(number != number3)
        {
            Console.WriteLine("Numbers are not equal");
            return;
        }
        Console.WriteLine("Numbers are equal");
    }

    public static void PrintNumberAsTextUpTo100()
    {
        int number = int.Parse(Console.ReadLine());
        if (number < 0 || number > 100)
        {
            Console.WriteLine("Number is less than 0 or greater than 100");
            return;
        }

        string[] ones =
        [
            "zero", "one", "two", "three", "four",
            "five", "six", "seven", "eight", "nine",
            "ten", "eleven", "twelve", "thirteen",
            "fourteen", "fifteen", "sixteen",
            "seventeen", "eighteen", "nineteen"
        ];

        string[] tens =
        [
            "", "", "twenty", "thirty", "forty",
            "fifty", "sixty", "seventy", "eighty", "ninety"
        ];

        if (number < 20)
        {
            Console.WriteLine(ones[number]);
        }
        else if (number < 100)
        {
            int t = number / 10;
            int o  = number % 10;
            if (o == 0)
            {
                Console.WriteLine(tens[t]);
            }
            else
            {
                Console.WriteLine(tens[t] + " " + ones[o]);
            }
        }
        else
        {
            Console.WriteLine("one hundred");
        }
    }
}