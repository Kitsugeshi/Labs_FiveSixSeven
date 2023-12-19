using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_LabsFiveSixSeven.CalculatorPostfix.Operators
{
    public static class OperatorsContainer
    {
        public static List<Operator> Operators { get; } = new()
        {
            new Operator { Token = '/', Precedence = 1 },
            new Operator { Token = '*', Precedence = 1 },
            new Operator { Token = '-', Precedence = 0 },
            new Operator { Token = '+', Precedence = 0 }
        };
    }
}
