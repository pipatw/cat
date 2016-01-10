using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CATCUSTINFO.Controllers
{
    public class MiscellaneousController : Controller
    {
        public ActionResult ChangeCulture(string returnUrl, string lang)
        {
            var langCookie = new HttpCookie("lang", lang) { HttpOnly = true };
            Response.AppendCookie(langCookie);

            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }
            return RedirectToAction("index", "home", new { culture = lang });
            //return RedirectToAction("index", "Home", new { culture = lang });
        }

    }
}