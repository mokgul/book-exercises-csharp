namespace Chapter11;

public static class Exercise05
{
    public static void CalculateHypothesis()
    {
        Console.WriteLine("Enter cath a: ");
        var a = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter cath b: ");
        var b = double.Parse(Console.ReadLine());

        double hypothesis = Math.Sqrt(a * a + b * b);
        Console.WriteLine("Hypothesis = " + hypothesis);
    }
}