using DeveloperApp.POCOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeveloperApp.Repository
{
    public class DeveloperTeamRepository
    {
        private readonly List<DeveloperTeam> _developerTeamDatabase = new List<DeveloperTeam>();

        private int _Count = 0;
        public bool CreateTeam(DeveloperTeam developerTeam)
        {
            if (developerTeam is null)
            {
                return false;
            }
            _Count++;
            developerTeam.ID = _Count;
            _developerTeamDatabase.Add(developerTeam);
            return true;
        }
        public IEnumerable<DeveloperTeam> GetDeveloperTeams()
        {
            return _developerTeamDatabase;
        }

        public DeveloperTeam GetDeveloperTeamByID(int id)
        {
            foreach (var team in _developerTeamDatabase)
            {
                if (team.ID==id)
                {
                    return team;
                }
            }
            return null;
        }

        public bool UpdateDeveloperTeam(int id, DeveloperTeam newDeveloperTeamData)
        {
            DeveloperTeam oldTeamData = GetDeveloperTeamByID(id);
            if (oldTeamData is null)
            {
                return false;
            }
            oldTeamData.ID = id;
            oldTeamData.TeamName = newDeveloperTeamData.TeamName;
            oldTeamData.TeamMembers = newDeveloperTeamData.TeamMembers;

            return true;
        }

        public bool DeleteDeveloperTeam(int id)
        {
            foreach (var team in _developerTeamDatabase)
            {
                if (team.ID==id)
                {
                    _developerTeamDatabase.Remove(team);
                    return true;
                }
            }
            return false;
        }
    }
}
