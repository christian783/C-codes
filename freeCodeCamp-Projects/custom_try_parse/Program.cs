using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace custom_try_parse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            string integer = Console.ReadLine();

            bool conversion = tryParse(integer, out int number);

            Console.WriteLine(number);

            Console.WriteLine(conversion);



        }

        static bool tryParse(string num,out int number)
        {
            try
            {
                number = Convert.ToInt32(num);
                return true;
            }
            catch (FormatException)
            {
                number = 0;
               return false;
            }
            catch (OverflowException)
            {
                number = 0;
                return false;
            }
        }
    }
}
