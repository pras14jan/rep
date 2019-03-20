using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCFizzBuzz.FizzBuzz;

namespace MVCFizzBuzz.FizzBuzz
{
     class FizzBuzzTest
    {
        IFizzBuzzFactory _Factory;
        IFizzFactory _Factory1;
        IBuzzFactory _Factory2;


        public FizzBuzzTest(IFizzBuzzFactory Factory, IFizzFactory Factory1, IBuzzFactory Factory2)
        {
            _Factory = new FizzBuzzFactory();
            _Factory1 = new FizzFactory();
            _Factory2 = new BuzzFactory();

            this._Factory = Factory;
            this._Factory1 = Factory1;
            this._Factory2 = Factory2;

        }
        public List<List<string>> ShowNumber(int number)
        {
            var verticalList = new List<List<string>>();
          //  verticalList = _Factory.FizzBuzz();

            //for(int i=1; i<=number; i++)
            //{
            //    if(i % 3 == 0 && i % 5 == 0)
            //    {
            //        //verticalList.Add("FizzBuzz");
            //        verticalList.Add(_Factory.FizzBuzz());
            //    }
            //    else if(i % 3 == 0)
            //    {
            //        //verticalList.Add("Fizz");
            //        verticalList.Add(_Factory1.Fizz());
            //    }
            //    else if(i % 5 == 0)
            //    {
            //        //verticalList.Add("Buzz");
            //        verticalList.Add(_Factory2.Buzz());
            //    }

            //    else
            //    {
            //        verticalList.Add(i.ToString());
            //    }
            //}

            verticalList.Add(_Factory.FizzBuzz());
            verticalList.Add(_Factory1.Fizz());
            verticalList.Add(_Factory2.Buzz());


            return verticalList;


        }
    }
}