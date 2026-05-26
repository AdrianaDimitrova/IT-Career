
using System.Security.Cryptography.X509Certificates;

public class Program
{
    static void Main()
    {
        int booksCount = int.Parse(Console.ReadLine()!);

        List<Book> books = new List<Book>();

        for (int i = 0; i < booksCount; i++)
        { 
            string[] bookInfo = Console.ReadLine()!.Split(", ", StringSplitOptions.RemoveEmptyEntries);

            Book book = new Book();

            book.Title = bookInfo[0];
            book.Author = bookInfo[1];
            book.Pages = int.Parse(bookInfo[2]);

            books.Add(book);

        }

        Console.WriteLine("Книги: ");
        foreach (Book book in books)
        {
            book.Print();
        }
    }
}

