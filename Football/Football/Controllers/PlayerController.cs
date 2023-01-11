using Microsoft.AspNetCore.Mvc;
using Football.Context;
using Football.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;
using System.Net.Sockets;

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
            IEnumerable<Team> teams = db.Teams.Select(p => p).ToList();
            return View(players);
        }

        //brisanje igrača
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
        [HttpGet]

        //uređivanje podataka o igraču
        public IActionResult Edit(int id)
        { 
            Player player = db.Players.FirstOrDefault(p=>p.Player_ID == id);
            if(player == null)
            {
                return View();
            }
            else
            {
                return View(player);             
            }
        }
        [HttpPost] 
        public IActionResult Edit(Player plyr)
        { 
                db.Players.Update(plyr);
                db.SaveChanges();
                return RedirectToAction("Index");
        }
        //prikaz dodatnih informacija o igraču - ime, prezime, broj na dresu, prosječna ocjena, ime kluba, pozicija
        public IActionResult Details(int id)
        {
            Player player = db.Players.FirstOrDefault(p => p.Player_ID == id);
            IEnumerable<Team> teams = db.Teams.Select(g => g).ToList();
            IEnumerable<Position> positions = db.Positions.Select(g => g).ToList();
            return View(player);
        }   

        //dodavanje novog igrača
        public IActionResult Create()
        {         
            Player pl = new Player();
            ViewBag.Positions = GetPositions();
            ViewBag.Teams = GetTeams();           
            return View(pl);
        }
        [HttpPost]
        public IActionResult Create(Player pl)
        {          
            db.Players.Add(pl);
            db.SaveChanges();           
            return RedirectToAction("Index");
        }

        // dohvaćanje pozicije
        private List<SelectListItem> GetPositions()
        {
            var lstPos=new List<SelectListItem>();
            IEnumerable<Team> teams = db.Teams.Select(g => g).ToList();
            IEnumerable<Position> positions = db.Positions.Select(g => g).ToList();
            lstPos = positions.Select(po => new SelectListItem()
            {
                Value = po.Position_ID.ToString(),
                Text = po.NameOfPosition
            }).ToList();
            var defItem2 = new SelectListItem()
            {
                Value = "",
                Text = "----Select Position----"
            };
            lstPos.Insert(0, defItem2);
            return lstPos;
        }

        //dohvaćanje kluba
        public List<SelectListItem> GetTeams()
        {
            var lstTe = new List<SelectListItem>();
            IEnumerable<Team> teams = db.Teams.Select(g => g).ToList();
            lstTe = teams.Select(te => new SelectListItem()
            {
                Value = te.Team_ID.ToString(),
                Text = te.NameOfTeam

            }).ToList();
            var defItem = new SelectListItem()
            {
                Value = "",
                Text = "----Select Team----"
            };
            lstTe.Insert(0, defItem);
            return lstTe;
        }
    }
}
