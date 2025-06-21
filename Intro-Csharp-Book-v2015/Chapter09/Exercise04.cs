namespace Chapter09;

public static class Exercise04
{
    public static int ReturnCountRepeatingElements(int[] array)
    {
        int count = array.GroupBy(x => x).OrderByDescending(g => g.Count()).First().Count();
        return count;
    }
}