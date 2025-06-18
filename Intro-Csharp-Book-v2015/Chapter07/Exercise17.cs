namespace Chapter07;

public static class Exercise17
{
    public static void MergeSort(int[] array)
    {
        Console.WriteLine("Before sorting:");
        Console.WriteLine(string.Join(", ", array));

        MergeSort(array, 0, array.Length - 1);

        Console.WriteLine("After sorting:");
        Console.WriteLine(string.Join(", ", array));
    }

    static void MergeSort(int[] array, int left, int right)
    {
        if (left < right)
        {
            int mid = (left + right) / 2;

            // Recursively sort both halves
            MergeSort(array, left, mid);
            MergeSort(array, mid + 1, right);

            // Merge the sorted halves
            Merge(array, left, mid, right);
        }
    }

    static void Merge(int[] array, int left, int mid, int right)
    {
        int[] temp = new int[right - left + 1];

        int i = left;     // pointer for left half
        int j = mid + 1;  // pointer for right half
        int k = 0;        // pointer for temp array

        while (i <= mid && j <= right)
        {
            if (array[i] <= array[j])
            {
                temp[k++] = array[i++];
            }
            else
            {
                temp[k++] = array[j++];
            }
        }

        // Copy remaining elements from left half (if any)
        while (i <= mid)
        {
            temp[k++] = array[i++];
        }

        // Copy remaining elements from right half (if any)
        while (j <= right)
        {
            temp[k++] = array[j++];
        }

        // Copy sorted temp array back to original array
        for (int m = 0; m < temp.Length; m++)
        {
            array[left + m] = temp[m];
        }
    }
}