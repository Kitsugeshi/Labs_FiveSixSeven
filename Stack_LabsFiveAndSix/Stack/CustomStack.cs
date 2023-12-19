using Stack_LabsFiveSixSeven.Stack.Exceptions;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_LabsFiveSixSeven.Stack
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
                    throw new CapacityException("Размер хранилища не может быть <= 0");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
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
                    throw new IndexException("Значение индекса выходит за рамки хранилища");
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
                    throw new IndexException("Значение индекса выходит за рамки хранилища");
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
                throw new OverflowCapException("Стек полон.");
            }

            if (item is >= 500 || item is <= -500)
            {
                throw new ItemException("Допустимый диапазон значение каждого элемента (-500;500).");
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
                throw new UnderflowCapException("Стэк пуст.");
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
                throw new UnderflowCapException("Стэк пуст.");
            }
            return Top.Data;
        }

        public T Find(T item)
        {
            if (Top is null)
            {
                throw new UnderflowCapException("Стэк пуст.");
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
