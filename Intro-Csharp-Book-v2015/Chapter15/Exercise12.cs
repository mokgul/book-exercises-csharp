using System.Text.RegularExpressions;

namespace Chapter15;

public static class Exercise12
{
    public static void DeleteSameWords()
    {
        string textFilePath = "text.txt";
        string wordsFilePath = "words.txt";

        try
        {
            var wordsToRemove = new HashSet<string>(
                File.ReadAllLines(wordsFilePath),
                StringComparer.OrdinalIgnoreCase
            );
            
            string text = File.ReadAllText(textFilePath);
            
            string pattern = @"\b(" + string.Join("|", wordsToRemove.Select(Regex.Escape)) + @")\b";
            string result = Regex.Replace(text, pattern, "", RegexOptions.IgnoreCase);
          
            result = Regex.Replace(result, @"\s+", " ").Trim();
            
            File.WriteAllText(textFilePath, result);

            Console.WriteLine("Нежеланите думи бяха премахнати успешно.");
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine("Файлът не беше намерен: " + ex.FileName);
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("Нямате достъп до един от файловете.");
        }
        catch (IOException ex)
        {
            Console.WriteLine("Грешка при работа с файл: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Непредвидена грешка: " + ex.Message);
        }
    }
}