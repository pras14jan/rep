using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCFizzBuzz.FizzBuzz
{
    public class FizzFactory: IFizzFactory
    {
        
        public List<string> Fizz()
        {
            // return "Fizz";
            var Value1 = new List<string>();

            for (int i = 1; i <= 1000; i++)
            {
                if (i % 3 == 0)
                {
                    Value1.Add("Fizz");
                }
                else
                {
                    Value1.Add(i.ToString());
                }
            }

            return Value1; 
        }
    }
}