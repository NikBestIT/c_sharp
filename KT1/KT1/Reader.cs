using KT1.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace KT1;

internal class Reader : Person
{
    public Reader(string firstName, string lastName, int age) : base(firstName, lastName, age) 
    {
        
    }
    public void ReadBook(Library library, string BookName) 
    {
        if (library == null) 
            Console.WriteLine($"Книга не найдена");
        if (library == Books) 
            Console.WriteLine($"Reader[firstName, lastName] прочитал книгу[Books]");
    }
}



 
