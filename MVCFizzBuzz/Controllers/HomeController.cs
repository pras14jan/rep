using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCFizzBuzz.Models;
using MVCFizzBuzz.FizzBuzz;
using MVCFizzBuzz.FizzBuzzOC;

namespace MVCFizzBuzz.Controllers
{
    public class HomeController : Controller
    {
        //IFizzBuzzFactory Factory = new FizzBuzzFactory();
        //IFizzFactory Factory1 = new FizzFactory();
        //IBuzzFactory Factory2 = new BuzzFactory();


        public ActionResult Index()
        {
            return View();
        }


        //[HttpPost]
        //public ActionResult Index(FizzBuzzModel FBM)
        //{
        //    FizzBuzzTest FBT = new FizzBuzzTest(Factory, Factory1, Factory2);

        //    FBM.FizzBuzzList = FBT.ShowNumber(FBM.Num);

        //    return View("Index1", FBM);
        //}



        [HttpPost]
        public ActionResult Index(FizzBuzzModel FBM)
        {
            ProcessCalculate PC = new ProcessCalculate();

            FBM.FizzBuzzList = PC.Execute(FBM.Num);
            

            return View("Index1", FBM);
        }


        //public ActionResult About()
        //{
        //    ViewBag.Message = "Your application description page.";

        //    return View();
        //}

        //public ActionResult Contact()
        //{
        //    ViewBag.Message = "Your contact page.";

        //    return View();
        //}
    }
}