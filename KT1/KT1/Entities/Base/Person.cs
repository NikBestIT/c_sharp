using KT1.Extensions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT1.Entities.Base;

[DebuggerDisplay("{FirstName} {LastName} [{Age}]")]
public abstract class Person
{
    public string FirstName => _firstName;
    private string _firstName;
    
    public string LastName => _lastName;
    private string _lastName;
    
    public int Age => _age;
    private int _age;

    protected Person(string firstName, string lastName, int age)
    {
        _firstName = firstName.CheckNotNullOrEmptyOrWhiteSpace();
        _lastName = lastName.CheckNotNullOrEmptyOrWhiteSpace();
        _age = age.CheckGreaterThan(0);
    }

    public override string ToString()
    {
        return $"({base.ToString()}) {FirstName} {LastName} [{Age}]";
    }
}
