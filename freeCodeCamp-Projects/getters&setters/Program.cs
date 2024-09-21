using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace getters_setters
{
    internal class Program
    {
        class Person
        {
            private string name;
            private int age;

            public string Name
            {
                get
                {
                    return name;
                }
                set
                {
                    name = value;
                }
            }

            public int Age
            {
                get
                {
                    return age;
                }
                set
                {
                    age = value;
                }
            }

            public Person(string name, int age)
            {
                this.name = name;
                this.age = age;
                Name = name;
                Age = age;
            }

            //public void setName(string name)
            //{
            //    this.name = !string.IsNullOrEmpty(name) ? name : "Invalid name";
            //}

            //public string getName() => this.name;

            //public void setAge(int age)
            //{
            //    this.age = age > 1 && age < 150 ? age : -1;
            //}

            //public int getAge() => this.age;

            public void returnDetails()
            {
                Console.WriteLine($"{this.name} - {this.age}");
            }

            public override string ToString()
            {
                return $"{this.Name} - {this.age}";
            }

            public override bool Equals(object obj)
            {
                if (obj is Person)
                {

                Person person = obj as Person;
                return Name.Equals(person.name) && age == person.age;
                    
                }

                return false;
            }

        }
        static void Main(string[] args)
        {

            Person person = new Person("Aba", 23);


            person.Name = "Aba";


            person.Age = 23;

            



            Console.WriteLine($"Hello {person.Name}, you're {person.Age} years old");

        }
    }
}
