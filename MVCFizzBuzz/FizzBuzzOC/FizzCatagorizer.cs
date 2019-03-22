using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCFizzBuzz.FizzBuzzOC
{
    /// <summary>
    /// The second rule we want is to return Fizz.
    /// The IsSatisfiedBy will check to see if the number passed is divisible by 3. If the number does not pass the rule, then move on to the next rule in the chain.
    /// </summary>


    public class FizzCatagorizer : Catagorizer, IFactory
    {
        public override string IsSatisfiedBy(int number)
        {
            if (number % 3 == 0)
                return "Fizz";
            return Next.IsSatisfiedBy(number);
        }
    }
}