namespace Chapter19;

public static class Exercise06
{
    public static void GetArticles()
    {
        ArticleStore store = new ArticleStore();

        // Добавяне на примерни стоки
        store.AddArticle(new Article { Barcode = "001", Manufacturer = "Sony", Title = "Headphones", Price = 89.99m });
        store.AddArticle(new Article { Barcode = "002", Manufacturer = "LG", Title = "Monitor", Price = 189.99m });
        store.AddArticle(new Article { Barcode = "003", Manufacturer = "HP", Title = "Mouse", Price = 19.99m });
        store.AddArticle(new Article { Barcode = "004", Manufacturer = "Logitech", Title = "Keyboard", Price = 19.99m });
        store.AddArticle(new Article { Barcode = "005", Manufacturer = "Samsung", Title = "SSD", Price = 109.99m });

        Console.WriteLine("Въведи минимална цена:");
        decimal min = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Въведи максимална цена:");
        decimal max = decimal.Parse(Console.ReadLine());

        var result = store.GetArticlesInPriceRange(min, max);

        Console.WriteLine($"\n🛒 Стоки между {min:F2} и {max:F2} лв:\n");
        bool found = false;
        foreach (var article in result)
        {
            Console.WriteLine(article);
            found = true;
        }

        if (!found)
        {
            Console.WriteLine("Няма намерени стоки в този диапазон.");
        }
    }
    
    public class ArticleStore
    {
        private SortedDictionary<decimal, List<Article>> articlesByPrice = new();

        public void AddArticle(Article article)
        {
            if (!articlesByPrice.ContainsKey(article.Price))
                articlesByPrice[article.Price] = new List<Article>();

            articlesByPrice[article.Price].Add(article);
        }

        public IEnumerable<Article> GetArticlesInPriceRange(decimal minPrice, decimal maxPrice)
        {
            foreach (var kvp in articlesByPrice)
            {
                if (kvp.Key > maxPrice)
                    break;

                if (kvp.Key >= minPrice)
                {
                    foreach (var article in kvp.Value)
                        yield return article;
                }
            }
        }
    }
    
    public class Article
    {
        public string Barcode { get; set; }
        public string Manufacturer { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }

        public override string ToString()
            => $"{Title} ({Manufacturer}) - {Price:F2} лв.";
    }

}