using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
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
