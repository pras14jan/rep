using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCFizzBuzz.Models;
using ServicesFizzBuzz.FizzBuzzBusinessLogic;

namespace MVCFizzBuzz.Controllers
{
    public class HomeController : Controller
    {
        private readonly IFizzBuzzResult _fizzBuzzResult;

        public HomeController(IFizzBuzzResult fizzBuzzResult)
        {
            this._fizzBuzzResult = fizzBuzzResult;
        }

        public ActionResult Index()
        {
            return View();
        }



        [HttpPost]
        public ActionResult Index(FizzBuzzModel fizzBuzzModel)
        {
           

            fizzBuzzModel.FizzBuzzList = _fizzBuzzResult.ExecuteCalculate(fizzBuzzModel.Num);
            

            return View("FizzBuzzView", fizzBuzzModel);
        }


        
    }
}