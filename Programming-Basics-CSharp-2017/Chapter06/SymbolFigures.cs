namespace Chapter06;

public static class SymbolFigures
{
    public static void PrintStarsRectangle(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= n; j++)
            {
                Console.Write('*');
            }

            Console.WriteLine();
        }
    }

    public static void PrintTriangleFromSymbol(char symbol, int n)
    {
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(symbol);
            }

            Console.WriteLine();
        }
    }

    public static void PrintSquareWithBorders(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= n; j++)
            {
                if ((i == 1 || i == n) && (j == 1 || j == n))
                {
                    Console.Write('+');
                }
                else if ((i > 1 || i < n) && (j == 1 || j == n))
                {
                    Console.Write('|');
                }
                else
                {
                    Console.Write('-');
                }
            }
            Console.WriteLine();
        }
    }

    public static void PrintRhombus(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            int spaces = n - i;
            int stars = 2 * i - 1;
            Console.Write(new string(' ', spaces));
            Console.WriteLine(new string('*', stars));
        }
        
        for (int i = n - 1; i >= 1; i--)
        {
            int spaces = n - i;
            int stars = 2 * i - 1;
            Console.Write(new string(' ', spaces));
            Console.WriteLine(new string('*', stars));
        }
    }

    public static void PrintYuleTree(int n)
    {
        for (int i = 0; i <= n; i++)
        {
            string stars = new string('*', i);
            string spaces = new string(' ', n - i);
            Console.WriteLine(spaces + stars + " | " + stars);
        }
    }
}