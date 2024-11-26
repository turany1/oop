using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

public class Library
{
    public class Book
    {
        private string title;
        private string author;
        public void SetInfo(string title,string author)
        {   
            this.title = title;
            this.author = author;
        }
        public void DisplayInfo()
        {
            Console.WriteLine("Title : " + title);
            Console.WriteLine("Author : " + author);
        }
    }
    private List<Book> books;
    public Library()
    {
        books = new List<Book>();
    }

    public void AddBook(string title,string author)
    {
        Book book = new Book();
        book.SetInfo(title,author);
        books.Add(book);
    }

    public void ShowAllBooks()
    {
        foreach (var book in books)
        {
            book.DisplayInfo();
            Console.WriteLine();
        }        
    }
}
class Program
{
    static void Main(string[] args)
    {
        Library library = new Library(); 
        library.AddBook("40 laws of power","Robert Greene");
        library.AddBook("Fight Club","Chuck Palahnuik");
        library.AddBook("Harry Potter","J.K.Rowling");
        library.ShowAllBooks();
    }
}