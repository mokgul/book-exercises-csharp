namespace Chapter11;

public static class Exercise10
{
    public static void SumOfStringNumbers(string numbers)
    {
        int sum = numbers.Split().Select(x => int.Parse(x)).Sum();
        Console.WriteLine(sum);
    }
}