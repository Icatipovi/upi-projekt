using Football.Models;

namespace Football.Services
{
    public interface IGameServices
    {
        public IEnumerable<Game> GetAllGames();
        public void DeleteAGame(int id);
    }
}
