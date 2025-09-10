namespace Chapter07;

public static class UnsafePasswordGenerator
{
    public static void PrintPasswords()
    {
        int n = int.Parse(Console.ReadLine());
        int l = int.Parse(Console.ReadLine());

        for (int d1 = 1; d1 <= n; d1++)
        {
            for (int d2 = 1; d2 <= n; d2++)
            {
                for (int i = 0; i < l; i++)
                {
                    char c1 = (char)('a' + i);
                    for (int j = 0; j < l; j++)
                    {
                        char c2 = (char)('a' + j);
                        for (int d5 = 1; d5 <= n; d5++)
                        {
                            if (d5 > d1 && d5 > d2)
                            {
                                Console.Write($"{d1}{d2}{c1}{c2}{d5} ");
                            }
                        }
                    }
                }
            }
        }
    }
}