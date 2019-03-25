using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCFizzBuzz.ClassLibraryFizzBuzz;

namespace MVCFizzBuzz.ClassLibraryFizzBuzz
{
    public class FizzBuzz : IFizzBuzz
    {
        public string Calculate(int number)
        {
            return AbstractFizzBuzzChain.Calculate(number);
        }
    }

    public class FizzBuzzResult : IFizzBuzzResult
    {
       
        public List<string> ExecuteCalculate(int numb)
        {
            var verticalList = new List<string>();
            var fizzBuzz = new FizzBuzz();
            for (int index = 1; index <= numb; index++)
            {
                verticalList.Add(fizzBuzz.Calculate(index));
            }

            return verticalList;
        }
    }
}