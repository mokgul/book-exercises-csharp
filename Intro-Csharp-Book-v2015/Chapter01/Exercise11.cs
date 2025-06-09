namespace Chapter01;

public static class Exercise11
{
    public static void ReturnAge()
    {
        Console.Write("Enter your age: ");
        int number = int.Parse(Console.ReadLine() ?? string.Empty);
        Console.WriteLine($"Your age int 10 years will be {number + 10}");
    }
}