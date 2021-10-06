using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeveloperApp.POCOs
{
    public class Developer
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string  LastName { get; set; }
        public bool PluralSight { get; set; }
        public static bool HasPluralsight { get; set; }

        public Developer()
        {

        }

        public Developer(string firstName, string lastName, bool pluralSight)
        {
            FirstName = firstName;
            LastName = lastName;
            PluralSight = pluralSight;
        }
    }
}
