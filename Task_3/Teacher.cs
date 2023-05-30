using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Teacher : Person
    {
        public Teacher (string name, string surname, int age) : base (name, surname, age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }

        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public void Explain ()
        {
            Console.WriteLine("Explaining...");
        }



    }
}
