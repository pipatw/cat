using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CATCUSTINFO.Models;

namespace CATCUSTINFO.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.month = ImportClient.month;
            ViewBag.allClient = ImportClient.allClient;
            ViewBag.hinet = ImportClient.hinet;
            ViewBag.hotnet = ImportClient.hotnet;
            ViewBag.onnet = ImportClient.onnet;

            ViewBag.northClient = ImportClient.northClient;
            ViewBag.southClient = ImportClient.southClient;
            ViewBag.eastClient = ImportClient.eastClient;
            ViewBag.westClient = ImportClient.westClient;
            ViewBag.northEastClient = ImportClient.northEastClient;
            ViewBag.centerClient = ImportClient.centerClient;
            var x = ImportClient.northClient.LastOrDefault() / ImportClient.northKpi;
            ViewBag.northPer = ImportClient.northPer;

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}