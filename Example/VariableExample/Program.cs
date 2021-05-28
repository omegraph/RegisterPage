using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Namespace is where all c# code lives
namespace VariableExample
{
    //Class is a custom type
    class Program
    {
        //Method where all executable code lives
        static void Main(string[] args)
        {
            int a = 5;
            int b = a + 4;
            int c = 100;
            bool isGreater = a > b;
            Console.WriteLine(isGreater);
            Console.ReadLine();


            bool isTrue = 7 < 6;
            if (isTrue)
            {
                Console.WriteLine("Helloe World");
            }
            else
                Console.WriteLine("Else Statment");
            

        }
    }
}
