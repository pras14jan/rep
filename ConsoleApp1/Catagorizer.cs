using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Catagorizer
    {
        public Catagorizer RegisterNext(Catagorizer next)
        {
            Next = next;
            return Next;
        }

        protected Catagorizer Next { get; private set; }

        public abstract string IsSatisfiedBy(int number);
    }
}
