using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CSCarterDotNet.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View("Index");
        }  //Index

        public ActionResult About()
        {
            return View("About");
        }  //About

        public ActionResult Contact()
        {
            return View("Contact");
        }  //Contact

        public ActionResult Portfolio()
        {
            return View("Portfolio");
        }  //Portfolio

        public ActionResult A5netcore()
        {
            return View("A5netcore");
        }  //a5netcore
    }  //class
}  //namespace