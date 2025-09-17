using KT1.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT1.Entities.Base;

internal class Person
{

    private string _firstName;
    private string _lastName;
    private int _age;

    public string FirstName => _firstName;
    public string LastName => _lastName;
    public int Age => _age;


    public Person(string firstName, string lastName, int age)
    {
        _firstName = firstName;
        _lastName = lastName;
        _age = age.CheckGreaterThan(0);
    }


    protected string GenerateInfo()
    {
        return $"Мое имя {_firstName}\n" + $"Моя фамилия {_lastName}\n" + $"Мне {_age} лет";
    }

    public void ShowInfo()
    {
        Console.WriteLine(GenerateInfo());
    }
}
