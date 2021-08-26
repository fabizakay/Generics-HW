using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_HW
{
    public class SortedArray<T> where T : struct
    {
        public T[] MyArray { get; set; } = new T[10];
        public int Count { get; set; } = 9;

        public void AddItem(T item)
        {
            MyArray[Count] = item;
            Count--;
            Array.Sort(MyArray);
        }

    }
}
