namespace Chapter04;

public static class AnimalType
{
    public static void Print()
    {
        string animal = Console.ReadLine();
        switch (animal)
        {
            case "dog": Console.WriteLine("mammal"); break;
            case "crocodile":
            case "tortoise":
            case "snake":
                Console.WriteLine("reptile");
                break;
            default: Console.WriteLine("error"); break;
        }
    }
}