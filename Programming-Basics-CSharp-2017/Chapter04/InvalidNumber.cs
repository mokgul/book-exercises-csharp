namespace Chapter04;

public static class InvalidNumber
{
    public static void Check()
    {
        var number = int.Parse(Console.ReadLine());
        var inRange = (number >= 100 &&  number <= 200) || number == 0;
        if (!inRange)
            Console.WriteLine("Number is out of range");
        else
        {
            Console.WriteLine("Number is in range");
        }
    }
}