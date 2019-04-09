using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NO.Web.App.Models;

namespace NO.Web.App.Controllers {
    public class HomeController : Controller {
        public IActionResult Index () {
            return View ();
        }

        public IActionResult Login () {
            return View ();
        }

        public IActionResult Privacy () { //fuck off
            return View ();
        }

        [ResponseCache (Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error () {
            return View (new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}