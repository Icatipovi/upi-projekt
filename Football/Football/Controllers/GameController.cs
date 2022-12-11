using Microsoft.AspNetCore.Mvc;
using Football.Context;
using Football.Models;

namespace Football.Controllers
{
    public class GameController : Controller
    {
        FLContext db;
        public GameController(FLContext _db)
        {
            db = _db;
        }
        public IActionResult Index()
        {
            IEnumerable<Game> games = db.Games.Select(g => g).ToList();
            return View(games);
        }
        public IActionResult Delete(int id)
        {
            Game game = db.Games.FirstOrDefault(g => g.Game_ID == id);
            if(game != null)
            {
                db.Games.Remove(game);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
