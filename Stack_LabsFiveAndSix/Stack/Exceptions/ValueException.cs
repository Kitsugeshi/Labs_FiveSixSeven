using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_LabsFiveSixSeven.Stack.Exceptions
{
    internal class ValueException : ContainerException
    {
        public ValueException(string message) : base(message) { }
    }
}
