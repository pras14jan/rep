using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;

namespace MVCFizzBuzz.FizzBuzzOC
{
    public class PlainNumberCatagorizer : AbstractFizzBuzz
    {
        public override string IsSatisfiedBy(int number)
        {
            return number.ToString(CultureInfo.InvariantCulture);
        }
    }
}