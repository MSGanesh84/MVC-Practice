using Day_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Day_2.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Sending data from controller to View using ViewData
        /// </summary>
        /// <returns></returns>
        public ActionResult GetView()
        {
            Employee emp = new Employee();
            emp.FirstName = "Kannan";
            emp.LastName = "Paramasivam";
            emp.Salary = 5000;
            ViewData["Employee"] = emp;

            return View("myview");
        }
    }
}