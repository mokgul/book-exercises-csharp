namespace Chapter07;

public static class Exercise25
{
    static int N, K;
    static int[] combination;
    public static void Ex25Nonsense()
    {
        Console.Write("Enter N: ");
        N = int.Parse(Console.ReadLine());

        Console.Write("Enter K: ");
        K = int.Parse(Console.ReadLine());

        combination = new int[K];
        GenerateCombinations(0, 1);
    }

    static void GenerateCombinations(int index, int start)
    {
        if (index == K)
        {
            Console.WriteLine("{" + string.Join(", ", combination) + "}");
            return;
        }

        for (int i = start; i <= N; i++)
        {
            combination[index] = i;
            GenerateCombinations(index + 1, i + 1);
        }
    }
}