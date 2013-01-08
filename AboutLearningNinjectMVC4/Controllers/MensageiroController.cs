using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AboutLearningNinjectMVC4.Models;

namespace AboutLearningNinjectMVC4.Controllers
{
    public class MensageiroController : Controller
    {
        private readonly IDrugs _drugs;
        
        public MensageiroController(IDrugs drugs)
        {
            _drugs = drugs;
        }

        public ActionResult Index()
        {
            ViewBag.Message = _drugs.Use("Cocaine");
            return View();
        }

    }
}
