using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Student : Person
    {
        public Student(string name, string surname, int age) : base(name, surname, age) 
        { 
            Name = name;
            Surname = surname;
            Age = age;
        }
        public string Name { get; set; }
        public string Surname { get; set; } 
        public int Age { get; set; }

        public void Learn ()
        {
            Console.WriteLine("Learning...");
        }

    }
}
