namespace Chapter21;

public class Exercise06
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];
        bool[,] visited = new bool[n, n];
        
        int[] dx = { 1, 1, 0, -1, -1, -1, 0, 1 };
        int[] dy = { 0, 1, 1, 1, 0, -1, -1, -1 };

        int x = 0, y = 0;
        int dir = 0;
        int count = 1;

        matrix[x, y] = count;
        visited[x, y] = true;

        while (true)
        {
            bool moved = false;
            for (int i = 0; i < 8; i++)
            {
                int newDir = (dir + i) % 8;
                int nx = x + dx[newDir];
                int ny = y + dy[newDir];

                if (nx >= 0 && nx < n && ny >= 0 && ny < n && !visited[nx, ny])
                {
                    x = nx;
                    y = ny;
                    dir = newDir;
                    count++;
                    matrix[x, y] = count;
                    visited[x, y] = true;
                    moved = true;
                    break;
                }
            }

            if (!moved)
            {
                bool found = false;
                for (int i = 0; i < n && !found; i++)
                {
                    for (int j = 0; j < n && !found; j++)
                    {
                        if (!visited[i, j])
                        {
                            x = i;
                            y = j;
                            count++;
                            matrix[x, y] = count;
                            visited[x, y] = true;
                            dir = 0;
                            found = true;
                        }
                    }
                }

                if (!found)
                {
                    break;
                }
            }
        }
        
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(matrix[i, j] + (j == n - 1 ? "\n" : " "));
            }
        }
    }
}