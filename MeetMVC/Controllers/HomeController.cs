using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MeetMVC.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Chat()
        {
            return View();
        }
    }
}
