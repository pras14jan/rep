using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCFizzBuzz.FizzBuzzOC
{
    public class FizzBuzzCatagorizer : AbstractFizzBuzz
    {
        public override string IsSatisfiedBy(int number)
        {
            if (number % 15 == 0)
                return "FizzBuzz";
            return abstractFizzBuzz.IsSatisfiedBy(number);
        }
    }
}