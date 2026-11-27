using System;

public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public double Price { get; set; }

    public Book(string title, string author, double price)
    {
        if (string.IsNullOrWhiteSpace(title))
            throw new ArgumentException("Title cannot be empty");

        if (string.IsNullOrWhiteSpace(author))
            throw new ArgumentException("Author cannot be empty");

        if (price <= 0)
            throw new ArgumentException("Price must be positive");

        Title = title;
        Author = author;
        Price = price;
    }
}
