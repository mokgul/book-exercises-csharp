namespace Chapter10;

public static class Exercise06
{
    public static void MergeSortRecursive(int[] array)
    {
        MergeSort(array, 0, array.Length - 1);
        Console.WriteLine(string.Join(", ", array));
    }

    static void MergeSort(int[] array, int left, int right)
    {
        if (left < right)
        {
            int mid = (left + right) / 2;

            // Рекурсивно сортираме двете половини
            MergeSort(array, left, mid);
            MergeSort(array, mid + 1, right);

            // Сливаме двете сортирани половини
            Merge(array, left, mid, right);
        }
    }

    static void Merge(int[] array, int left, int mid, int right)
    {
        int n1 = mid - left + 1;
        int n2 = right - mid;

        int[] leftArray = new int[n1];
        int[] rightArray = new int[n2];

        for (int i = 0; i < n1; i++)
            leftArray[i] = array[left + i];
        for (int j = 0; j < n2; j++)
            rightArray[j] = array[mid + 1 + j];

        int iIndex = 0, jIndex = 0, k = left;

        while (iIndex < n1 && jIndex < n2)
        {
            if (leftArray[iIndex] <= rightArray[jIndex])
            {
                array[k] = leftArray[iIndex];
                iIndex++;
            }
            else
            {
                array[k] = rightArray[jIndex];
                jIndex++;
            }
            k++;
        }

        // Копираме останалите елементи от левия масив
        while (iIndex < n1)
        {
            array[k] = leftArray[iIndex];
            iIndex++;
            k++;
        }

        // Копираме останалите елементи от десния масив
        while (jIndex < n2)
        {
            array[k] = rightArray[jIndex];
            jIndex++;
            k++;
        }
    }
}