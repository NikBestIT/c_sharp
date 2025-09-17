using System.Security.Cryptography.X509Certificates;

public class Person
{
    private string _firstName;
    private string _lastName;
    private int _age { get; set; }


    public string LastName => _lastName;
    public string FirstName => _firstName;
    public int Age => _age;

    public Person(string firstName, string lastName, int age)
    {
        _firstName = firstName;
        _lastName = lastName;
        _age = age;
    }
    protected string GenerateInfo()
    {
        return $"Мое имя {_firstName}/n" + $"Моя фамилия {_lastName}/n" + $"Мне {_age} лет /n";
    }
    public void ShowInfo()
    {
        Console.WriteLine(GenerateInfo());
    }



}




