namespace Chapter02;

public static class InchToCm
{
    public static void Convert()
    {
        Console.Write("Inches = ");
        var inches = double.Parse(Console.ReadLine());
        var centimeters = inches * 2.54;
        Console.Write("Centimeters = ");
        Console.WriteLine(centimeters);
    }
}