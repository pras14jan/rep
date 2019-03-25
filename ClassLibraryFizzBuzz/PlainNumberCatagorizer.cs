using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;

namespace MVCFizzBuzz.ClassLibraryFizzBuzz
{
    public class PlainNumberCatagorizer : AbstractFizzBuzz, IFizzBuzzCatagorizer
    {
        public override string IsSatisfiedBy(int number)
        {
            return number.ToString(CultureInfo.InvariantCulture);
        }
    }
}