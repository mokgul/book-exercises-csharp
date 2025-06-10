namespace Chapter02;

public static class Exercise11
{
    public static void DrawTriangleWithChar()
    {
        char c = '\u00A9';
        Console.WriteLine(
            $"  {c}" + Environment.NewLine +
            $" {c}{c}{c}" + Environment.NewLine +
            $"{c}{c}{c}{c}{c}");
    }
}