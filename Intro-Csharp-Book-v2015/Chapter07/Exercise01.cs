namespace Chapter07;

public static class Exercise01
{
    public static void InitializeArrayWithValues()
    {
        int[] array = new int[20];
        for (int i = 0; i < 20; i++)
        {
            array[i] = i * 5;
        }
        foreach (var value in array)
            Console.Write(value + ", ");
    }
}