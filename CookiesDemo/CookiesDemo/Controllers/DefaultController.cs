using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CookiesDemo.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            string cName = "welcomeMessage";
            HttpCookie cookie = Request.Cookies[cName];
            if (cookie == null)
            {
                Response.Cookies[cName].Value = "Välkommen!";
                Response.Cookies[cName].Expires = 
                    DateTime.Now.AddDays(1);
                ViewBag.CookieMessage = "Skapade cookie";
            }
            else
            {
                string message = Request.Cookies[cName].Value;
                ViewBag.CookieMessage = 
                    "Hittade cookie med meddelandet: "+ message;
            }
            return View();
        }
    }
}