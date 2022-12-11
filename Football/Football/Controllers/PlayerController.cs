using Microsoft.AspNetCore.Mvc;
using Football.Context;
using Football.Models;

namespace Football.Controllers
{
    public class PlayerController : Controller
    {
        FLContext db;
        public PlayerController(FLContext _db)
        {
            db = _db;
        }
        public IActionResult Index()
        {
            IEnumerable<Player> players = db.Players.Select(p => p).ToList();
            return View(players);
        }

        public IActionResult Delete(int id)
        {
            Player player = db.Players.FirstOrDefault(p => p.Player_ID == id);
            if (player != null)
            {
                db.Players.Remove(player);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
