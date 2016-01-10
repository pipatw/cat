using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CATCUSTINFO.Controllers
{
    public class DataImportController : Controller
    {
        // GET: DataImport
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Upload()
        {
            return View();
        }

        public ActionResult Reconcile(string id)
        {
            return View();
        }

    }
}