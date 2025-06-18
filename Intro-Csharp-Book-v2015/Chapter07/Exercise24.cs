namespace Chapter07;

public static class Exercise24
{
    static int N, K;
    static int[] variation;
    public static void Ex24Nonsense()
    {
        Console.Write("Enter N: ");
        N = int.Parse(Console.ReadLine());

        Console.Write("Enter K: ");
        K = int.Parse(Console.ReadLine());

        variation = new int[K];
        GenerateVariations(0);
    }


    static void GenerateVariations(int index)
    {
        if (index == K)
        {
            Console.WriteLine("{" + string.Join(", ", variation) + "}");
            return;
        }

        for (int i = 1; i <= N; i++)
        {
            variation[index] = i;
            GenerateVariations(index + 1);
        }
    }
}