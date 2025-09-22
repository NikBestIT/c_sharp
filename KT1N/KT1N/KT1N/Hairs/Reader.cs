namespace KT1N;

public class Reader: Person
{
    public Reader(string firstName, string lastName, int age) : base(firstName, lastName, age)
    {
        
    }


    public void ReadBook(Library library, string bookName)
    {
        foreach (string book in library.Books)
        {
            if (book.Equals(bookName))
            {
                Console.WriteLine($"{nameof(Reader)} {FirstName} {LastName} прочитал книгу {bookName}");
                return;
            }
        }
        
        Console.WriteLine($"Книга '{bookName}' не найдена");
    }
}

