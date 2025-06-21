namespace Chapter09;

public static class Exercise06
{
    public static int ReturnIndex(int[] array)
    {
        int index = -1;
        for (int i = 1; i < array.Length; i++)
        {
            if(i + 1 >= array.Length)
                break;
            if(array[i] > array[i-1] && array[i] > array[i+1])
                index = i;
        }
        return index;
    }
}