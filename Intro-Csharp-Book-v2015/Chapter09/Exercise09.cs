namespace Chapter09;

public static class Exercise09
{
    public static int GetBiggestElementInArrayRange(int start, int end, int[] array)
    {
        int biggestElement = int.MinValue;
        for (int i = start; i < end; i++)
        {
            if(array[i] > biggestElement)
                biggestElement = array[i];
        }
        return biggestElement;
    }
}