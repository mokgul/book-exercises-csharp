namespace Chapter10;

public static class Exercise12
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
    static int maxLength = 0;

    public static void LongestSequence()
    {
        for (int r = 0; r < rows; r++)
        {
            for (int c = 0; c < cols; c++)
            {
                if (matrix[r, c] == ' ' && !visited[r, c])
                {
                    DFS(r, c, 0);
                }
            }
        }
        Console.WriteLine($"Най-дългата поредица е с дължина: {maxLength}");
    }

    static void DFS(int row, int col, int length)
    {
        if (row < 0 || row >= rows || col < 0 || col >= cols)
            return;
        if (matrix[row, col] == '*' || visited[row, col])
            return;

        visited[row, col] = true;
        length++;

        if (length > maxLength)
            maxLength = length;

        // Обход в 4 посоки
        DFS(row - 1, col, length);
        DFS(row + 1, col, length);
        DFS(row, col - 1, length);
        DFS(row, col + 1, length);

        // Назад в рекурсията - махаме маркировката
        visited[row, col] = false;
    }
}