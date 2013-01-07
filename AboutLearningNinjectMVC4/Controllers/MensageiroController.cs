using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AboutLearningNinjectMVC4.Controllers
{
    public class MensageiroController : Controller
    {        
        public ActionResult Index()
        {
            ViewBag.Message = "Olá mundo.";
            return View();
        }

    }
}
