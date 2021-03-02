using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClassApp
{
    class Array_Generic<T>
    {
        private T[] array;

        public Array_Generic()
        {
            array = new T[10];
        }

        public T GetElement(int index) { return array[index]; }

        public int Length { get { return array.Length; } }
    }

    
    class Program
    {
        static void Main(string[] args)
        {
            Array_Generic<int> array = new Array_Generic<int>();
        }
    }
}
