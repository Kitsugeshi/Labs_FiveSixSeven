using Stack_LabsFiveSixSeven.CalculatorPostfix;
using Stack_LabsFiveSixSeven.CalculatorPostfix.ToPostfix;
using Stack_LabsFiveSixSeven.Stack;

Console.WriteLine(Calculator.Calculate(Expression.ToPostfix("( 55 + 5 ) + 5 * 5 * ( 8 - 9 ) / 5")));
