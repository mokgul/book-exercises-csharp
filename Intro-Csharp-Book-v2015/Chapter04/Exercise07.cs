namespace Chapter04;

public static class Exercise07
{
    public static void EnterAndPrintNumbersUsingGoTo()
    {
        int[] nums = new int[5];
        int index = 0;

        Enter:
        Console.Write($"Enter number {index + 1}: ");
        string input = Console.ReadLine();

        bool isValid = int.TryParse(input, out int num);
        if (!isValid)
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
            goto Enter;
        }

        nums[index] = num;
        index++;

        if (index < nums.Length)
            goto Enter;

        Console.WriteLine($"Sum of numbers is: {nums.Sum()}");
    }

    public static void EnterAndPrintNumbersUsingWhile()
    {
        int[] nums = new int[5];
        int index = 0;

        while (index < nums.Length)
        {
            Console.Write($"Enter number {index + 1}: ");
            string input = Console.ReadLine();

            bool isValid = int.TryParse(input, out int num);
            if (isValid)
            {
                nums[index] = num;
                index++;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
        }

        Console.WriteLine($"Sum of numbers is: {nums.Sum()}");
    }
}