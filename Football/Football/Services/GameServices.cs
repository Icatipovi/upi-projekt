using Football.Context;
using Football.Models;

namespace Football.Services
{
    public class GameServices : IGameServices
    {
        FLContext db;
        public GameServices(FLContext _db)
        {
            db = _db;
        }
        public void DeleteAGame(int id)
        {
            Game game = db.Games.FirstOrDefault(g => g.Game_ID == id);
            if (game != null)
            {
                db.Games.Remove(game);
                db.SaveChanges();
            }
        }

        public IEnumerable<Game> GetAllGames()
        {

            return (db.Games.Select(t => t).ToList());
        }
    }
}
