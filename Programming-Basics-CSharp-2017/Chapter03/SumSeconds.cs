namespace Chapter03;

public static class SumSeconds
{
    public static void Do()
    {
        int first = int.Parse(Console.ReadLine());
        int second = int.Parse(Console.ReadLine());
        int third = int.Parse(Console.ReadLine());
        int sum = first + second + third;
        int minutes = sum / 60;
        int seconds = sum % 60;
        Console.WriteLine($"{minutes}:{seconds:00.00}");
    }
}