namespace Chapter16;

public static class Exercise01
{
    public static void ListSum()
    {
        string line;
        List<int> numbers = new List<int>();

        while ((line = Console.ReadLine()) != "")
        {
            bool valid = int.TryParse(line, out var number);
            if (valid)
                numbers.Add(number);
        }

        if (numbers.Count == 0)
        {
            Console.WriteLine("Empty list");
            return;
        }
        Console.WriteLine($"The sum of all numbers is: {numbers.Sum()}");
        Console.WriteLine($"The average of all numbers is: {numbers.Average()}");
    }
}