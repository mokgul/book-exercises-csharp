using System.Text.RegularExpressions;

namespace Chapter15;

public static class Exercise13
{
    public static void CountWords()
    {
        string wordsFilePath = "words.txt";
        string textFilePath = "text.txt";
        string resultFilePath = "result.txt";

        try
        {
            var targetWords = File.ReadAllLines(wordsFilePath)
                                  .Where(line => !string.IsNullOrWhiteSpace(line))
                                  .Select(word => word.Trim().ToLower())
                                  .ToList();
            
            Dictionary<string, int> wordCounts = new Dictionary<string, int>();
            
            string textContent = File.ReadAllText(textFilePath).ToLower();
            
            string[] allWords = Regex.Matches(textContent, @"\b[a-zA-Z0-9_]+\b")
                                     .Cast<Match>()
                                     .Select(m => m.Value)
                                     .ToArray();
            
            foreach (string word in targetWords)
            {
                int count = allWords.Count(w => w == word);
                wordCounts[word] = count;
            }
            
            var sortedResults = wordCounts.OrderByDescending(kv => kv.Value);

            using (StreamWriter writer = new StreamWriter(resultFilePath))
            {
                foreach (var kvp in sortedResults)
                {
                    writer.WriteLine($"{kvp.Key} -> {kvp.Value}");
                }
            }

            Console.WriteLine("Броенето завърши успешно. Резултатите са записани в result.txt");
        }
        catch (FileNotFoundException ex)
        {
            Console.WriteLine("Грешка: Файлът не е намерен -> " + ex.FileName);
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("Грешка: Нямате достъп до един от файловете.");
        }
        catch (IOException ex)
        {
            Console.WriteLine("Грешка при работа с файловете: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Непредвидена грешка: " + ex.Message);
        }
    }
}