using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Movistar.Controllers
{
    public class ChatRoamingController : Controller
    {
        // GET: ChatRoaming
        public ActionResult Index()
        {
            return RedirectToAction("Chat1");
        }

        [HttpGet]
        public ActionResult Chat1()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Chat1(int numero=0)
        {
            return RedirectToAction("ChatEnEspera");
        }

        [HttpGet]
        public ActionResult ChatEnEspera()
        {
            return View();
        }


    }
}