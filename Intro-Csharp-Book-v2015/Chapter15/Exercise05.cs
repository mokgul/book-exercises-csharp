namespace Chapter15;

public static class Exercise05
{
    public static void FindBiggestSumOfSquareMatrix()
    {
        string inputPath = "../../../matrix.txt";
        string outputPath = "../../../output.txt";

        List<int[]> matrixList = new List<int[]>();

        // Read the matrix from file
        using (var reader = new StreamReader(inputPath))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                var numbers = line
                    .Trim()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                matrixList.Add(numbers);
            }
        }

        int rows = matrixList.Count;
        int cols = matrixList[0].Length;
        int[,] matrix = new int[rows, cols];

        // Copy list into 2D array
        for (int i = 0; i < rows; i++)
        for (int j = 0; j < cols; j++)
            matrix[i, j] = matrixList[i][j];

        int maxSum = int.MinValue;

        // Find 2x2 submatrix with max sum
        for (int row = 0; row < rows - 1; row++)
        {
            for (int col = 0; col < cols - 1; col++)
            {
                int currentSum =
                    matrix[row, col] +
                    matrix[row, col + 1] +
                    matrix[row + 1, col] +
                    matrix[row + 1, col + 1];

                if (currentSum > maxSum)
                    maxSum = currentSum;
            }
        }

        // Output result to file
        using (var writer = new StreamWriter(outputPath))
        {
            writer.WriteLine(maxSum);
        }

        Console.WriteLine($"Max 2x2 submatrix sum is: {maxSum}");
    }
}