using DeveloperApp.POCOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeveloperApp.Repository
{
    public class DeveloperRepository
    {
        private readonly List<Developer> _developerDatabase = new List<Developer>();
        private int _Count = 0;
        public bool AddDeveloper(Developer developer)
        {
            if (developer is null)
            {
                return false;
            }

            _Count++;
            developer.ID = _Count;
            _developerDatabase.Add(developer);
            return true;
        }

        public IEnumerable<Developer> GetDeveloper()
        {
            return _developerDatabase;
        }

        public Developer GetDeveloperByID(int id)
        {
            foreach (var developer in _developerDatabase)
            {
                if (developer.ID==id)
                {
                    return developer;
                }
            }
            return null;
        }


        public bool UpdateDeveloper(int id, Developer newDeveloperData)
        {
            Developer oldDeveloperData = GetDeveloperByID(id);

            if (oldDeveloperData is null)
            {
                return false;
            }
            else
            {
                oldDeveloperData.ID = id;
                oldDeveloperData.FirstName = newDeveloperData.FirstName;
                oldDeveloperData.LastName = newDeveloperData.LastName;
                oldDeveloperData.PluralSight = newDeveloperData.PluralSight;

                return true;
            }

        }

        public bool DeleteDeveloper(int id)
        {
            foreach (var developer in _developerDatabase)
            {
                if (developer.ID==id)
                {
                    _developerDatabase.Remove(developer);
                    return true;
                }
            }

            return false;
        }
    }

}
