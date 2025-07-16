using System.Text;

namespace Chapter15;

public static class Exercise03
{
    public static void UpdateFile()
    {
        string path = "../../../task.txt";
        int counter = 1;
        StringBuilder sb = new StringBuilder();

        using (StreamReader reader = new StreamReader(path))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                sb.AppendLine(line);
            }
        }
        
        using (StreamWriter writer = new StreamWriter(path))
        {
            string[] parts = sb.ToString().Split('\n');
            foreach (string line in parts)
            {
                writer.WriteLine($"{counter++}. {line}");
            }
        }
    }
}