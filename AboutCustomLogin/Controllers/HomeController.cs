using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using AboutCustomLogin.Models;

namespace AboutCustomLogin.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Index(string username)
        {
            if (Person.Validate(username))
            {
                FormsAuthentication.SetAuthCookie(username, false);
                return RedirectToAction("Index");
            }
            ModelState.AddModelError("","Usuário não encontrado.");
            return View();
        }        
    }
}
