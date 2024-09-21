using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //    Dictionary<int,string> names = new Dictionary<int, string>
            //    {
            //        { 1, "Aba" },
            //        { 1, "Aba" },
            //        { 2, "john" },
            //        { 3, "Mary" }
            //    };

            //    for (int i = 0; i < names.Count; i++)
            //    {
            //        KeyValuePair<int, string> pair = names.ElementAt(i);

            //        Console.WriteLine($"{pair.Key} - {pair.Value}");
            //    }

            Dictionary<string, string> teachers = new Dictionary<string, string> {

                {"Math","Aba"},
                {"Science" , "mcGrady" }
            };

            if(teachers.TryGetValue("Science",out string teacher)){

                Console.WriteLine(teacher);

                teachers["Math"] = "joe";
            }
            else
            {
                Console.WriteLine("Math teacher not found");
            }

            if (teachers.ContainsKey("Math"))
            {
                teachers.Remove("Math");
            }

            foreach (KeyValuePair<string,string> item in teachers)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
            
        }
    }
}
