namespace Chapter05;

public static class Exercise08
{
    public static void PrintVariable()
    {
        Console.WriteLine("Choose the type of variable:");
        Console.WriteLine("0) Enter 0 for an integer");
        Console.WriteLine("1) Enter 1 for a double");
        Console.WriteLine("2) Enter 2 for a string");
        int option = int.Parse(Console.ReadLine());
        string output = option switch
        {
            0 => output = (++option).ToString(),
            1 => output = (++option).ToString(),
            2 => output = option.ToString() + "*"
        };
        Console.WriteLine(output);
    }
}