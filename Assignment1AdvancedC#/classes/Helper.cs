using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1AdvancedC_.classes
{
    internal class Helper<T> where T : IComparable<T>
    {
        public static void SWAP(ref T x,ref  T y)
        {
            T temp = x;
            x = y;
            y = temp;
        }

        public static void BubbleSort(T[] array)
        {
            if (array is not null)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = 0; j < array.Length - i - 1; j++)
                    {
                        if (array[j].CompareTo(array[j + 1]) == 1)
                        {
                            Helper<T>.SWAP(ref array[j], ref array[j + 1]);
                        }
                    }
                }
            } 
        }
    }
}
