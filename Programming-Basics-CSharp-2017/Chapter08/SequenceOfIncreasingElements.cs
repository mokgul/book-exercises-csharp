namespace Chapter08;

public static class SequenceOfIncreasingElements
{
    public static void Print()
    {
        int n = int.Parse(Console.ReadLine());
        int countCurrentLongest = 0;
        int countLongest = 0;
        int aPrev = 0;
        int a = 0;

        for (int i = 0; i < n; i++)
        {
            a = int.Parse(Console.ReadLine());
            if(a > aPrev)
            {
                countCurrentLongest++;
            }
            else
            {
                countCurrentLongest = 1;
            }

            if (countCurrentLongest > countLongest)
            {
                countLongest = countCurrentLongest;
            }
            aPrev = a;
        }
        Console.WriteLine($"{countCurrentLongest} Longest = {countLongest}");
    }
}