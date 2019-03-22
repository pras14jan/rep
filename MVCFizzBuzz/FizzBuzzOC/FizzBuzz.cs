using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCFizzBuzz.FizzBuzzOC
{
    /// <summary>
    /// FizzBuzz class is to call the chain, and ready to test.
    /// </summary>


    public class FizzBuzz
    {
        public List<string> Calculate(int number)
        {
            var verticalList = new List<string>();

            for (int index = 1; index <= number; index++)
            {
                verticalList.Add(CatagorizerChain.Calculate(number));
            }
            return verticalList;
        }
    }
}