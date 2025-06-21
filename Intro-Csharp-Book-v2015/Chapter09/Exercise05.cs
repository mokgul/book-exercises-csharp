namespace Chapter09;

public static class Exercise05
{
    public static string ElementValueComparedToNeighbours(int index, int[] array)
    {
        int element = array[index];
        bool left = index - 1 > 0 && array[index - 1] < element;
        bool right = index + 1 < array.Length && array[index + 1] < element;
        string result = string.Empty;
        if(left && right)
            result = "Element is bigger than neighbours";
        else if(!left && !right)
            result = "Element is smaller or equal than neighbours";
        else if(!left && right)
            result = "Element is smaller or equal than left but bigger than right";
        else if(left  && !right)
            result = "Element is bigger than left but smaller or equal than right";
        return result;
    }
}