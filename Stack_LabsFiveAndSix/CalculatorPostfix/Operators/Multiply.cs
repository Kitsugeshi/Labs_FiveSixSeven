using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_LabsFiveSixSeven.CalculatorPostfix.Operators
{
    public class Multiply : ICommand
    {
        public double Execute(double a, double b)
        {
            double result;
            try
            {
                checked
                {
                    result = a * b;
                }
            }
            catch (OverflowException e)
            {
                Console.WriteLine(e.Message);
                result = default;
            }
            return result;
        }
    }
}
