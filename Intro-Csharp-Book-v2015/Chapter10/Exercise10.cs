namespace Chapter10;

public static class Exercise10
{
    static char[,] _maze =
    {
        { ' ', ' ', ' ' },
        { '*', '*', ' ' },
        { ' ', ' ', ' ' }
    };

    static bool[,] _visited = new bool[3, 3];
    static List<(int, int)> _path = new List<(int, int)>();
    static int _rows = 3;
    static int _cols = 3;

    public static void MatrixPathFinder()
    {
        int startRow = 0, startCol = 0;
        int endRow = 2, endCol = 2;

        Console.WriteLine("Всички възможни пътища:");
        FindPaths(startRow, startCol, endRow, endCol);
    }

    static void FindPaths(int row, int col, int endRow, int endCol)
    {
        if (row < 0 || row >= _rows || col < 0 || col >= _cols)
            return; // Извън матрицата

        if (_maze[row, col] == '*' || _visited[row, col])
            return; // Стена или вече посетено

        _path.Add((row, col));

        if (row == endRow && col == endCol)
        {
            // Пътят е намерен
            Console.WriteLine(string.Join(" -> ", _path));
            _path.RemoveAt(_path.Count - 1);
            return;
        }

        _visited[row, col] = true;

        // Обход на съседите (нагоре, надясно, надолу, наляво)
        FindPaths(row - 1, col, endRow, endCol); // Up
        FindPaths(row, col + 1, endRow, endCol); // Right
        FindPaths(row + 1, col, endRow, endCol); // Down
        FindPaths(row, col - 1, endRow, endCol); // Left

        _visited[row, col] = false;
        _path.RemoveAt(_path.Count - 1); // Назад в рекурсията
    }
}