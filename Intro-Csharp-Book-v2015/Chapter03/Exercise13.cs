namespace Chapter03;

public static class Exercise13
{
    public static void CheckValue(int n, int p, int v)
    {
        n = (v == 1)
            ? n | (1 << p)       // Задаване на 1 на позиция p
            : n & ~(1 << p);     // Задаване на 0 на позиция p
        Console.WriteLine(n);
    }
}