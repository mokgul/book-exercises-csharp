namespace Chapter14;

public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string Publisher { get; set; }
    public int Year { get; set; }
    public string ISBN { get; set; }

    public Book(string title, string author, string publisher, int year, string isbn)
    {
        Title = title;
        Author = author;
        Publisher = publisher;
        Year = year;
        ISBN = isbn;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Publisher: {Publisher}");
        Console.WriteLine($"Year: {Year}");
        Console.WriteLine($"ISBN: {ISBN}");
    }
}