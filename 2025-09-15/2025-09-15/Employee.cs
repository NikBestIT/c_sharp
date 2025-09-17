using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2025_09_15
{
    internal class ConstructionEmployee : Employee
    {
        private int _salary;
        private int _position;


        public int Salary => _salary;
        public int Position => _position;
    }
    public ConstructionPerson(string firstName, string lastName, int age, int Salary, int Position) : base()
        {

        }
    protected string GenerateInfo()
        {
            return base.GenerateInfo + $"Моя зарплата {_salary}/n" + $"Моя позиция {_position}";
        }
        public void ShowInfo()
        {
            Console.WriteLine(GenerateInfo());
        }

    }
}

