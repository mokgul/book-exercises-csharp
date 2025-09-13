namespace Chapter10;

public class EmptyReceipt
{
    public static void Print()
    {
        PrintHeader();
        PrintBody();
        PrintFooter();
    }

    private static void PrintHeader()
    {
        Console.WriteLine("CASH RECEIPT");
        Console.WriteLine("---------------------");
    }

    private static void PrintBody()
    {
        Console.WriteLine("Charged to________________");
        Console.WriteLine("Received by________________");
    }

    private static void PrintFooter()
    {
        Console.WriteLine("----------------------");
        Console.WriteLine("(c) Some Company");
    }
}