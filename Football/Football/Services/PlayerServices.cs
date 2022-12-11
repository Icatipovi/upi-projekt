using Football.Context;
using Football.Models;

namespace Football.Services
{
    public class PlayerServices : IPlayerServices
    {
        FLContext db;
        public PlayerServices(FLContext _db)
        {
            db = _db;
        }
        public void DeleteAPlayer(int id)
        {
            Player player = db.Players.FirstOrDefault(g => g.Player_ID == id);
            if (player != null)
            {
                db.Players.Remove(player);
                db.SaveChanges();
            }
        }

        public IEnumerable<Player> GetAllPlayers()
        {

            return (db.Players.Select(t => t).ToList());
        }
    }
}
