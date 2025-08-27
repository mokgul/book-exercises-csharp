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
}