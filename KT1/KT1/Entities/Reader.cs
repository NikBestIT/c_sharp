using System.Diagnostics;
using KT1.Entities.Base;
using KT1.Extensions;

namespace KT1.Entities;

internal class Reader : Person
{
    public Reader(string firstName, string lastName, int age) 
        : base(firstName, lastName, age.CheckValidAge()) 
    {
    }

    public void ReadBook(Library library, string bookName)
    {
        var b = Array.Find(library.Books, b => string.Equals(b, bookName));
        if (b == null)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Книга не найдена: '{bookName}'");
            Console.ForegroundColor = ConsoleColor.White;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{nameof(Reader)} {FirstName} {LastName} прочитал книгу '{bookName}'");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}



 
