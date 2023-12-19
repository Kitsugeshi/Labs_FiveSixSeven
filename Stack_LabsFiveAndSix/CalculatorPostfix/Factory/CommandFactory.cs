using Stack_LabsFiveSixSeven.CalculatorPostfix.Operators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_LabsFiveSixSeven.CalculatorPostfix.Factory
{
    public static class CommandFactory
    {
        public static ICommand GetCommand(string token) => token switch
        {
            "*" => new Multiply(),
            "/" => new Division(),
            "+" => new Addition(),
            "-" => new Subtraction(),
            _ => throw new ArgumentOutOfRangeException(nameof(token))
        };
    }
}
