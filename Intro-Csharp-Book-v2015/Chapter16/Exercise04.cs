namespace Chapter16;

public static class Exercise04
{
    public static void FindLongestSubSequence()
    {
        List<int> list = new List<int>() { 1, 2, 2, 4, 11, 3, 7, 5, 5, 5, 5, 21 };
        List<int> longestSubSequence = new List<int>();
        
        int currentCounter = 0;
        int currentElement = 0;

        int counter = 0;
        int element = 0;

        for (int i = 0; i < list.Count - 1; i++)
        {
            if (list[i] == list[i + 1])
            {
                currentElement = list[i];
                currentCounter++;
                
                if (currentCounter > counter)
                {
                    counter = currentCounter;
                    element = currentElement;
                }
            }
        }

        for (int i = 0; i < counter; i++)
        {
            longestSubSequence.Add(element);
        }
        
        longestSubSequence.ForEach(n => Console.Write(n + ", "));
    }
}