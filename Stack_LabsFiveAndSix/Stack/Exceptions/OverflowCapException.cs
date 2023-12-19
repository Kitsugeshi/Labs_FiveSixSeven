using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_LabsFiveSixSeven.Stack.Exceptions
{
    internal class OverflowCapException : CapacityException
    {
        public OverflowCapException(string message) : base(message) { }
    }
}
