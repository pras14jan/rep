using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCFizzBuzz.FizzBuzzOC
{
    public class FizzCatagorizer : AbstractFizzBuzz
    {
        public override string IsSatisfiedBy(int number)
        {
            if (number % 3 == 0)
                return "Fizz";
            return abstractFizzBuzz.IsSatisfiedBy(number);
        }
    }
}