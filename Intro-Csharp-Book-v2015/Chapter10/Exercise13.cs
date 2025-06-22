namespace Chapter10;

public static class Exercise13
{
    static int rows = 5;
    static int cols = 6;
    static char[,] matrix = {
        { ' ', '*', ' ', ' ', ' ', ' ' },
        { ' ', '*', ' ', '*', '*', ' ' },
        { ' ', ' ', ' ', ' ', '*', ' ' },
        { '*', '*', '*', ' ', '*', ' ' },
        { ' ', ' ', ' ', ' ', ' ', ' ' }
    };

    static bool[,] visited = new bool[rows, cols];

    public static void MatrixFindBestPath()
    {

        List<int> areas = new List<int>();

        for (int r = 0; r < rows; r++)
        {
            for (int c = 0; c < cols; c++)
            {
                if (matrix[r, c] == ' ' && !visited[r, c])
                {
                    int areaSize = DFS(r, c);
                    areas.Add(areaSize);
                }
            }
        }

        Console.WriteLine("Намерени площи (размери):");
        foreach (var size in areas)
            Console.WriteLine(size);
    }

    static int DFS(int r, int c)
    {
        if (r < 0 || r >= rows || c < 0 || c >= cols)
            return 0;

        if (matrix[r, c] == '*' || visited[r, c])
            return 0;

        visited[r, c] = true;

        int size = 1; // Текуща клетка

        size += DFS(r - 1, c); // нагоре
        size += DFS(r + 1, c); // надолу
        size += DFS(r, c - 1); // наляво
        size += DFS(r, c + 1); // надясно

        return size;
    }
}