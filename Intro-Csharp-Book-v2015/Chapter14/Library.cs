namespace Chapter14;

public class Library
{
    public string Name { get; set; }
    private List<Book> books;

    public Library(string name)
    {
        Name = name;
        books = new List<Book>();
    }

    public void AddBook(Book book)
    {
        books.Add(book);
        Console.WriteLine($"Книгата \"{book.Title}\" е добавена в библиотеката.");
    }

    public void SearchByAuthor(string author)
    {
        var foundBooks = books.Where(b => b.Author.Equals(author, StringComparison.OrdinalIgnoreCase)).ToList();

        if (foundBooks.Any())
        {
            Console.WriteLine($"\nКниги от {author}:");
            foreach (var book in foundBooks)
            {
                book.PrintInfo();
                Console.WriteLine("---------------------");
            }
        }
        else
        {
            Console.WriteLine($"Няма книги от автора {author}.");
        }
    }

    public void ShowBookInfo(string isbn)
    {
        var book = books.FirstOrDefault(b => b.ISBN == isbn);

        if (book != null)
        {
            Console.WriteLine("\nИнформация за книгата:");
            book.PrintInfo();
        }
        else
        {
            Console.WriteLine("Книга с такъв ISBN не е намерена.");
        }
    }

    public void RemoveBook(string isbn)
    {
        var book = books.FirstOrDefault(b => b.ISBN == isbn);

        if (book != null)
        {
            books.Remove(book);
            Console.WriteLine($"Книгата \"{book.Title}\" беше изтрита.");
        }
        else
        {
            Console.WriteLine("Книгата не беше намерена.");
        }
    }
}