using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructors
{
    internal class Program
    {
       class Person
        {
            public string name;
            public int age;
            public int birthday;

            public Person(string name,int age,int birthday)
            {
                this.name = name;
                this.age = age;
                this.birthday = birthday;

            }

            public string ReturnDetails()
            {
                return $"Name: {name} - Age: {age} - birthday: {birthday}";
            }
        }
        static void Main(string[] args)
        {
            Person person = new Person("Aba", 45,22);

            Console.WriteLine(person.ReturnDetails());
        }
    }
}
