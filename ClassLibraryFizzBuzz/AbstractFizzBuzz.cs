using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCFizzBuzz.ClassLibraryFizzBuzz
{
    public abstract class AbstractFizzBuzz : IFizzBuzzCatagorizer
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