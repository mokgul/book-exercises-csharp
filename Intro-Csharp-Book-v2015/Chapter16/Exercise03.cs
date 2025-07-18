namespace Chapter16;

public static class Exercise03
{
    public static void SortNumbers()
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
        
        numbers = numbers.OrderBy(n => n).ToList();
        numbers.ForEach(n => Console.Write(n + " "));
    }
}