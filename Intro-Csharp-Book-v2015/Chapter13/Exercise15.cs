namespace Chapter13;

public static class Exercise15
{
    public static void DisplayDictionary()
    {
        string text =
            ".NET - platform for applications from Microsoft\n" +
            "CLR - managed execution environment for .NET\n" +
            "namespace - hierarchical organization of classes";
        string[] entries = text.Split("\n");

        foreach (var entry in entries)
        {
            var row = entry.Split("-",  StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine($"Word: {row[0].TrimEnd()}");
            Console.WriteLine($"Description: {row[1].TrimStart()}");
        }
    }
}