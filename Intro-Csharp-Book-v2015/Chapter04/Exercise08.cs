namespace Chapter04;

public static class Exercise08
{
    public static void PrintBiggestNumber()
    {
        int count = 5;
        int[] nums = new int[count];

        for (int i = 0; i < count; i++)
        {
            Console.Write($"Enter number {i + 1}/{count}: ");
            while (!int.TryParse(Console.ReadLine(), out nums[i]))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
                Console.Write($"Enter number {i + 1}/{count}: ");
            }
        }
        int biggest = nums.Max();
        Console.WriteLine($"Biggest number is: {biggest}");
    }
}