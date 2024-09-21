using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace functions_cont
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = ReadInt("Enter first number");
            int secondNumber = ReadInt("Enter second number");
            int result = Add(firstNumber, secondNumber);

            Console.WriteLine("The sum of the two numbers is: "+ result);

        }

        static int ReadInt(string message)
        {
            Console.Write($"{message}: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        static int Add(int num1,[Optional]int num2)
        {
            return num1 + num2;
        }
    }
}
