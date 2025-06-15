namespace Chapter06;

public static class Exercise03
{
    public static void EnterNumbersAndPrintBiggestAndSmallest()
    {
        Console.WriteLine("Enter the amount of numbers to check:");
        int n = int.Parse(Console.ReadLine());
        int smallest = int.MaxValue;
        int biggest = int.MinValue;

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Enter number {i + 1}: ");
            var res = int.TryParse(Console.ReadLine(), out var number);
            if (res)
            {
                if (number < smallest)
                    smallest = number;
                if (number > biggest)
                    biggest = number;
            }
            else
            {
                Console.WriteLine("Invalid input. Skipping this number!");
            }
        }
        Console.WriteLine($"The biggest number is: {biggest}");
        Console.WriteLine($"The smallest number is: {smallest}");
    }
}