namespace Chapter15;

public static class Exercise06
{
    public static void SortNames()
    {
        string inputPath = "../../../names.txt";
        string outputPath = "../../../outputNamesSorted.txt";
        
        List<string> names = new List<string>();

        using (var reader = new StreamReader(inputPath))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                names.Add(line);
            }
        }
        
        names = names.OrderBy(n => n).ToList();

        using (var writer = new StreamWriter(outputPath))
        {
            foreach (var name in names)
            {
                writer.WriteLine(name);
            }
        }
    }
}