using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_LabsFiveSixSeven.CalculatorPostfix.Operators
{
    public class Division : ICommand
    {
        public double Execute(double a, double b)
        {
            var result = a / b;
            return double.IsInfinity(result) ? default : result;
        }
    }
}
