using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCFizzBuzz.FizzBuzzOC
{
    /// <summary>
    /// The first rule we want is to return FizzBuzz.
    /// The IsSatisfiedBy will check to see if the number passed is divisible by 5 and divisible by 3. If the number does not pass the rule, then move on to the next rule in the chain.
    /// </summary>


    public class FizzBuzzCatagorizer : Catagorizer, IFactory
    {
        public override string IsSatisfiedBy(int number)
        {
            if (number % 15 == 0)
                return "FizzBuzz";
            return Next.IsSatisfiedBy(number);
        }
    }
}