namespace Chapter02;

public static class SquareArea
{
    public static void Calculate()
    {
        Console.Write("a = ");
        var a = int.Parse(Console.ReadLine());
        var area = a * a;
        Console.Write("Square area = ");
        Console.WriteLine(area);
    }
}