namespace Chapter13;

public static class Exercise24
{
    public static void ReplaceLetters()
    {
        string text = "aaaaabbbbbcdddeeeedssaa";
        Queue<char> queue = new Queue<char>();

        for (int i = 0; i < text.Length; i++)
        {
            if (i + 1 == text.Length)
                break;
            if(text[i] == text[i + 1])
                continue;
            queue.Enqueue(text[i]);
        }
        Console.WriteLine(string.Join(" ", queue));
    }
}