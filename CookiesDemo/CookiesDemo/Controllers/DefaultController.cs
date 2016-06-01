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
            HttpCookie cookie = Request.Cookies["cookie"];
            if (cookie == null)
            {
                Response.Cookies["cookie"].Value = "Välkommen!";
                Response.Cookies["cookie"].Expires = 
                    DateTime.Now.AddDays(1);
            }
            return View();
        }
    }
}