using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_HW
{
    class Program
    {
        static void Main(string[] args)
        {
            //Q5

            Stack<Person> PerStack = new Stack<Person>();

            PerStack.Push(new Person(15));
            PerStack.Push(new Person(30));
            PerStack.Push(new Person(40));
            Person p = PerStack.Peek();
            Person p2 = PerStack.Pop();

            //Q4

            CreatInstance<Person> cip1 = new CreatInstance<Person>();
            cip1.Instance.Id = 5;

            CreatInstance<int> cipint = new CreatInstance<int>();
            cipint.Instance = 15;


            //Q3
            SortedArray<int> scInt = new SortedArray<int>();
            SortedArray<double> scDouble = new SortedArray<double>();

            scInt.AddItem(5);
            scInt.AddItem(2);

            scInt.AddItem(9);

            scInt.AddItem(1);

            scInt.AddItem(50);
            scInt.AddItem(52);
            scInt.AddItem(24);

            scInt.AddItem(39);

            scInt.AddItem(100);

            scInt.AddItem(500);

            scDouble.AddItem(3.2d);
            scDouble.AddItem(4.3d);
            scDouble.AddItem(1.1d);
            scDouble.AddItem(6.9d);
            scDouble.AddItem(5.2d);

            foreach (var item in scInt.MyArray)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("****double***");
            foreach (var item in scDouble.MyArray)
            {
                Console.WriteLine(item);
            }



            //Q1


            int[] arr1 = { 37, 45, 65 };
            int[] arr2 = { 70, 89, 118 };

            Console.WriteLine("Array 1...");
            foreach (int ele in arr1)
            {
                Console.WriteLine(ele);
            }

            Console.WriteLine("Array 2...");
            foreach (int ele in arr2)
            {
                Console.WriteLine(ele);
            }
            var myList = new List<int>();
            myList.AddRange(arr1);
            myList.AddRange(arr2);

            int[] arr3 = myList.ToArray();
            Console.WriteLine("Combined array elements..");
            foreach (int res in arr3)
            {
                Console.WriteLine(res);
            }
        }
    }
}
