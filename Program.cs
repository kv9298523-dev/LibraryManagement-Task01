using System;

class Program
{
    static void Main()
    {
        Library library = new Library();

        try
        {
            Book b1 = new Book("C# Programming", "John", 450);
            Book b2 = new Book("Data Structures", "Mark", 550);

            library.AddBook(b1);
            library.AddBook(b2);

            library.DisplayBooks();
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
