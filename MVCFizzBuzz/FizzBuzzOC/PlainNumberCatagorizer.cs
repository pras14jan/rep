using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;

namespace MVCFizzBuzz.FizzBuzzOC
{
    /// <summary>
    /// Now all that is required, is that if all the existing rules are not satisifed, is to just return the number.
    /// </summary>


    public class PlainNumberCatagorizer : Catagorizer, IFactory
    {
        public override string IsSatisfiedBy(int number)
        {
            return number.ToString(CultureInfo.InvariantCulture);
        }
    }
}