using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace structures
{
    internal class Program
    {
        struct Person
        {
           public string name;
           public int age;
           public int birthday;

           public Person(string name, int age, int birthday)
            {
                this.name = name;
                this.age = age;
                this.birthday = birthday;
            }
        }
        static void Main(string[] args)
        {
            Person person = new Person("Aba", 17, 2);
            Console.WriteLine($"{person.name}-{person.age}-{person.birthday}");
        }
    }
}
