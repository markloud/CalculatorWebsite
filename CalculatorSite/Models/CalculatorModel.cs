using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CalculatorSite.Models
{
    public class CalculatorModel
    {
        public double Num1 { get; set; }

        public double Num2 { get; set; }

        public char Operation { get; set; }

        public double Answer { get; set; }
    }
}