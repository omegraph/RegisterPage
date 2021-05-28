using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string myName;
            string wholeName = "Douglas Crockford";
            string first = "The cars we sell are ";
            string second = "BMW, Lexus, and Mercedes.";
            Console.WriteLine(first + second);
            //result: The cars we sell are BMW, Lexus, and Mercedes.

            Console.WriteLine(first + "" + second);

            string firstName = "Robin";
            string lastName = "Holler";
            Console.WriteLine($"Her name is {firstName} {lastName}");

        }
    }
}
