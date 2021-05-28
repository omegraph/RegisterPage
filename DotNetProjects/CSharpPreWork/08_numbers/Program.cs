using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal bill = 54.23m;
            decimal tip = 12m;

            decimal percentage = tip / bill;

            Console.WriteLine(percentage);
            Console.WriteLine(Math.Round(percentage, 2));
            Console.ReadLine();
        }
    }
}
