namespace Chapter07;

public static class Exercise23
{
    public static void Ex23Nonsense()
    {
        Console.Write("Enter number N: ");
        int N = int.Parse(Console.ReadLine());

        int[] arr = new int[N];
        for (int i = 0; i < N; i++)
            arr[i] = i + 1;

        Permute(arr, 0);
    }

    static void Permute(int[] arr, int start)
    {
        if (start == arr.Length)
        {
            Console.WriteLine(string.Join(" ", arr));
            return;
        }

        for (int i = start; i < arr.Length; i++)
        {
            Swap(ref arr[start], ref arr[i]);
            Permute(arr, start + 1);
            Swap(ref arr[start], ref arr[i]);
        }
    }

    static void Swap(ref int a, ref int b)
    {
        if (a == b) return;
        int temp = a;
        a = b;
        b = temp;
    }
}