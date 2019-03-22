using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCFizzBuzz.Models;
using MVCFizzBuzz.FizzBuzzOC;

namespace MVCFizzBuzz.Controllers
{
    public class HomeController : Controller
    {
        


        public ActionResult Index()
        {
            return View();
        }


        


        [HttpPost]
        public ActionResult Index(FizzBuzzModel FBM)
        {
            

            FizzBuzz fizzBuzz = new FizzBuzz();

            FBM.FizzBuzzList = fizzBuzz.Calculate(FBM.Num);
            

            return View("Index1", FBM);
        }


    }
}