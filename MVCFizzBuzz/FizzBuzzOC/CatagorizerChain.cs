using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCFizzBuzz.FizzBuzzOC
{
    /// <summary>
    /// Now that all the rules are in place, CatagorizerChain is a class that will specify the order in which the rules are to be implemented.
    /// How the order of the rules are created is important here. 
    /// 
    /// As you can see below, the chain is created as a singleton. In the constructor CatagorizerChain, we specify what is the first rule to be checked, and then each rule to be checked in order.
    ///So all that needs to be called is CatagorizerChain.Calculate(number);
    /// </summary>


    public class CatagorizerChain
    {
        private CatagorizerChain()
        {
            Head = new FizzBuzzCatagorizer();
            Head.RegisterNext(new BuzzCatagorizer())
                .RegisterNext(new FizzCatagorizer())
                .RegisterNext(new PlainNumberCatagorizer());
        }
        private Catagorizer Head { get; set; }

        public static string Calculate(int number)
        {
            return _instance.Head.IsSatisfiedBy(number);
        }

        private static readonly CatagorizerChain _instance = new CatagorizerChain();
    }
}