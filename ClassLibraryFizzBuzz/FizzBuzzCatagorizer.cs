using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCFizzBuzz.ClassLibraryFizzBuzz
{
    public class FizzBuzzCatagorizer : AbstractFizzBuzz, IFizzBuzzCatagorizer
    {
        public override string IsSatisfiedBy(int number)
        {
            if (number % 15 == 0)
                return "FizzBuzz";
            return abstractFizzBuzz.IsSatisfiedBy(number);
        }
    }
}