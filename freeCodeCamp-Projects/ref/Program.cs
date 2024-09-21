using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @ref
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "joe";

            Console.Write("Type your new name: ");
            string NewName = Console.ReadLine();

            ChangeName(ref name , NewName);

            Console.WriteLine($"New name: {name}");

        }
        static bool ChangeName(ref string name, string NewName)
        {
            if (!String.IsNullOrEmpty(NewName))
            {
                name = NewName;

                return true;
            }

            return false;
        }

    }


}
