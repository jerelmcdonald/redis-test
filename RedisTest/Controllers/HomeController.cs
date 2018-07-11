using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RedisTest.Models;

namespace RedisTest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var obj = 43621;// new ComplexClass(1, 100);
            
            var start = DateTime.Now;
            for (var i = 0; i < 1000; ++i)
            {
                Session[$"key{i}"] = obj;
            }

            var duration = (DateTime.Now - start).TotalMilliseconds;
            Debug.WriteLine($"Set duration = {duration.ToString()}");
            return View();
        }

        public ActionResult About()
        {
            var start = DateTime.Now;
            for (var i = 0; i < 1000; ++i)
            {
                var value = Session[$"key{i}"];
            }
            var duration = (DateTime.Now - start).TotalMilliseconds;
            ViewBag.Message = $"Get duration = {duration.ToString()}";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            Session.Abandon();
            return View();
        }
    }
}