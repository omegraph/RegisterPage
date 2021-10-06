using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Komodo_Repository
{
    public class DeveloperRepository
    {
        private List<Developer_POCOs> _listOfDeveloper = new List<Developer_POCOs>();

        //Create
        public void AddNewDeveloper(Developer_POCOs developer)
        {
            _listOfDeveloper.Add(developer);
        }

        //Read
        public List<Developer_POCOs> GetDeveloperList()
        {
            return _listOfDeveloper;
        }

        //Update


        //Delete


        

    }
}
