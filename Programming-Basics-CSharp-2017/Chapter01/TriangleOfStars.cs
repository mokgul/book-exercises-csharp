namespace Chapter01;

public static class TriangleOfStars
{
    public static void PrintStars(int n)
    {
        int counter = 1;
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(new string('*', i));
            counter += i;
            if (counter >= n)
                break;
        }
            
    }
}