namespace Chapter15;

public static class Exercise02
{
    public static void CombineTwoFiles()
    {
        string pathFirst = "../../../ex-2-file-1.txt";
        string pathSecond = "../../../ex-2-file-2.txt";
        string result = "../../../ex-2-result-file.txt";
        
        //string firstContent = File.ReadAllText(pathFirst);
        //string secondContent = File.ReadAllText(pathSecond);

        string firstContent = string.Empty;
        string secondContent  = string.Empty;

        using (StreamReader reader = new StreamReader(pathFirst))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                firstContent += line;
            }
        }

        using (StreamReader reader = new StreamReader(pathSecond))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                secondContent += line;
            }
        }

        using (StreamWriter writer = new StreamWriter(result))
        {
            writer.WriteLine(firstContent);
            writer.WriteLine(secondContent);
        }
    }
}