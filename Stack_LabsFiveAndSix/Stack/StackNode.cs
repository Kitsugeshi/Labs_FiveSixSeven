using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_LabsFiveSixSeven.Stack
{
    internal class StackNode<T> where T : struct
    {
        public T Data { get; set; }
        public StackNode<T>? Next { get; set; }
    }
}
