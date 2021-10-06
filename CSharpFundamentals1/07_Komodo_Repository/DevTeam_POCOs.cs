using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Komodo_Repository
{
    class DevTeam_POCOs
    {
        public string TeamName { get; set; }
        public string TeamIdNumber { get; set; }

        public DevTeam_POCOs() { }

        public DevTeam_POCOs(string teamName, string teamIdNumber)
        {
            TeamName = teamName;
            TeamIdNumber = teamIdNumber;         
        }
    }
}
