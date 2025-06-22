namespace Chapter10;

public static class Exercise01
{
    public static void PrintNLoops(int n)
    {
        List<int> current = new List<int>();
        SimulateNestedLoops(n, 0, current);
    }

    static void SimulateNestedLoops(int n, int depth, List<int> current)
    {
        if (depth == n)
        {
            Console.WriteLine(string.Join(" ", current));
            return;
        }

        for (int i = 1; i <= n; i++)
        {
            current.Add(i);
            SimulateNestedLoops(n, depth + 1, current);
            current.RemoveAt(current.Count - 1);
        }
    }
}