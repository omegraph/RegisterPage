using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Contact one = new Contact("Samir", "Omerani", 31770211133, "233 N Alabama", "Indianapolis", "IN", 46300);

            Console.WriteLine("Address Book App");

            Console.WriteLine("-------------------");
            Console.WriteLine("Contact First Name:");
            string first_name = Console.ReadLine();
            Console.WriteLine("");


            Console.WriteLine("-------------------");
            Console.WriteLine("Contact Last Name:");
            string last_name = Console.ReadLine();
            Console.WriteLine("");


            Console.WriteLine("-------------------");
            Console.WriteLine("Contact Phone:");
            string phone_number = Console.ReadLine();
            Console.WriteLine("");


            Console.WriteLine("-------------------");
            Console.WriteLine("Contact street Address:");
            string street_address = Console.ReadLine();
            Console.WriteLine("");


            Console.WriteLine("-------------------");
            Console.WriteLine("Contact City:");
            string city = Console.ReadLine();
            Console.WriteLine("");


            Console.WriteLine("-------------------");
            Console.WriteLine("Contact State:");
            string state = Console.ReadLine();
            Console.WriteLine("");


            Console.WriteLine("-------------------");
            Console.WriteLine("Contact ZipCode:");
            string zip_code = Console.ReadLine();
            Console.WriteLine("");

            Console.WriteLine("My name is " + first_name + " " + last_name + ", my phone number is " + phone_number + ", my address is " + street_address + " " + city + " " + state + " " + zip_code + ".");
            
            Console.ReadKey();

        }
    }

    internal class Contact
    {
    }
}
