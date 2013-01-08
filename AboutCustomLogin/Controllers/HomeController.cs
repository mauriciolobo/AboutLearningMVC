using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace AboutCustomLogin.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

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
            FormsAuthentication.SetAuthCookie(username, false);
            return RedirectToAction("Index");
        }
    }
}
