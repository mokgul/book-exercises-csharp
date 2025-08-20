namespace Chapter02;

public static class RadToDeg
{
    public static void Convert()
    {
        Console.WriteLine("Enter the degrees in rad:");
        double rad = double.Parse(Console.ReadLine());
        double deg = (rad * 180) / Math.PI;
        Console.WriteLine($"{deg:f0}");
    }
}