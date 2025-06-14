namespace Chapter05;

public static class Exercise03
{
    public static void BiggestNumber(int a, int b, int c)
    {
        Console.WriteLine("Using if statements:");
        if (a > b && a > c)
            Console.WriteLine($"Biggest number: {a}");
        else if (b > a && b > c)
            Console.WriteLine($"Biggest number: {b}");
        else if (c > a && c > b)
            Console.WriteLine($"Biggest number: {c}");

        Console.WriteLine("Using Math Library:");
        int biggest = Math.Max(a, Math.Max(b, c));
        Console.WriteLine($"Biggest number: {biggest}");

        Console.WriteLine("Using ternary operators:");
        int bi = a > b && a > c ? a : b > a && b > c ? b : c;
        Console.WriteLine($"Biggest number: {bi}");
    }
}