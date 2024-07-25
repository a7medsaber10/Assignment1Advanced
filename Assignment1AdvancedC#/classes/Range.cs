using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1AdvancedC_.classes
{
    internal class Range<T> where T : IComparable<T>
    {
        public T Min { get; private set; }
        public T Max { get; private set; }

        public Range(T _min, T _max) 
        {
            if (_min.CompareTo(_max) > 0)
            {
                Min = _max;
                Max = _min;
            }
            else
            {
                Max = _max;
                Min = _min;
            }
        }

        public bool IsInRange(T value)
        {
            return (value.CompareTo(Min) >= 0 && value.CompareTo(Max) <= 0);
        }

        public T RangeLength()
        {
            // (dynamic) in C# is used to declare dynamic types.
            // When you use dynamic, the compiler bypasses compile-time type checking, and instead, type checking is deferred to runtime. 
            dynamic min = Min;
            dynamic max = Max;
            return max - min;
        }
    }


}
