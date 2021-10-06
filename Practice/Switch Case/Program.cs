using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_Case
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            string paymentMethod = string.Empty;

            switch (number) // value that we are testing
            {
                case 0: // if number is equal to 0 run the code below
                    paymentMethod = "MasterCard";
                    break;
                case 1: // if number is equal to 1 run the code below
                    paymentMethod = "Visa";
                    break;
                case 2: // if number is equal to 2 run the code below
                    paymentMethod = "Discover";
                    break;
                case 3:
                    paymentMethod = "American Express";
                    break;
                default:
                    break;
            }

            Console.WriteLine(paymentMethod);
            Console.ReadKey();

        }
    
    }
}
