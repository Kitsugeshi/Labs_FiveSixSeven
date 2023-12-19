using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_LabsFiveSixSeven.Stack.Exceptions
{
    internal class CapacityException : ContainerException
    {
        public CapacityException(string message) : base(message) { }
    }
}
