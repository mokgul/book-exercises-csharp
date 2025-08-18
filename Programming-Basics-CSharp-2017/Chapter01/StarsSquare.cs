namespace Chapter01;

public static class StarsSquare
{
    public static void PrintSquare(int size)
    {
        for (var i = 0; i < size; i++)
        {
            for (var j = 0; j < size; j++)
            {
                if (i > 0 && i < size - 1 & j > 0 && j < size - 1)
                    Console.Write(' ');
                else
                    Console.Write('*');
            }
            Console.WriteLine();
        }
    }
}