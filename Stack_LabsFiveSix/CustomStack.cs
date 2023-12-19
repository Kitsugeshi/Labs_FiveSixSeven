using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_LabsFiveSix
{
    internal class CustomStack<T> : IEnumerable<T> where T : struct, IComparable
    {
        public StackNode<T>? Top { get; set; }
        public int Count { get; set; }
        public int Capacity { get; set; }

        public CustomStack(int size)
        {
            try
            {
                if (size <= 0)
                {
                    throw new Exception();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                size = 10;
            }

            Capacity = size;
        }

        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= Count)
                {
                    throw new Exception();
                }

                var current = Top;
                for (int i = 0; i < index; i++)
                {
                    current = current!.Next;
                }

                return current!.Data;
            }
            set
            {
                if (index < 0 || index >= Count)
                {
                    throw new Exception();
                }

                var current = Top;
                for (var i = 0; i < index; i++)
                {
                    current = current!.Next;
                }

                current!.Data = value;
            }
        }
        public void Push(T item)
        {
            if (Count == Capacity)
            {
                throw new Exception();
            }

            if (item is >= 500 || item is <= -500)
            {
                throw new Exception();
            }

            var newNode = new StackNode<T> { Data = item };

            if (Top == null)
            {
                Top = newNode;
            }
            else
            {
                newNode.Next = Top!;
                Top = newNode;
            }
            Count++;
        }

        public T Pop()
        {
            if (Top == null)
            {
                throw new Exception();
            }

            var current = Top;
            Top = Top.Next;
            Count--;
            return current.Data;
        }

        public T Peak()
        {
            if (Top == null)
            {
                throw new Exception();
            }
            return Top.Data;
        }

        public T Find(T item)
        {
            if (Top is null)
            {
                throw new Exception();
            }

            foreach (T i in this)
            {
                if (i.Equals(item)) return i;
            }

            return default;
        }

        public void Sort()
        {
            for (var i = 0; i < Count; i++)
            {
                for (var j = 0; j < Count - 1 - i; j++)
                {
                    if (this[j].CompareTo(this[j + 1]) > 0)
                    {
                        (this[j], this[j + 1]) = (this[j + 1], this[j]);
                    }
                }
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            StackNode<T> current = Top!;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next!;
            }
        }
    }
}
