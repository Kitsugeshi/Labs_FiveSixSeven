using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_LabsFiveSixSeven.Stack.Exceptions
{
    internal class ContainerException : Exception
    {
        public ContainerException(string message) : base(message) { }
    }
}
