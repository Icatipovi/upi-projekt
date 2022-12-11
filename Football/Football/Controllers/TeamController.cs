using Microsoft.AspNetCore.Mvc;
using Football.Context;
using Football.Models;
using Football.Services;

namespace Football.Controllers
{
    public class TeamController : Controller
    {
        ITeamServices iss;
        public TeamController(ITeamServices _iss)
        {
            iss = _iss;
        }
        public IActionResult Index()
        {
            return View(iss.GetAllTeams());
        }

        public IActionResult Delete(int id)
        {
            //iss.DeleteATeam(id);
            return RedirectToAction("Index");
        }
    }
}
