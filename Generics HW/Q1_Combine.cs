using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_HW
{
    public class Q1_Combine<T>
    {
        public static T[] Combine<T>(T[] first, T[] second)
        {
            int i = 0;
            T[] result = new T[first.Length + second.Length];
            foreach (var item in first)
            {
                result[i++] = item;
            }
            foreach (var item in second)
            {
                result[i++] = item;
            }
            return result;
        }
    }

}
