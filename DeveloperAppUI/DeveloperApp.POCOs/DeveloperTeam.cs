using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeveloperApp.POCOs
{
    public class DeveloperTeam
    {
        public int ID { get; set; }
        public string TeamName { get; set; }
        public List<Developer> TeamMembers { get; set; } = new List<Developer>();

        public DeveloperTeam()
        {

        }

        public DeveloperTeam(string teamName,List<Developer>teamMembers)
        {
            TeamName = teamName;
            TeamMembers = teamMembers;
        }
    }
}
