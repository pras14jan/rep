using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCFizzBuzz.FizzBuzz
{
    public class FizzBuzzFactory: IFizzBuzzFactory
    {
        
        public List<string> FizzBuzz()
        {
            var Value = new List<string>();
            for(int i =1; i<=1000; i++)
            {
                if(i % 3 == 0 && i % 5 == 0)
                {
                    Value.Add("FizzBuzz");
                }
                else
                {
                    Value.Add(i.ToString());
                }
            }

            return Value;
            
        }

    }
}