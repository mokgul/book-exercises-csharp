namespace Chapter04;

public static class Exercise10
{
    public static void PrintSumOfNumbers()
    {
        Console.WriteLine("Please enter count of numbers: ");
        int n = int.Parse(Console.ReadLine());
        int sum = 0;
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine("Please enter a number: ");
            sum += int.Parse(Console.ReadLine());
        }
        Console.WriteLine(sum);
    }
}