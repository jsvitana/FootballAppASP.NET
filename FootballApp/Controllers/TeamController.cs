using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FootballApp.Controllers
{
    public class TeamController : Controller
    {
        // GET: Team
        public ActionResult Index()
        {
            return View();
        }

        //GET: Team/GameStats/{teamAbbr}
        public ActionResult GameStats(string id)
        {
            ViewBag.teamAbbr = id;
            return View();
        }
    }
}