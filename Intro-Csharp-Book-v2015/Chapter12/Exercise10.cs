namespace Chapter12;

public static class Exercise10
{
    public static void ReadWriteBinaryFile(string inputPath)
    {
        string outputPath = "test_output.bin";


        try
        {
            // Прочитане
            byte[] content = ReadBinaryFile(inputPath);

            // Запис
            WriteBinaryFile(outputPath, content);

            Console.WriteLine("Файлът беше успешно копиран.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Грешка: " + ex.Message);
        }
    }

    private static byte[] ReadBinaryFile(string inputFilePath)
    {
        if (!File.Exists(inputFilePath))
            throw new FileNotFoundException("Файлът не съществува.", inputFilePath);

        return File.ReadAllBytes(inputFilePath);
    }

    // Метод за запис на бинарно съдържание в нов файл
    private static void WriteBinaryFile(string outputFilePath, byte[] data)
    {
        File.WriteAllBytes(outputFilePath, data);
    }
}