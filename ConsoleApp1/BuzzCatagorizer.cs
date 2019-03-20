using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class BuzzCatagorizer : Catagorizer
    {
        public override string IsSatisfiedBy(int number)
        {
            if (number % 5 == 0)
                return "Buzz";
            return Next.IsSatisfiedBy(number);
        }
    }
}
