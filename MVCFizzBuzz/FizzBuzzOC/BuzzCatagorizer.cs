using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCFizzBuzz.FizzBuzzOC
{
    /// <summary>
    /// The Third rule we want is to return Buzz.
    /// The IsSatisfiedBy will check to see if the number passed is divisible by 5. If the number does not pass the rule, then move on to the next rule in the chain.
    /// </summary>
    

    public class BuzzCatagorizer : Catagorizer, IFactory
    {
        public override string IsSatisfiedBy(int number)
        {
            if (number % 5 == 0)
                return "Buzz";
            return Next.IsSatisfiedBy(number);
        }
    }
}