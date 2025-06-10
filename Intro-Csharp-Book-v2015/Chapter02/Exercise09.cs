namespace Chapter02;

public static class Exercise09
{
    public static void QuotationsInString()
    {
        string escaping = "The \"use\" of quotations causes difficulties.";
        string verbatim = @"The ""use"" of quotations causes difficulties.";
        Console.WriteLine(escaping);
        Console.WriteLine(verbatim);
    }
}