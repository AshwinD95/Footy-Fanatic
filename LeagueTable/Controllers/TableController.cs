using LeagueTable.Data;
using LeagueTable.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LeagueTable.Controllers
{
    public class TableController : Controller
    {
        // GET: Table
        public ActionResult Display()
        {
            var tableList = DBDataAccess.GetStandings();
            return View("LeagueTable", tableList);
        }
    }
}