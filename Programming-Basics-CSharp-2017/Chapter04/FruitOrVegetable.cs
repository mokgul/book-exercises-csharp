namespace Chapter04;

public static class FruitOrVegetable
{
    public static void Check()
    {
        string food = Console.ReadLine().ToLower();
        switch (food)
        {
            case "banana":
            case "apple":
            case "kiwi":
            case "cherry":
            case "lemon":
            case "grapes":
                Console.WriteLine("fruit");
                break;

            case "tomato":
            case "cucumber":
            case "pepper":
            case "carrot":
                Console.WriteLine("vegetable");
                break;
            default:
                Console.WriteLine("unknown");
                break;
        }
    }
}