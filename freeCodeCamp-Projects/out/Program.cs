using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  @out
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> items = new List<string>
            {
                "coffe","Milk","Banana","Honey"
            };


            Console.WriteLine();
            
        }

        static bool FindInList (string s , List<string> bundle, out int index)
        {
            index = -1;

            for (int i = 0; i < bundle.Count; i++)
            {
                if (bundle[i].ToLower().Equals(s.ToLower()))
                {
                    index = i;
                    break;
                }
            }

            return index > -1;
        }
    }
}
