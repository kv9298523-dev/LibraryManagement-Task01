using System;
using System.Collections.Generic;

public class Library
{
    private readonly List<Book> books = new List<Book>();

    public void AddBook(Book book)
    {
        if (book == null)
            throw new ArgumentNullException(nameof(book));

        books.Add(book);
        Console.WriteLine("Book added successfully!");
    }

    public void DisplayBooks()
    {
        Console.WriteLine("\n===== Library Books =====");

        foreach (Book book in books)
        {
            Console.WriteLine("Title: " + book.Title);
            Console.WriteLine("Author: " + book.Author);
            Console.WriteLine("Price: Rs. " + book.Price);
            Console.WriteLine("-------------------------");
        }
    }
}
