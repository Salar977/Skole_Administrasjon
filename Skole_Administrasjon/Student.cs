using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skole_Administrasjon
{
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Student(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public void Info()
        {
            Console.WriteLine($"Navn: {Name}\nAge: {Age}");
        }
    }
}   
