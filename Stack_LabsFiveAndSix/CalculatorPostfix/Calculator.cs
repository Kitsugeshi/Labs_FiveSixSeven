using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stack_LabsFiveSixSeven.CalculatorPostfix.Factory;
using Stack_LabsFiveSixSeven.CalculatorPostfix.Operators;
using Stack_LabsFiveSixSeven.Stack;

namespace Stack_LabsFiveSixSeven.CalculatorPostfix
{
    public static class Calculator
    {
        public static double Calculate(string postfix)
        {
            var elements = postfix.Split(" ");
            var stack = new CustomStack<double>(100);

            foreach (string element in elements)
            {
                if (!Operator.IsOperator(element))
                {
                    stack.Push(double.Parse(element));
                }
                else
                {
                    var rightOperand = stack.Pop();
                    var leftOperand = stack.Pop();

                    var command = CommandFactory.GetCommand(element);
                    stack.Push(command.Execute(leftOperand, rightOperand));
                }
            }

            return stack.Pop();
        }
    }
}
