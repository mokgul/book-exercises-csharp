namespace Chapter12;

public static class Exercise08
{
    public static int ReadNumber(int start, int end)
    {
        Console.WriteLine($"Enter number between {start} and {end}:");
        try
        {
            int number = int.Parse(Console.ReadLine());
            if (number < start || number > end)
            {
                Console.WriteLine($"The number {number} is out of range.");
            }
            return number;
        }
        catch (Exception e)
        {
            Console.WriteLine("Invalid input");
        }
        return 0;
    }

    public static void ReadMultipleNumbers(int start, int end)
    {
        int[] numbers = new int[10];
        numbers[0] = ReadNumber(start, end);
        for (int i = 1; i < 10; i++)
        {
            numbers[i] = ReadNumber(numbers[i - 1], end);
        }
        Console.WriteLine(string.Join(", ", numbers));
    }
}