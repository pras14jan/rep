using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCFizzBuzz.ClassLibraryFizzBuzz
{
    public class BuzzCatagorizer : AbstractFizzBuzz, IFizzBuzzCatagorizer
    {
        public override string IsSatisfiedBy(int number)
        {

                if (number % 5 == 0)
                return "Buzz";
            return abstractFizzBuzz.IsSatisfiedBy(number);

        }
    }

}