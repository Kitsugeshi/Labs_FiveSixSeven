using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_LabsFiveSixSeven.CalculatorPostfix.Operators
{
    public class Operator
    {
        public char Token { get; init; }
        public byte Precedence { get; init; }
        public static bool IsOperator(string element) => element.Length == 1 && "+-*/".Contains(element);
    }
}
