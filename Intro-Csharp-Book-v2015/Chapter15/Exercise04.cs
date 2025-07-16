namespace Chapter15;

public static class Exercise04
{
    public static void CompareFiles()
    {
        string path1 = "../../../file1.txt";
        string path2 = "../../../file2.txt";

        int matchingLines = 0;
        int differentLines = 0;

        try
        {
            using (StreamReader reader1 = new StreamReader(path1))
            using (StreamReader reader2 = new StreamReader(path2))
            {
                string line1, line2;

                while ((line1 = reader1.ReadLine()) != null &&
                       (line2 = reader2.ReadLine()) != null)
                {
                    if (line1 == line2)
                        matchingLines++;
                    else
                        differentLines++;
                }
            }

            Console.WriteLine($"Equal rows: {matchingLines}");
            Console.WriteLine($"Different rows: {differentLines}");
        }
        catch (FileNotFoundException e)
        {
            Console.WriteLine("Missing file.");
            Console.WriteLine(e.Message);
        }
        catch (Exception e)
        {
            Console.WriteLine("Something went wrong.");
            Console.WriteLine(e.Message);
        }
    }
}