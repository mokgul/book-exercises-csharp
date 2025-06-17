namespace Chapter07;

public static class Exercise13
{
    public static void PrintSubMatrixWithSum()
    {
        Console.WriteLine("Enter numbers for matrix size: n and m");
        Console.WriteLine("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter m: ");
        int m = int.Parse(Console.ReadLine());

        int[,] matrix = new int[n, m];
        Console.WriteLine("Enter elements for matrix size: ");
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < m; col++)
            {
                Console.Write($"matrix[{row}, {col}] = ");
                matrix[row, col] = int.Parse(Console.ReadLine());
            }
        }

        int bestSum = int.MinValue;
        int bestRow = 0;
        int bestCol = 0;

        for (int row = 0; row <= n - 3; row++)
        {
            for (int col = 0; col <= m - 3; col++)
            {
                int currentSum = 0;

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        currentSum += matrix[row + i, col + j];
                    }
                }

                if (currentSum > bestSum)
                {
                    bestSum = currentSum;
                    bestRow = row;
                    bestCol = col;
                }
            }
        }

        // Print result
        Console.WriteLine("\nBest 3x3 submatrix with max sum:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(matrix[bestRow + i, bestCol + j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine($"Max sum = {bestSum}");

    }
}