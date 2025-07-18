namespace Chapter16;

public static class Exercise08
{
    public static void FindMajorant()
    {
        int[] numbers = { 2, 2, 3, 3, 2, 3, 4, 3, 3 };
        int threshold = numbers.Length / 2 + 1;

        Dictionary<int, int> counts = new Dictionary<int, int>();

        foreach (int number in numbers)
        {
            if (counts.ContainsKey(number))
            {
                counts[number]++;
            }
            else
            {
                counts[number] = 1;
            }

            // Early exit if we already found the majorant
            if (counts[number] >= threshold)
            {
                Console.WriteLine($"The majorant is: {number}");
                return;
            }
        }

        Console.WriteLine("The majorant does not exist!");
    }
}