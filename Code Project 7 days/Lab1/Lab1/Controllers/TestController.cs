using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab1.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Action method with string return type
        /// </summary>
        /// <returns></returns>
        public string GetString()
        {
            return "Hello World is old now. Its time to say Hello Bro ;-)";
        }

        /// <summary>
        /// Action method returns object
        /// </summary>
        /// <returns></returns>
        public Customer GetCustomer()
        {
            Customer cust = new Customer();
            cust.Name = "Grainger";
            cust.City = "LakeForest";
            return cust;
        }

        /// <summary>
        /// Non action public method
        /// </summary>
        /// <returns></returns>
        [NonAction]
        public string GetDetails()
        {
            return "This is not an action method";
        }

        /// <summary>
        /// Action Method with view as return type
        /// </summary>
        /// <returns></returns>
        public ActionResult GetView()
        {
            return View("MyView");
        }
    }   

    public class Customer
    {
        public string Name { get; set; }
        public string City { get; set; }

        public override string ToString()
        {
            return string.Format("Name: {0}, City: {1}", this.Name, this.City);
        }
    }
}