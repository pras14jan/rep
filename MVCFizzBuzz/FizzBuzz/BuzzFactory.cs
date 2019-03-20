using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCFizzBuzz.FizzBuzz
{
    public class BuzzFactory: IBuzzFactory
    {
       

        public List<string> Buzz()
        {
            // return "Buzz";
            var Value2 = new List<string>();

            for (int i = 1; i <= 1000; i++)
            {
                if (i % 5 == 0)
                {
                    Value2.Add("Buzz");
                }
                else
                {
                    Value2.Add(i.ToString());
                }
            }

            return Value2;
        }

    }
}