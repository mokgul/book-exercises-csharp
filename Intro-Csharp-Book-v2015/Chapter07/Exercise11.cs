namespace Chapter07;

public static class Exercise11
{
    public static void FindArrayElementsEqualToSumNumber(int[] array)
    {
        int startIndex = 0;
        int endIndex = 0;
        int sum = 0;

        Console.WriteLine("Enter number for desired sum:");
        int number = int.Parse(Console.ReadLine());

        for (int i = 0; i < array.Length; i++)
        {
            int currentSum = array[i];
            for (int j = i + 1; j < array.Length; j++)
            {
                currentSum += array[j];
                if (currentSum == number)
                {
                    startIndex = i;
                    endIndex = j;
                }
            }
        }

        for (int i = startIndex; i <= endIndex; i++)
        {
            Console.Write($"{array[i]} ");
        }
    }
}