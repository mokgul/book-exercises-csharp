namespace Chapter07;

public static class ExceptionExamples
{
    public static void IsNumberEven()
    {
        while (true)
        {
            try
            {
                Console.WriteLine("Enter number: ");
                var n = int.Parse(Console.ReadLine());
                if (n % 2 == 0)
                {
                    Console.WriteLine($"The entered number is {n}");
                    break;
                }

                Console.WriteLine("The entered number is not an even number.");
            }
            catch
            {
                Console.WriteLine("The entered number is not an even number.");
            }
        }
    }
}