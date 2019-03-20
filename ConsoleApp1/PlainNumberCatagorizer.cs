﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class PlainNumberCatagorizer : Catagorizer
    {
        public override string IsSatisfiedBy(int number)
        {
            return number.ToString(CultureInfo.InvariantCulture);
        }
    }
}
