using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList array = new ArrayList(new[] {80, 74, 81, 90, 34 } );
           

            var loc = array.IndexOf(81);
            
            array.Insert(loc, 50);
            Console.WriteLine(" 50 추가");
            foreach (var item in array)
            {
                Console.WriteLine($"{item}");
            }

            loc = array.IndexOf(90);
            array.RemoveAt(loc);
            Console.WriteLine(" 90 삭제 ");
            foreach (var item in array)
            {
                Console.WriteLine($"{item}");
            }

            Console.WriteLine(" 나머지 배열 ");
            array.Sort();

            foreach (var item in array)
            {
                Console.WriteLine($"{item}");
            }
        }
    }
}
