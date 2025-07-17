using System.Text;

namespace Chapter15;

public static class Exercise09
{
    public static void DeleteRowsFromFile(string fileName)
    {
        StringBuilder sb =  new StringBuilder();
        int row = 0;
        
        using (var reader = new StreamReader(fileName))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                if(row % 2 != 0) sb.Append(line);
                row++;
            }
        }
        
        File.WriteAllText(fileName, sb.ToString());
    }
}