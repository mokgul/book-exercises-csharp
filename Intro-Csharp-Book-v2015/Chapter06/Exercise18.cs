namespace Chapter06;

public static class Exercise18
{
    public static void PrintMatrixInSpiral(int size)
    {
        int[,] matrix = new int[size, size];

        int value = 1;
        int start = 0;
        int end = size;

        while (start < end)
        {
            // Top row
            for (int i = start; i < end; i++)
                matrix[start, i] = value++;

            // Right column
            for (int i = start + 1; i < end; i++)
                matrix[i, end - 1] = value++;

            // Bottom row
            for (int i = end - 2; i >= start; i--)
                matrix[end - 1, i] = value++;

            // Left column
            for (int i = end - 2; i > start; i--)
                matrix[i, start] = value++;

            start++;
            end--;
        }

        // Print
        for (int row = 0; row < size; row++)
        {
            for (int col = 0; col < size; col++)
            {
                Console.Write(matrix[row, col].ToString().PadLeft(3));
            }

            Console.WriteLine();
        }
    }
}