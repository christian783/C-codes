using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    internal class Program
    {
        class Person
        {
            private string name;
            private int age;

            public Person(string name, int age)
            {
                this.name = name;
                this.age = age;
            }

            public void setName(string name)
            {
                this.name = !string.IsNullOrEmpty(name) ? name : "Invalid name";
            }

            public string getName() => this.name;

            public void setAge(int age)
            {
                this.age = age > 1 && age < 150 ? age : -1;
            }

            public int getAge() => this.age;

            public void returnDetails()
            {
                Console.WriteLine($"{this.name} - {this.age}");
            }

        }
        static void Main(string[] args)
        {

            Person person = new Person("Aba",23);

            person.setName("Christian");

            person.setAge(23);


            string myName = person.getName();

            int myAge = person.getAge();



            Console.WriteLine($"Hello {myName}, you're {myAge} years old");

        }
    }
}
