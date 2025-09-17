namespace KT1N;

public class Library: Building
{
    private string[]  _books;
    public string[] Books => _books;
    
    public Library(string address, string[] books) : base(address)
    {
        _books = books;
    }
}