using Football.Models;

namespace Football.Services
{
    public interface IPlayerServices
    {
        public IEnumerable<Player> GetAllPlayers();
        public void DeleteAPlayer(int id);
    }
}
