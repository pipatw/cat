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
            ViewBag.allClient = ImportClient.CountAll();
            ViewBag.hinet = ImportClient.CountService(1);
            ViewBag.hotnet = ImportClient.CountService(2);
            ViewBag.onnet = ImportClient.CountService(3);

            ViewBag.northMonth = ImportClient.countReg(1);
            ViewBag.northEastMonth = ImportClient.countReg(2);
            ViewBag.centerMonth = ImportClient.countReg(3);
            ViewBag.eastMonth = ImportClient.countReg(4);
            ViewBag.westMonth = ImportClient.countReg(5);
            ViewBag.southMonth = ImportClient.countReg(6);
            ViewBag.subMonth = ImportClient.countReg(7);

            ViewBag.northClient = ImportClient.northClient;
            ViewBag.southClient = ImportClient.southClient;
            ViewBag.eastClient = ImportClient.eastClient;
            ViewBag.westClient = ImportClient.westClient;
            ViewBag.northEastClient = ImportClient.northEastClient;
            ViewBag.centerClient = ImportClient.centerClient;
            ViewBag.subClient = ImportClient.subClient;
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