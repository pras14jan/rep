using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCFizzBuzz.FizzBuzzOC
{
    /// <summary>
    ///  Chain Of Responsibility pattern- This pattern is defined as “consisting of a source of command objects and a series 
    ///  of processing objects. Each processing object contains logic that defines the types of command objects that it can handle; the rest are passed to the next processing object in the chain.”
    ///   IsSatisfiedBy is the method that each rule in the chain will call. If the rule is satisfied, then the text is returned, If the rule is not satisfied, then it will pass the execution onto the next rule in the chain.
    ///   The Next property does exactly what it says on the tin, it is the next rule to be processed. All of which is configured by the RegisterNext method which is used to specify the next rule in the chain.0
    /// </summary>
    

    public abstract class Catagorizer: IFactory
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