namespace Chapter07;

public static class Exercise18
{
    public static void QuickSort(int[] array)
    {
        Console.WriteLine("Before sorting:");
        Console.WriteLine(string.Join(", ", array));

        QuickSort(array, 0, array.Length - 1);

        Console.WriteLine("After sorting:");
        Console.WriteLine(string.Join(", ", array));
    }

    static void QuickSort(int[] array, int left, int right)
    {
        if (left < right)
        {
            int pivotIndex = Partition(array, left, right);

            QuickSort(array, left, pivotIndex - 1);  // left part
            QuickSort(array, pivotIndex + 1, right); // right part
        }
    }

    static int Partition(int[] array, int left, int right)
    {
        int pivot = array[right]; // choose the last element as pivot
        int i = left - 1; // index of smaller element

        for (int j = left; j < right; j++)
        {
            if (array[j] <= pivot)
            {
                i++;
                Swap(array, i, j);
            }
        }

        Swap(array, i + 1, right); // move pivot to its correct place
        return i + 1;
    }

    static void Swap(int[] array, int i, int j)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
}