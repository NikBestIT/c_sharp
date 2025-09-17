using KT1.Entities.Base;
using KT1.Extensions;

namespace KT1.Entities;

internal class Library : Building
{
    public string[] Books => _books;
    private readonly string[]  _books;
    
    public Library(string address, string[] books) 
        : base(address)
    {
        _books = books.CheckNotNullOrEmptyOrEmptyElements();
    }
}
