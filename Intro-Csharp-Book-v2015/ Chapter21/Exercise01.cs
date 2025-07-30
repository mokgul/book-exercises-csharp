namespace Chapter21;

public class Exercise01
{
    static void Main()
    {
        Console.WriteLine("Please enter a number between 1 and 10:");
        int value = int.Parse(Console.ReadLine());
        int i = 5;
        int w = 0;

        switch (value)
        {
            case 10:
                w = 5;
                Console.WriteLine(w);
                break;
            case 9:
                i = 0;
                break;
            case 8:
                Console.WriteLine("8 ");
                break;
            default:
                Console.WriteLine("def ");
                Console.WriteLine("hoho ");
                for (int k = 0; k < i; k++)
                {
                    Console.WriteLine(k - 'f');
                }
                break;
        }

        {
            Console.WriteLine("loop!");
        }
    }
}