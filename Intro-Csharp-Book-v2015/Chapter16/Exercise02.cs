namespace Chapter16;

public static class Exercise02
{
    public static void NumbersStack(int n)
    {
        Stack<int> stack = new Stack<int>();

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Enter number: ");
            int number = int.Parse(Console.ReadLine());
            stack.Push(number);
        }

        if (stack.Count == 0)
        {
            Console.WriteLine("Empty stack");
            return;
        }

        for (int i = 0; i < n; i++)
        {
            Console.Write(stack.Pop() + " ");
        }
    }
}