namespace Chapter10;

public static class Exercise15
{
    public static void PrintAllFolders()
    {
        string rootPath = @"C:\";

        try
        {
            TraverseDirectory(rootPath, 0);
        }
        catch (UnauthorizedAccessException e)
        {
            Console.WriteLine("Нямате достъп до някои папки: " + e.Message);
        }
        catch (Exception e)
        {
            Console.WriteLine("Възникна грешка: " + e.Message);
        }
    }

    static void TraverseDirectory(string path, int indentLevel)
    {
        // Отпечатваме текущата папка с отстъп
        Console.WriteLine(new string(' ', indentLevel * 2) + Path.GetFileName(path));

        string[] directories = new string[0];
        string[] files = new string[0];

        try
        {
            directories = Directory.GetDirectories(path);
            files = Directory.GetFiles(path);
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine(new string(' ', (indentLevel + 1) * 2) + "Нямате достъп");
            return;
        }
        catch (Exception ex)
        {
            Console.WriteLine(new string(' ', (indentLevel + 1) * 2) + "Грешка: " + ex.Message);
            return;
        }

        // Печатаме файловете
        foreach (var file in files)
        {
            Console.WriteLine(new string(' ', (indentLevel + 1) * 2) + Path.GetFileName(file));
        }

        // Рекурсивно обхождаме поддиректориите
        foreach (var dir in directories)
        {
            TraverseDirectory(dir, indentLevel + 1);
        }
    }
}