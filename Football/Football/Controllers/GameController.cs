using Microsoft.AspNetCore.Mvc;
using Football.Context;
using Football.Models;
using Microsoft.EntityFrameworkCore;

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
            IEnumerable<Team> teams =db.Teams.Select(g => g).ToList();
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
        [HttpGet]
        public IActionResult Edit(int id)
        {
            Game game = db.Games.FirstOrDefault(g => g.Game_ID == id);
            if (game == null)
            {
                return View();
            }
            else
            {
                return View(game);
            }
        }
        [HttpPost]
        public IActionResult Edit(Game gm)
        {
            db.Games.Update(gm);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Details(int id)
        {
            Game game = db.Games.FirstOrDefault(p => p.Game_ID == id);
            IEnumerable<Team> teams = db.Teams.Select(g => g).ToList();
            return View(game);
        }
    }
}
