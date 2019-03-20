using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCFizzBuzz.FizzBuzzOC
{
    public class FizzBuzz
    {
        public string Calculate(int number)
        {
            return CatagorizerChain.Calculate(number);
        }
    }

    public class ProcessCalculate
    {
        //public void Execute()
        //{
        //    var fb = new FizzBuzz();
        //    for (int index = 1; index <= 100; index++)
        //    {
        //        Console.WriteLine(fb.Calculate(index));
        //    }
        //}
        public List<string> Execute(int numb)
        {
            var verticalList = new List<string>();
            var fb = new FizzBuzz();
            for (int index = 1; index <= numb; index++)
            {
                verticalList.Add(fb.Calculate(index));
            }

            return verticalList;
        }
    }
}