namespace Chapter07;

public static class Exercise03
{
    public static void CompareCharArrays()
    {
        Console.WriteLine("Enter number for size of arrays:");
        int size = int.Parse(Console.ReadLine());
        char[] array = new char[size];
        char[] array2 = new char[size];

        Console.WriteLine("First array:");
        for (int i = 0; i < size; i++)
        {
            Console.WriteLine($"Enter array element: {i + 1}/{size}");
            array[i] = char.Parse(Console.ReadLine());
        }

        Console.WriteLine("Second array:");
        for (int i = 0; i < size; i++)
        {
            Console.WriteLine($"Enter array element: {i + 1}/{size}");
            array2[i] = char.Parse(Console.ReadLine());
        }

        int equal = 0;
        for (int i = 0; i < size; i++)
        {
            if (array[i] < array2[i])
                equal = 1;
            else if (array[i] > array2[i])
                equal = 2;
        }

        string output = equal switch
        {
            0 => "The two arrays are equal",
            1 => "The first array is lexicographically earlier.",
            2 => "The second array is lexicographically earlier.",
        };
        Console.WriteLine(output);
    }
}