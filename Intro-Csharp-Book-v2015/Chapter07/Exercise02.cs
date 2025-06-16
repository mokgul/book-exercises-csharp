namespace Chapter07;

public static class Exercise02
{
    public static void EnterArraysAndCompare()
    {
        Console.WriteLine("Enter number for size of arrays:");
        int size = int.Parse(Console.ReadLine());
        int[] array = new int[size];
        int[] array2 = new int[size];

        Console.WriteLine("First array:");
        for (int i = 0; i < size; i++)
        {
            Console.WriteLine($"Enter array element: {i + 1}/{size}");
            array[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Second array:");
        for (int i = 0; i < size; i++)
        {
            Console.WriteLine($"Enter array element: {i + 1}/{size}");
            array2[i] = int.Parse(Console.ReadLine());
        }

        bool equal = array.SequenceEqual(array2);
        Console.WriteLine($"The two arrays are equal: {equal}");
    }
}