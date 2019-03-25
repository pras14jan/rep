using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCFizzBuzz.FizzBuzzOC
{
    public abstract class AbstractFizzBuzz : IFizzBuzz
    {

        protected AbstractFizzBuzz abstractFizzBuzz { get; private set; }



        public AbstractFizzBuzz NextCatagorizer(AbstractFizzBuzz obj)
        {
            abstractFizzBuzz = obj;
            return abstractFizzBuzz;
        }

      

        public abstract string IsSatisfiedBy(int number);
    }
}