using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debugging
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 2;

            num += 5;

            int anotherNum = Add(num, 10);

            Console.WriteLine(anotherNum);

        }

        public static int Add(int a, int b)
        {
            return a + b;
        }
    }


    /* switch case
     * Your company has a third party reporting platform that returns imformation to your clients about Credi Card
     * transactions , one of the fields returned to you is Payment method which is returned in the following format:
     * A zero (integer) means it was prossed on a MasterCard card.
     * A one (integer) means it was prossed on a Visa card.
     * A two (integer) means it was prossed on a Discover card.
     * A three (integer) means it was prossed on a American Express card. */
    static void Main(string[] args)
    {
        int number = 0;
        string paymentMethod = string.Empty;

        switch (number) // value that we are testing
        {
            case 0: // if number is equal to 0 run the code below
                PaymentMethod = "MasterCard";
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

     }
}
}
