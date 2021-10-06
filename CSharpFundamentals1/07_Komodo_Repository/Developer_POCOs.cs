using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Komodo_Repository
{
    public class Developer_POCOs
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DeveloperIdNumber { get; set; }
        public bool HasToPluralsight { get; set }


        public Developer_POCOs() { }

        public Developer_POCOs(string firstName, string lastName, string developerIdNumber, bool hasToPluralsight)
        {
            FirstName = firstName;
            LastName = lastName;
            DeveloperIdNumber = developerIdNumber;
            HasToPluralsight = hasToPluralsight;
        }

    }


}
