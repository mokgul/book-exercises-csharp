namespace Chapter07;

public static class Exercise14
{
    public static void LongestStringSequence()
    {
        string[,] matrix = new string[,]
        {
            { "a", "b", "b" },
            { "c", "b", "b" },
            { "a", "a", "a" }
        };

        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        int maxLen = 0;
        string maxElement = "";

        // Directions: (rowStep, colStep)
        (int, int)[] directions = new (int, int)[]
        {
            (0, 1),   // right
            (1, 0),   // down
            (1, 1),   // diagonal down-right
            (1, -1)   // diagonal down-left
        };

        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                foreach (var (dRow, dCol) in directions)
                {
                    string current = matrix[row, col];
                    int length = 1;

                    int r = row + dRow;
                    int c = col + dCol;

                    while (r >= 0 && r < rows && c >= 0 && c < cols && matrix[r, c] == current)
                    {
                        length++;
                        r += dRow;
                        c += dCol;
                    }

                    if (length > maxLen)
                    {
                        maxLen = length;
                        maxElement = current;
                    }
                }
            }
        }

        Console.WriteLine($"Longest sequence: {maxElement} (length {maxLen})");
    }
}