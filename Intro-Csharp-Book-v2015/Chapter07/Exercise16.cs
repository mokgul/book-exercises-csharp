namespace Chapter07;

public static class Exercise16
{
    public static void BinarySearch(int[] array, int value)
    {
        int index = -1;
        int start = 0;
        int end = array.Length - 1;
        while (start <= end)
        {
            int mid = (end - start)/2 + start;
            if (array[mid] == value)
            {
                index = mid;
                break;
            }

            if (value < array[mid])
            {
                end = mid - 1;
            }
            else
            {
                start = mid + 1;
            }
        }
        Console.WriteLine(index == -1 ? "No such element found" : $"The index of {value} in the array is {index}");
    }
}