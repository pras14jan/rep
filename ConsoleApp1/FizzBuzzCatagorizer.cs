using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class FizzBuzzCatagorizer : Catagorizer
    {
        public override string IsSatisfiedBy(int number)
        {
            if (number % 15 == 0)
                return "FizzBuzz";
            return Next.IsSatisfiedBy(number);
        }
    }
}
