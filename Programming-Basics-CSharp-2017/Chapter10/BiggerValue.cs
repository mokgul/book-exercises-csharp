namespace Chapter10;

public static class BiggerValue
{
    public static void Print()
    {
        string type = Console.ReadLine();
        string value1 = Console.ReadLine();
        string value2 = Console.ReadLine();
        string max = string.Empty;

        switch (type)
        {
            case "int": max = GetMax(int.Parse(value1), int.Parse(value2)).ToString(); break;
            case "char": max = GetMax(char.Parse(value1), char.Parse(value2)).ToString(); break;
            case "string": max = GetMax(value1, value2); break;
            default: break;
        }
        Console.WriteLine(max);
    }
    
    private static int GetMax(int a, int b) => Math.Max(a, b);
    
    private static char GetMax(char a, char b) => a < b ? a : b;
    
    private static string GetMax(string a, string b) => String.Compare(a, b, StringComparison.Ordinal) > 0 ? a : b;
}