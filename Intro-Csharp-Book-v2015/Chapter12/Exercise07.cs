namespace Chapter12;

public static class Exercise07
{
    public static void SqrtOfNumber()
    {
        Console.WriteLine("Enter number:");
        try
        {
            double number = double.Parse(Console.ReadLine());
            if (number < 0)
            {
                Console.WriteLine("Invalid number");
            }

            var sqrt = Math.Sqrt(number);
            Console.WriteLine(sqrt);
        }
        catch (Exception)
        {
            Console.WriteLine("Invalid number");
        }
        finally
        {
            Console.WriteLine("Good bye");
        }
    }
}