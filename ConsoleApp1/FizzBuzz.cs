using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
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
        public List<string> Execute()
        {
            var a = new List<string>();
            
            var fb = new FizzBuzz();
            for (int index = 1; index <= 100; index++)
            {
                a.Add(fb.Calculate(index));
               // Console.WriteLine(fb.Calculate(index));
            }
            return a;
        }
    }
}
