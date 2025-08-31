namespace Chapter03;

public static class EqualWords
{
    public static void Compare()
    {
        string first = Console.ReadLine();
        string second = Console.ReadLine();

        if (first.ToLower().Equals(second.ToLower()))
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
    }
}