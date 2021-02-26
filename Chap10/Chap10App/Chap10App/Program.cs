using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap10App
{
    class Test
    { }
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 80, 74, 81, 90, 34 };

            Console.WriteLine($"Type of array : {array.GetType()}");
            Console.WriteLine($"Base Type of array : {array.GetType().BaseType}");

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{i}번째 값 : {array[i]}");
            }

            Console.WriteLine("크기변경");
            Array.Resize(ref array, 6);
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{i}번째 값 : {array[i]}");
            }

            Console.WriteLine("81 인덱스 찾기");
            int idx = Array.IndexOf(array, 81);
            for (int i = array.Length - 1; i >= idx; i--)
            {
                array[i] = array[i - 1];
            }

            array[idx] = 50;
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{i}번째 값 : {array[i]}");
            }
        }
    }
}
            /* var idx = 0;
             foreach (var item in array)
             {
                 Console.WriteLine($"{idx++}번째 값 : {item}");
             }*/

//            Console.WriteLine("오름차순 정렬");
//            Array.Sort(array);
//            for (int i = 0; i < array.Length; i++)
//            {
//                Console.WriteLine($"{i}번째 값 : {array[i]}");
//            }

//            Console.WriteLine("내림차순 정렬");
//            Array.Reverse(array);
//            for (int i = 0; i < array.Length; i++)
//            {
//                Console.WriteLine($"{i}번째 값 : {array[i]}");
//            }

//           int idx = Array.IndexOf(array, 34);
//            Console.WriteLine($"34의 인덱스 : {idx}");

//            idx = Array.IndexOf(array, 100);
//            Console.WriteLine($"34의 인덱스 : {idx}");

//            Console.WriteLine("배열 삭제");
//            Array.Clear(array, 3, 2);
//            for (int i = 0; i < array.Length; i++)
//            {
//                Console.WriteLine($"{i}번째 값 : {array[i]}");
//            }
//        }
//    }
//}
