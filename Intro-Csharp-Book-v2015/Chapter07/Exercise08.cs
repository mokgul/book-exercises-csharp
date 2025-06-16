namespace Chapter07;

public static class Exercise08
{
    public static void ArraySelectionSort(int[] arr)
    {
        int[] sorted = new int[arr.Length];

        for (int i = 0; i < arr.Length; i++)
        {
            int smallest = int.MaxValue;
            for (int j = 0; j < arr.Length; j++)
            {
                if(arr[j] < smallest && arr[j] != int.MinValue)
                    smallest = arr[j];
            }
            sorted[i] = smallest;
            for (int j = 0; j < arr.Length; j++)
            {
                if(arr[j] == smallest)
                    arr[j] = int.MinValue;
            }
        }

        Console.WriteLine(string.Join(", ", sorted));
    }
}