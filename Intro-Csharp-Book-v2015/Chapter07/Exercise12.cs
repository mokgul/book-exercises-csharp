namespace Chapter07;

public static class Exercise12
{
    public static void PrintMatrixInDifferentLayouts()
    {
        Console.WriteLine("Enter number for the size of all matrices: ");
        int size = int.Parse(Console.ReadLine());

        //Column major order
        Console.WriteLine("Column major order");
        int[,] matrixA = new int[size, size];
        int valueA = 1;
        for (int col = 0; col < size; col++)
        {
            for (int row = 0; row < size; row++)
            {
                matrixA[row, col] = valueA++;
            }
        }

        for (int row = 0; row < size; row++)
        {
            for (int col = 0; col < size; col++)
            {
                Console.Write(matrixA[row, col] + " ");
            }

            Console.WriteLine();
        }

        //Column major order but every second col is reversed
        Console.WriteLine("Column major order but every second col is reversed");
        int[,] matrixB = new int[size, size];
        int valueB = 1;
        for (int col = 0; col < size; col++)
        {
            if (col % 2 == 0)
            {
                for (int row = 0; row < size; row++)
                {
                    matrixB[row, col] = valueB++;
                }
            }
            else
            {
                for (int row = size - 1; row >= 0; row--)
                {
                    matrixB[row, col] = valueB++;
                }
            }
        }

        for (int row = 0; row < size; row++)
        {
            for (int col = 0; col < size; col++)
            {
                Console.Write(matrixB[row, col] + " ");
            }

            Console.WriteLine();
        }

        //Bottom left diagonal layout
        Console.WriteLine("Bottom left diagonal layout");
        int[,] matrixC = new int[size, size];
        int valueC = 1;
        int diagonals = 2 * size - 1;

        for (int d = 1; d <= diagonals; d++)
        {
            if (d <= size)
            {
                int count = 0;
                int i = size - d;
                int j = 0;
                while (count < d)
                {
                    matrixC[i, j] = valueC++;
                    count++;
                    i++;
                    j++;
                }
            }
            else
            {
                int count = d;
                int i = 0;
                int j = d - size;
                while (count <= diagonals)
                {
                    matrixC[i, j] = valueC++;
                    count++;
                    i++;
                    j++;
                }
            }
        }

        for (int row = 0; row < size; row++)
        {
            for (int col = 0; col < size; col++)
            {
                Console.Write(matrixC[row, col] + " ");
            }

            Console.WriteLine();
        }

        //Spiral matrix traverse
        Console.WriteLine("Spiral matrix traverse");
        int[,] matrixD = new int[size, size];

        int top = 0;
        int bottom = size - 1;
        int left = 0;
        int right = size - 1;
        int valueD = 1;

        while (left <= right && top <= bottom)
        {
            // Traverse down the left column
            for (int row = top; row <= bottom; row++)
                matrixD[row, left] = valueD++;
            left++;

            // Traverse right across the bottom row
            for (int col = left; col <= right; col++)
                matrixD[bottom, col] = valueD++;
            bottom--;

            // Traverse up the right column
            for (int row = bottom; row >= top; row--)
                matrixD[row, right] = valueD++;
            right--;

            // Traverse left across the top row
            for (int col = right; col >= left; col--)
                matrixD[top, col] = valueD++;
            top++;
        }

        // Print matrix
        for (int row = 0; row < size; row++)
        {
            for (int col = 0; col < size; col++)
            {
                Console.Write(matrixD[row, col].ToString().PadLeft(3));
            }
            Console.WriteLine();
        }

    }
}