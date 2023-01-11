using Microsoft.AspNetCore.Mvc;
using Football.Context;
using Football.Models;
using Football.Services;

namespace Football.Controllers
{
    public class TeamController : Controller
    {
        
        FLContext db;
        public TeamController(FLContext _db)
        {
            db = _db;
        }
        

        public IActionResult Index()
        {
            IEnumerable<Team> teams = db.Teams.Select(t => t).ToList();
            return View(teams);
        }

        //brisanje kluba
        public IActionResult Delete(int id)
        {
            //iss.DeleteATeam(id);
            return RedirectToAction("Index");
        }

        //edit
        [HttpGet]
        public IActionResult Edit(int id)
        {
            Team team = db.Teams.FirstOrDefault(t => t.Team_ID == id);
            if (team == null)
            {
                return View();
            }
            else
            {
                return View(team);
            }
        }
        [HttpPost]
        public IActionResult Edit(Team tm)
        {
            db.Teams.Update(tm);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        //prikaz dodatnih informacija o klubu - ime kluba, grad u kojem se nalazi, pozicija na tablici, bodovi, trener
        public IActionResult Details(int id)
        {
            Team team = db.Teams.FirstOrDefault(t => t.Team_ID == id);
            IEnumerable<City> cities = db.Cities.Select(t => t).ToList();
            IEnumerable<Scale> scales = db.Scales.Select(t => t).ToList();
            IEnumerable<Coach> coaches = db.Coaches.Select(t => t).ToList();
            return View(team);
        }
    }
}
