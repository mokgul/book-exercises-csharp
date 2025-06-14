namespace Chapter05;

public static class Exercise05
{
    public static void PrintNumberName()
    {
        Console.WriteLine("Please enter a digit 0-9");
        int num = int.Parse(Console.ReadLine());
        string output = num switch
        {
            0 => "Нула",
            1 => "Едно",
            2 => "Две",
            3 => "Три",
            4 => "Четири",
            5 => "Пет",
            6 => "Шест",
            7 => "Седем",
            8 => "Осем",
            9 => "Девет",
        };
        Console.WriteLine(output);
    }
}