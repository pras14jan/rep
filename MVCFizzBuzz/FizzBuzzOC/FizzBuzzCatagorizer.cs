using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCFizzBuzz.FizzBuzzOC
{
    public class FizzBuzzCatagorizer : Catagorizer
    {
        public override string IsSatisfiedBy(int number)
        {
            if (number % 15 == 0)
                return "FizzBuzz";
            return Next.IsSatisfiedBy(number);
        }
    }
}