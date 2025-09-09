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

    public static void PrintCastle(int n)
    {
        var colSize = n / 2;
        var midSize = 2 * n - 2 * colSize - 4;
        Console.WriteLine("/{0}\\{1}/{0}\\", new string('^', colSize), new string('_', midSize));

        for (int row = 1; row <= n - 3; row++)
        {
            Console.WriteLine("|{0}|", new string(' ', 2 * n - 2));
        }
        Console.WriteLine("|{0}{1}{0}|", new string(' ', colSize + 1), new string('_', midSize));
        Console.WriteLine("\\{0}/{1}\\{0}/", new string('_', colSize), new string(' ', midSize));;
    }

    public static void PrintButterfly(int n)
    {
        var halfRowSize = n - 2;
        for (int row = 1; row <= halfRowSize; row++)
        {
            if (row % 2 != 0)
            {
               Console.WriteLine("{0}\\ /{0}", new string('*', halfRowSize)); 
            }
            else
            {
                Console.WriteLine("{0}\\ /{0}", new string('-', halfRowSize)); 
            }
        }
        Console.WriteLine("{0} @ {0}", new string(' ', halfRowSize));
        for (int row = 1; row <= halfRowSize; row++)
        {
            if (row % 2 != 0)
            {
                Console.WriteLine("{0}/ \\{0}", new string('*', halfRowSize)); 
            }
            else
            {
                Console.WriteLine("{0}/ \\{0}", new string('-', halfRowSize)); 
            }
        }
    }

    public static void PrintStopSign(int n)
    {
        int dots = n + 1;
        var underscopes = 2 * n + 1;
        Console.WriteLine("{0}{1}{0}",  new string('.', dots), new string('_', underscopes));
        underscopes -= 2;
        dots--;
        for (int row = 1; row < n; row++)
        {
            Console.WriteLine("{0}//{1}\\\\{0}", new string('.', dots), new string('_', underscopes));
            underscopes += 2;
            dots--;
        }
        Console.WriteLine("//{0}STOP!{0}\\\\",  new string('_', (underscopes - 5) / 2));
        for (int row = 1; row < n; row++)
        {
            Console.WriteLine("{0}\\\\{1}//{0}", new  string('.', row), new string('_', underscopes));
            underscopes -= 2;
        }
    }

    public static void PrintArrow(int n)
    {
        int outerDots = (n - 1) / 2;
        var innerDots = n - 2;
        Console.WriteLine("{0}{1}{0}", new string('.', outerDots), new string('#', n));
        for (int row = 0; row < n - 2; row++)
        {
            Console.WriteLine("{0}#{1}#{0}", new string('.', outerDots), new string('.', innerDots));
        }
        Console.WriteLine("{0}{1}{0}", new string('#', outerDots + 1), new string('.', innerDots));
        outerDots = 1;
        innerDots = 2 * n - 5;
        for (int row = 0; row < n - 2; row++)
        {
            Console.WriteLine("{0}#{1}#{0}", new string('.', outerDots), new string('.', innerDots));
            outerDots++;
            innerDots -= 2;
        }
        Console.WriteLine("{0}#{0}", new string('.', outerDots));
    }

    public static void PrintAxe(int n)
    {
        int width = 5 * n;
        int leftDashes = 3 * n;
        int middleDashes = 0;
        int rightDashes = width - leftDashes - middleDashes - 2;

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("{0}*{1}*{2}",
                new string('-', leftDashes),
                new string('-', middleDashes),
                new string('-', rightDashes));
            
            middleDashes++;
            rightDashes--;
        }

        middleDashes--;
        rightDashes++;

        for (int i = 0; i < n - 2; i++)
        {
            Console.WriteLine("{0}*{1}*{2}",
                new string('*', leftDashes),
                new string('-', middleDashes),
                new string('-', rightDashes));
        }

        for (int row = 1; row < n / 2 - 1; row++)
        {
            Console.WriteLine("{0}*{1}*{2}",
                new string('-', leftDashes),
                new string('-', middleDashes),
                new string('-', rightDashes));
            leftDashes--;
            rightDashes--;
            middleDashes += 2;
        }
        Console.WriteLine("{0}*{1}*{2}",
            new string('-', leftDashes),
            new string('*', middleDashes),
            new string('-', rightDashes));
    }
}