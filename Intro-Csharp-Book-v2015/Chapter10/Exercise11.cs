namespace Chapter10;

public static class Exercise11
{
    static int _rows = 100;
    static int _cols = 100;
    static bool[,] _visited = new bool[_rows, _cols];
    static char[,] _maze = new char[_rows, _cols];

    public static void MatrixPathFinderModified()
    {
        for (int r = 0; r < _rows; r++)
        for (int c = 0; c < _cols; c++)
            _maze[r, c] = ' '; // Проходима клетка

        int startRow = 0, startCol = 0;
        int endRow = 99, endCol = 99;

        bool pathExists = ExistsPath(startRow, startCol, endRow, endCol);
        Console.WriteLine(pathExists ? "Път съществува" : "Няма път");
    }

    static bool ExistsPath(int row, int col, int endRow, int endCol)
    {
        // Проверка граници
        if (row < 0 || row >= _rows || col < 0 || col >= _cols)
            return false;

        // Проверка за непроходима клетка или вече посетена
        if (_maze[row, col] == '*' || _visited[row, col])
            return false;

        // Проверка дали сме достигнали крайната клетка
        if (row == endRow && col == endCol)
            return true;

        _visited[row, col] = true;

        // Рекурсивно търсене в 4 посоки
        bool found =
            ExistsPath(row - 1, col, endRow, endCol) || // нагоре
            ExistsPath(row + 1, col, endRow, endCol) || // надолу
            ExistsPath(row, col - 1, endRow, endCol) || // наляво
            ExistsPath(row, col + 1, endRow, endCol);   // надясно

        return found;
    }
}