using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_HW
{
    public class CreatInstance<T>where T : new()
    {
        public T Instance { get; set; }

        public CreatInstance()
        {
            Instance = new T();
        }
    }

    class Person
    {
        public int Id { get; set; }

        public Person(int id)
        {
            Id = id;
        }
    }
}
