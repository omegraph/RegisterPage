using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookChallenge
{
    public class Address
    {
        public string StreetAddress { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public int ZipCode { get; set; }

        public Address()
        {
            Console.WriteLine("Contact street Address:");
            string StreetAddress = Console.ReadLine();
        }

    }
}
