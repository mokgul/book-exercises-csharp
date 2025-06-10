namespace Chapter03;

public static class Exercise10
{
    public static void OperationsOnNumber(int number)
    {
        var numToArray = number.ToString().ToCharArray();
        var sum = numToArray.Sum(c => int.Parse(c.ToString()));
        Console.WriteLine($"The sum of all digits is {sum}");

        var reverse = numToArray.Reverse();
        Console.WriteLine($"The reverse of all digits is {string.Join("", reverse)}");

        (numToArray[0], numToArray[^1]) = (numToArray[^1], numToArray[0]);
        Console.WriteLine($"Array with swapped digits {string.Join("", numToArray)}");

        (numToArray[1], numToArray[2]) = (numToArray[2], numToArray[1]);
        Console.WriteLine($"Array with swapped digits {string.Join("", numToArray)}");
    }
}