namespace KT1N;

public class Person
{
    private string _firstName;
    public string FirstName => _firstName;
    private string _lastName;
    public string LastName => _lastName;
    private int _age;
    public int Age => _age;

    public Person(string firstName, string lastName, int age)
    {
        if (age <= 0)
        {
            throw new ArgumentException("Возраст должен быть > 0");
        }
        _firstName = firstName;
        _lastName = lastName;
        _age = age;
        
    }
}