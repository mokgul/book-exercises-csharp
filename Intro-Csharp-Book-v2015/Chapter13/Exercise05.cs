namespace Chapter13;

public static class Exercise05
{
    public static void CountOfKeywordInString()
    {
        string context =
            "We are living in a yellow submarine. We don't have anything else.\nInside the submarine is very tight. So we are drinking all the\nday. We will move out of it in 5 days.";
        string keyword = "in";
        int lastIndex = context.IndexOf(keyword, StringComparison.InvariantCultureIgnoreCase);
        if (lastIndex == -1) return;
        int count = 1;

        while (lastIndex != -1)
        {
            lastIndex = context.IndexOf(keyword, lastIndex + 1);
            if(lastIndex != -1) count++;
        }
        Console.WriteLine(count);
    }
}