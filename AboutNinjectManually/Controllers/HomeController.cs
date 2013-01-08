using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AboutNinjectManually.Models;

namespace AboutNinjectManually.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDrugDealer _drugDealer;

        public HomeController(IDrugDealer drugDealer)
        {
            _drugDealer = drugDealer;
        }

        public ActionResult Index()
        {
            return View(_drugDealer);
        }

    }
}
