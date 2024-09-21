using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = ReadInt("Enter the height");
            int num2 = ReadInt("Enter the width");
            int area = calcArea(num1, num2);

            Console.WriteLine("The area is "+area);
        


        }

        static int calcArea(int num1 , int num2)
        {
            return (num1 * num2)/2;
        }

        static int ReadInt(string message)
        {
            Console.Write($"{message}: ");
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
