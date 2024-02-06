// lab3 Initialization Exercise
using System;

class Book
{
    private string title;
    private string author;
    private bool available;
   
    public Book(string title, string author, bool available)
    {
        this.title = title; 
        this.author = author;
        this.available = available;
        Console.WriteLine($"the title of the book is {title}");
        Console.WriteLine($"The author of the book is {author}");
        console.writeLine($"the book is{available}");
    }
}
class BookTest
{
    static void Main(string[] args)
    {
        Book book = new Book("the life", "Bharath", true);
    }
}
