namespace Chapter10;

public static class Exercise14
{
    static int rows = 5;
    static int cols = 6;

    // Лабиринт: ' ' - проходими, '*' - стена
    static char[,] maze = {
        { ' ', '*', ' ', ' ', ' ', ' ' },
        { ' ', '*', ' ', '*', '*', ' ' },
        { ' ', ' ', ' ', ' ', '*', ' ' },
        { '*', '*', '*', ' ', '*', ' ' },
        { ' ', ' ', ' ', ' ', ' ', ' ' }
    };

    // Смени тези координати според задачата
    static (int r, int c) start = (0, 0);
    static (int r, int c) end = (4, 5);

    static int[] dr = new int[] { -1, 1, 0, 0 };
    static int[] dc = new int[] { 0, 0, -1, 1 };

    public static void BreathFirstSearch()
    {
        var path = BFS(start, end);

        if (path == null)
            Console.WriteLine("Няма път!");
        else
        {
            Console.WriteLine("Намерихме път:");
            foreach (var cell in path)
                Console.Write($"({cell.r}, {cell.c}) ");
        }
    }

    static List<(int r, int c)> BFS((int r, int c) start, (int r, int c) end)
    {
        bool[,] visited = new bool[rows, cols];
        (int r, int c)[,] parent = new (int, int)[rows, cols];

        for (int i = 0; i < rows; i++)
        for (int j = 0; j < cols; j++)
            parent[i, j] = (-1, -1);

        Queue<(int r, int c)> queue = new Queue<(int r, int c)>();
        queue.Enqueue(start);
        visited[start.r, start.c] = true;

        while (queue.Count > 0)
        {
            var current = queue.Dequeue();

            if (current == end)
            {
                // Възстановяване на пътя
                List<(int r, int c)> path = new List<(int r, int c)>();
                while (current != (-1, -1))
                {
                    path.Add(current);
                    current = parent[current.r, current.c];
                }
                path.Reverse();
                return path;
            }

            // Обход в 4 посоки
            for (int i = 0; i < 4; i++)
            {
                int nr = current.r + dr[i];
                int nc = current.c + dc[i];

                if (nr >= 0 && nr < rows && nc >= 0 && nc < cols &&
                    maze[nr, nc] == ' ' && !visited[nr, nc])
                {
                    visited[nr, nc] = true;
                    parent[nr, nc] = current;
                    queue.Enqueue((nr, nc));
                }
            }
        }

        // Ако няма път
        return null;
    }
}