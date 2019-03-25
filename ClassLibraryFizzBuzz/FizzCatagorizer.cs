using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCFizzBuzz.ClassLibraryFizzBuzz
{
    public class FizzCatagorizer : AbstractFizzBuzz, IFizzBuzzCatagorizer
    {
        public override string IsSatisfiedBy(int number)
        {
            if (number % 3 == 0)
                return "Fizz";
            return abstractFizzBuzz.IsSatisfiedBy(number);
        }
    }
}