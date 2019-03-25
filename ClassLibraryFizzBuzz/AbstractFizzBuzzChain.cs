using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCFizzBuzz.ClassLibraryFizzBuzz
{
    public class AbstractFizzBuzzChain
    {
        private AbstractFizzBuzzChain()
        {
            fizzBuzzCatagorizer = new FizzBuzzCatagorizer();
            fizzBuzzCatagorizer.NextCatagorizer(new BuzzCatagorizer())
                .NextCatagorizer(new FizzCatagorizer())
                .NextCatagorizer(new PlainNumberCatagorizer());
        }
        private AbstractFizzBuzz fizzBuzzCatagorizer { get; set; }

        public static string Calculate(int number)
        {
            return abstractFizzBuzzChain.fizzBuzzCatagorizer.IsSatisfiedBy(number);
        }

        private static readonly AbstractFizzBuzzChain abstractFizzBuzzChain = new AbstractFizzBuzzChain();
    }
}