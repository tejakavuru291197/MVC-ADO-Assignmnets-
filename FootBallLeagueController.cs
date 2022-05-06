using FootBallLeague2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FootBallLeague2.Controllers
{
    public class FootBallLeagueController : Controller
    {
        // GET: FootBallLeague
        public ActionResult Index()
        {
            FootBallLeagueContext league = new FootBallLeagueContext();
            List<FootBallLeague> ll = league.FootBallLeagues.ToList();
            return View(ll);
        }
    }
}