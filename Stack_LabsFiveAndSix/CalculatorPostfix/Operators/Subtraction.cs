using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_LabsFiveSixSeven.CalculatorPostfix.Operators
{
    public class Subtraction : ICommand
    {
        public double Execute(double a, double b) => a - b;
    }
}
