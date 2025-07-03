namespace Chapter13;

public static class Exercise03
{
    public static void AreBracketsCorrect(string s)
    {
        Stack<char> stack = new Stack<char>();
        foreach (var c in s)
        {
            if (c == '(')
            {
                stack.Push(c);
            }
            else if (c == ')')
            {
                if (stack.Count == 0)
                {
                    Console.WriteLine("Cannot start with closing bracket.");
                    return;
                }
                stack.Pop();
            }
        }

        Console.WriteLine(stack.Count == 0 ? "The brackets are correct." : "The brackets are not correct.");
    }
}