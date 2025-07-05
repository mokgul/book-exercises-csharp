namespace Chapter13;

public static class Exercise12
{
    public static void PrintNumberInFormats()
    {
        Console.Write("Enter a number: ");
        string input = Console.ReadLine();

        if (decimal.TryParse(input, out decimal number))
        {
            Console.WriteLine("{0,15:D}", (int)number);
            Console.WriteLine("{0,15:X}", (int)number);
            Console.WriteLine("{0,15:P}", number);
            Console.WriteLine("{0,15:C}", number);
            Console.WriteLine("{0,15:E}", number);
        }
        else
        {
            Console.WriteLine("Invalid input!");
        }
    }
}