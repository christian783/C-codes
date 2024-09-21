using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string title = ReturnName();

            Console.Title = "A console app";

            printIntroduction(title);

            Console.WriteLine(Environment.UserName);
            Console.ReadLine();
        }

        static string ReturnName ()
        {
            return  "Aba";
        }
        static void printIntroduction(string name) {
            Console.WriteLine($"{name}");
        }
    }
}
