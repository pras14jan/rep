using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MVCFizzBuzz.Models
{
    public class FizzBuzzModel
    {
        [Range(1,1000)]
        [Required]
        [DisplayName("enter a number")]


        public int Num { get; set; }

        public List<string> FizzBuzzList { get; set; }

    }
}