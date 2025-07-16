namespace Chapter15;

public static class Exercise01
{
    public static void ReadFileAndWriteOddLines()
    {
        string path = "../../../task.txt";
        int counter = 0;

        using (StreamReader reader = new StreamReader(path))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                counter++;
                if (counter % 2 == 1)
                {
                    Console.WriteLine($"Line {counter}: {line}");
                }
            }
        }
    }
}