using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_LabsFiveSixSeven.Stack.Exceptions
{
    internal class IndexException : ValueException
    {
        public IndexException(string message) : base(message) { }
    }
}
