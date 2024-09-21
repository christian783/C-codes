using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odd_even
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> odd = new List<int>();
            List<int> even = new List<int>();

            for (int i = 1; i < 21; i++)
            {
                if (i % 2 == 0)
                {
                    even.Add(i);
                }
                else { 
                    odd.Add(i);
                }
            }

            Console.WriteLine("Even numbers:");


            foreach (var item in even)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine(Environment.NewLine +"Odd Numbers:");

            foreach (var item in odd)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }
    }
}
