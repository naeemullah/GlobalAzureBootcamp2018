using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace WebApp.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
            ViewBag.Msg = "";

            return View();
		}


        public string DoSomethingLong()
        {
            var rnd = new Random();
            var waitFor = rnd.Next(1000, 5000);

            System.Threading.Thread.Sleep(waitFor);
            var msg = String.Format("You have wait {0}. Sorry about that.", waitFor);

            return msg;
        }

        public ActionResult Test()
        {
            var rnd = new Random();
            var waitFor = rnd.Next(500, 5000);

            System.Threading.Thread.Sleep(waitFor);
            var msg = String.Format("You have wait {0} secondes. Sorry about that.", Math.Round(double.Parse(waitFor.ToString()) / 1000, 1));

            ViewBag.Msg = msg;

            return View("Index");
            
        }
    }
}