using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_HW
{
    public class Q2_ReadOnly<T>
    {
        
        public bool IsReadOnly = false;
        T[] Generics = new T[10];
        public int Count = 0;


        public  void Add(T data)
        {
            if (IsReadOnly == false)
            {
                Add(data);
                Count++;
            }
            else
                throw new InvalidOperationException("Read only is true");

        }
            
            
    }
}
