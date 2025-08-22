namespace Chapter02;

public static class SchoolRoom
{
    public static void SolveTask()
    {
        double lenght = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());
        double h = Math.Floor((lenght * 100) / 120);
        double w = Math.Floor((height * 100 - 100) / 70);
        var seats = h * w - 3;
        Console.WriteLine($"{seats:f0}");
    }
}