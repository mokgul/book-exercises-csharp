namespace Chapter12;

public static class Exercise09
{
    public static void ReadFile()
    {
        var fileName = $"test.txt";
        if (!File.Exists(fileName))
        {
            Console.WriteLine("File does not exist");
            return;
        }

        try
        {
            using (var stream = new StreamReader(fileName))
            {
                string line = stream.ReadLine();
                Console.WriteLine(line);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Something went wrong");
        }

    }
}