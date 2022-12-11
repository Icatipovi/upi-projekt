using Football.Context;
using Football.Models;

namespace Football.Services
{
    public class TeamServices : ITeamServices
    {
        FLContext db;
        public TeamServices(FLContext _db)
        {
            db = _db;
        }
        /*public void DeleteATeam(int id)
        {
            Team team = db.Teams.FirstOrDefault(g => g.Team_ID == id);
            if (team != null)
            {
                db.Teams.Remove(team);
                db.SaveChanges();
            }
        }*/

        public IEnumerable<Team> GetAllTeams()
        {

            return (db.Teams.Select(t => t).ToList());
        }
    }
}
