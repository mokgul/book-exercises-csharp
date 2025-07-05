namespace Chapter13;

public static class Exercise10
{
    public static void ExtractSentencesByKeyword(string keyword)
    {
        string text =
            "We are living in a yellow submarine. We don't have anything else.\nInside the submarine is very tight. So we are drinking all the\nday. We will move out of it in 5 days.";
        string[] sentences = text.Split(".");

        foreach (string sentence in sentences)
        {
            if (sentence.ToLower().Contains(keyword))
                Console.WriteLine(sentence);
        }
    }
}