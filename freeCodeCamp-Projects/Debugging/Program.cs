using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Debugging
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Aba";
            int age;
            age = 13;

            PrintDetails(name, age);

            Console.ReadLine();
        }

        static void PrintDetails(string name,int age)
        {
            Console.WriteLine($"{name} - {age}");
            Console.WriteLine($"{name} - {age}");
            Console.WriteLine($"{name} - {age}");
        }
    }
}
