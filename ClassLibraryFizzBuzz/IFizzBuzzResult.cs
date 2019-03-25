using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCFizzBuzz.ClassLibraryFizzBuzz
{
    public interface IFizzBuzzResult
    {
        List<string> ExecuteCalculate(int numb);
    }
}
