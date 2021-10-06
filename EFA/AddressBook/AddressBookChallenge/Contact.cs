using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookChallenge
{
    public class Person
    {
        public string FirstName { get; set; }
        
        public string LastName { get; set; }
        
        public long PhoneNumber { get; set; }
        
        public string StreetAddress { get; set; }
      
        public string City { get; set; }
        
        public string State { get; set; }
        
        public int ZipCode { get; set; }


        public Person(String first_name, String last_name, long phone_number, String street_address, String city, String state, int zip_code)
        {
            FirstName = first_name;
            LastName = last_name;
            PhoneNumber = phone_number;
            StreetAddress = street_address;
            City = city;
            State = state;
            ZipCode = zip_code;

        }
        
    }
}
