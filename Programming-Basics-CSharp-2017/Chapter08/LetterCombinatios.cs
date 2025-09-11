namespace Chapter08;

public static class LetterCombinatios
{
    public static void Solve()
    {
        char start = char.Parse(Console.ReadLine());
        char end = char.Parse(Console.ReadLine());
        char skip = char.Parse(Console.ReadLine());
        int count = 0;

        for (char i = start; i <= end; i++)
        {
            for (char j = start; j <= end; j++)
            {
                for (char k = start; k <= end; k++)
                {
                    if (i != skip && j != skip && k != skip)
                    {
                        Console.Write($"{i}{j}{k} ");
                        count++;
                    }
                }
            }
        }
        Console.WriteLine(count);
    }
}