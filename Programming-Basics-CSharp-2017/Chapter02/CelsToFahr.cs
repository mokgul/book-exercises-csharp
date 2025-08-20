namespace Chapter02;

public static class CelsToFahr
{
    public static void Convert()
    {
        Console.WriteLine("Enter the degrees in Celsius to convert:");
        var celsius = double.Parse(Console.ReadLine());
        var fahrenheit = celsius * 1.8 + 32;
        Console.WriteLine($"{fahrenheit:f2}");
    }
}