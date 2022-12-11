using Football.Models;

namespace Football.Services
{
    public interface ITeamServices
    {
        public IEnumerable<Team> GetAllTeams ();
        //public void DeleteATeam(int id);
    }
}
