namespace Chapter09;

public static class Exercise11
{
    public static void TaskSolver()
    {
        Menu:
        Console.WriteLine("Enter number to choose one of the following options:");
        Console.WriteLine("1) Reverse a number:");
        Console.WriteLine("2) Arithmetic mean:");
        Console.WriteLine("3) Solve a linear equation:");
        Console.WriteLine("4) Exit");

        bool valid = int.TryParse(Console.ReadLine(), out int choice);
        if (!valid)
        {
            Console.WriteLine("Invalid choice.");
            return;
        }

        switch (choice)
        {
            case 1: ReverseNumber(); break;
            case 2: ArithmeticMean(); break;
            case 3: SolveLinearEquation(); break;
            case 4: return;
        }
        goto Menu;
    }

    private static void ReverseNumber()
    {
        Console.WriteLine("Enter number to reverse: ");
        int number = int.Parse(Console.ReadLine());
        if (number < 0)
        {
            Console.WriteLine("The number to reverse cant be negative.");
            return;
        }
        char[] arr = number.ToString().ToCharArray().Reverse().ToArray();
        int reversed =  int.Parse(string.Join("", arr));
        Console.WriteLine($"The reversed number is: {reversed}");
    }

    private static void ArithmeticMean()
    {
        Console.WriteLine("Enter numbers separated by spaces: ");
        string input = Console.ReadLine();
        if (string.IsNullOrEmpty(input))
        {
            Console.WriteLine("The series cant be empty.");
            return;
        }
        int[] numbers = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        int mean = numbers.Sum() / numbers.Length;
        Console.WriteLine($"The mean is: {mean}");
    }

    private static void SolveLinearEquation()
    {
        Console.WriteLine("Enter number for the first coefficient: a=");
        int a = int.Parse(Console.ReadLine());
        if (a == 0)
        {
            Console.WriteLine("Coefficient 'a' cannot be 0");
            return;
        }
        Console.WriteLine("Enter number for the second coefficient: b=");
        int b = int.Parse(Console.ReadLine());
        int result = -b / a;
        Console.WriteLine($"The result is: {result}");
    }
}